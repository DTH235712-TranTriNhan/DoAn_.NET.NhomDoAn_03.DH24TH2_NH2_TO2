using System;
using System.Collections.Generic;
using System.Drawing; // Thư viện để vẽ giao diện, màu sắc
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms
{
    public partial class UCCart : UserControl
    {
        // Định nghĩa các Event
        public delegate void CartUpdateHandler(int totalItems);
        public event CartUpdateHandler OnCartUpdated;
        public event EventHandler OnCheckoutCompleted;

        // Class lưu trữ tạm thông tin giỏ hàng
        private class CartItem
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public string Note { get; set; }
            public decimal Total => Price * Quantity;

            // Giả lập ảnh (bạn có thể thay bằng đường dẫn ảnh thực tế từ DB)
            public Image ProductImage { get; set; }
        }

        private List<CartItem> _cartItems = new List<CartItem>();

        public UCCart()
        {
            InitializeComponent();
            SetupModernUI(); // <--- Gọi hàm làm đẹp giao diện

            // Gán sự kiện
            btnPay.Click += btnPay_Click;
            dgvCart.CellContentClick += dgvCart_CellContentClick;

            // Khởi tạo
            UpdateCartTotal(0);
        }

        // --- PHẦN CUSTOM GIAO DIỆN (Làm đẹp) ---
        private void SetupModernUI()
        {
            // 1. Cài đặt DataGridView giống danh sách (List)
            dgvCart.BackgroundColor = Color.White;
            dgvCart.BorderStyle = BorderStyle.None;
            dgvCart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.GridColor = Color.FromArgb(230, 230, 230); // Đường kẻ mờ

            dgvCart.ColumnHeadersVisible = false; // Ẩn tiêu đề cột để giống App
            dgvCart.RowHeadersVisible = false;

            dgvCart.RowTemplate.Height = 100; // Chiều cao dòng lớn để chứa ảnh
            dgvCart.DefaultCellStyle.SelectionBackColor = Color.White; // Bỏ màu xanh khi chọn
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCart.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvCart.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Cho phép xuống dòng

            // 2. Panel Tổng tiền & Nút
            pnlTotal.BackColor = Color.White;
            // Vẽ đường viền trên panel tổng tiền
            pnlTotal.Paint += (s, e) => {
                e.Graphics.DrawLine(new Pen(Color.LightGray), 0, 0, pnlTotal.Width, 0);
            };

            // 3. Nút Thanh toán (Màu đỏ cam nổi bật)
            btnPay.BackColor = Color.FromArgb(238, 77, 45);
            btnPay.ForeColor = Color.White;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPay.Cursor = Cursors.Hand;
        }

        // --- LOGIC GIỎ HÀNG ---

        public void AddToCart(string name, decimal price, int qty = 1, string note = "", Image productImg = null)
        {
            var exist = _cartItems.FirstOrDefault(x => x.ProductName == name && x.Note == note);
            if (exist != null)
            {
                exist.Quantity += qty;
            }
            else
            {
                // Nếu không truyền ảnh vào thì mới dùng ảnh xám mặc định
                Image finalImg = productImg;
                if (finalImg == null)
                {
                    finalImg = new Bitmap(80, 80);
                    using (Graphics g = Graphics.FromImage(finalImg)) { g.Clear(Color.LightGray); }
                }

                _cartItems.Add(new CartItem
                {
                    ProductName = name,
                    Price = price,
                    Quantity = qty,
                    Note = note,
                    ProductImage = finalImg // Lưu ảnh thật vào đây
                });
            }

            ReloadCartGrid();
        }

        private void ReloadCartGrid()
        {
            dgvCart.Rows.Clear();
            decimal grandTotal = 0;

            foreach (var item in _cartItems)
            {
                // Tạo chuỗi tên hiển thị
                string displayName = item.ProductName;
                string displayNote = string.IsNullOrEmpty(item.Note) ? "" : $"\nNote: {item.Note}";

                // Add dòng vào Grid
                // Thứ tự: [0]Ảnh, [1]Tên+Note, [2]SL, [3]Thành tiền, [4]Nút Xóa
                int index = dgvCart.Rows.Add(
                    item.ProductImage,
                    displayName + displayNote,
                    $"x{item.Quantity}",
                    item.Total.ToString("N0") + "đ",
                    "✕" // Ký tự nút xóa
                );

                grandTotal += item.Total;

                // --- Format từng dòng cho đẹp ---
                var row = dgvCart.Rows[index];

                // Tên món: Font đậm
                row.Cells[1].Style.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                row.Cells[1].Style.Padding = new Padding(5, 10, 0, 0); // Căn lề

                // Thành tiền: Màu đỏ cam
                row.Cells[3].Style.ForeColor = Color.FromArgb(238, 77, 45);
                row.Cells[3].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                // Nút Xóa: Màu xám nhạt
                row.Cells[4].Style.ForeColor = Color.Gray;
                row.Cells[4].Style.Font = new Font("Arial", 12F);
            }

            // Cập nhật Label Tổng tiền
            lblTotalVal.Text = grandTotal.ToString("N0") + "đ";
            lblTotalVal.ForeColor = Color.FromArgb(238, 77, 45); // Màu đỏ cam

            // Update event ra ngoài
            int totalItems = _cartItems.Sum(x => x.Quantity);
            UpdateCartTotal(totalItems);
        }

        private void UpdateCartTotal(int totalItems)
        {
            OnCartUpdated?.Invoke(totalItems);
        }

        private void ResetCart()
        {
            _cartItems.Clear();
            ReloadCartGrid();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_cartItems.Count == 0) { MessageBox.Show("Giỏ hàng trống!"); return; }
            if (Session.CurrentUser == null) { MessageBox.Show("Vui lòng đăng nhập!"); return; }

            if (MessageBox.Show("Xác nhận đặt đơn hàng này?", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var order = new order
                    {
                        user_id = Session.CurrentUser.id,
                        created_at = DateTime.Now,
                        status = "Pending",
                        total_money = _cartItems.Sum(x => x.Total),
                        payment_method = "Tiền mặt"
                    };
                    db.orders.Add(order);
                    db.SaveChanges();

                    foreach (var item in _cartItems)
                    {
                        var prod = db.products.FirstOrDefault(p => p.name == item.ProductName);
                        if (prod == null) continue;

                        db.order_details.Add(new order_details
                        {
                            order_id = order.id,
                            product_id = prod.id,
                            quantity = item.Quantity,
                            unit_price = item.Price
                        });
                    }
                    db.SaveChanges();

                    MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetCart();
                    OnCheckoutCompleted?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message);
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý nút Xóa (Cột index 4)
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Bạn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _cartItems.RemoveAt(e.RowIndex);
                    ReloadCartGrid();
                }
            }
        }
    }
}