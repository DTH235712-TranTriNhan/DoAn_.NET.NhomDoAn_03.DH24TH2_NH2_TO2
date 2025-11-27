using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models; // Đảm bảo namespace này đúng với project của bạn

namespace SalesProjectApp.Forms
{
    public partial class UCCart : UserControl
    {
        // Các sự kiện để giao tiếp với Form cha (PosForm)
        public delegate void CartUpdateHandler(int totalItems);
        public event CartUpdateHandler OnCartUpdated;
        public event EventHandler OnCheckoutCompleted;

        // Class nội bộ lưu trữ thông tin món trong giỏ
        private class CartItem
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public string Note { get; set; }
            public decimal Total => Price * Quantity;
            public Image ProductImage { get; set; }
        }

        private List<CartItem> _cartItems = new List<CartItem>();

        public UCCart()
        {
            InitializeComponent();

            // 1. Kiểm tra và tạo cột nếu Designer bị lỗi (Cơ chế an toàn)
            CheckAndSetupColumns();

            // 2. Làm đẹp giao diện
            SetupModernUI();

            // 3. Gán sự kiện
            btnPay.Click += btnPay_Click;
            dgvCart.CellContentClick += dgvCart_CellContentClick;

            UpdateCartTotal(0);
        }

        // --- HÀM KIỂM TRA & TẠO CỘT (AN TOÀN) ---
        private void CheckAndSetupColumns()
        {
            if (dgvCart.Columns.Count == 0)
            {
                // Cột 0: Ảnh
                var colImg = new DataGridViewImageColumn();
                colImg.Name = "colImg";
                colImg.HeaderText = "";
                colImg.Width = 130;
                colImg.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvCart.Columns.Add(colImg);

                // Cột 1: Tên
                var colName = new DataGridViewTextBoxColumn();
                colName.Name = "colName";
                colName.HeaderText = "Sản phẩm";
                colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                colName.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Quan trọng để xuống dòng
                dgvCart.Columns.Add(colName);

                // Cột 2: Số lượng
                var colQty = new DataGridViewTextBoxColumn();
                colQty.Name = "colQty";
                colQty.HeaderText = "SL";
                colQty.Width = 50;
                colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCart.Columns.Add(colQty);

                // Cột 3: Thành tiền
                var colTotal = new DataGridViewTextBoxColumn();
                colTotal.Name = "colTotal";
                colTotal.HeaderText = "Tổng";
                colTotal.Width = 100;
                colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colTotal.DefaultCellStyle.Format = "N0";
                colTotal.DefaultCellStyle.ForeColor = Color.FromArgb(238, 77, 45);
                dgvCart.Columns.Add(colTotal);

                // Cột 4: Xóa
                var colDel = new DataGridViewButtonColumn();
                colDel.Name = "colDelete";
                colDel.HeaderText = "";
                colDel.Text = "✕";
                colDel.UseColumnTextForButtonValue = true;
                colDel.Width = 40;
                colDel.FlatStyle = FlatStyle.Flat;
                dgvCart.Columns.Add(colDel);
            }
        }

        private void SetupModernUI()
        {
            // Tổng thể bảng
            dgvCart.BackgroundColor = Color.White;
            dgvCart.BorderStyle = BorderStyle.None;
            dgvCart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.GridColor = Color.FromArgb(230, 230, 230);
            dgvCart.ColumnHeadersVisible = false;
            dgvCart.RowHeadersVisible = false;

            // Thiết lập dòng cao để chứa ảnh và note
            dgvCart.RowTemplate.Height = 150;

            dgvCart.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCart.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvCart.DefaultCellStyle.Padding = new Padding(5);

            // Panel tổng tiền
            pnlTotal.BackColor = Color.White;
            pnlTotal.Paint += (s, e) => {
                e.Graphics.DrawLine(new Pen(Color.LightGray), 0, 0, pnlTotal.Width, 0);
            };

            // Nút thanh toán
            btnPay.BackColor = Color.FromArgb(238, 77, 45);
            btnPay.ForeColor = Color.White;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnPay.Cursor = Cursors.Hand;
        }

        // --- LOGIC THÊM VÀO GIỎ ---
        public void AddToCart(string name, decimal price, int qty = 1, string note = "", Image productImg = null)
        {
            // Tìm sản phẩm trùng tên và trùng ghi chú
            var exist = _cartItems.FirstOrDefault(x => x.ProductName == name && x.Note == note);

            if (exist != null)
            {
                exist.Quantity += qty;
            }
            else
            {
                // Tạo ảnh placeholder nếu null
                Image finalImg = productImg;
                if (finalImg == null)
                {
                    finalImg = new Bitmap(120, 120);
                    using (Graphics g = Graphics.FromImage(finalImg))
                    {
                        g.Clear(Color.FromArgb(245, 245, 245));
                        // Vẽ chữ No Image
                    }
                }

                _cartItems.Add(new CartItem
                {
                    ProductName = name,
                    Price = price,
                    Quantity = qty,
                    Note = note,
                    ProductImage = finalImg
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
                // Xử lý hiển thị Tên + Ghi chú
                string displayName = item.ProductName;
                if (!string.IsNullOrEmpty(item.Note))
                {
                    // Thêm xuống dòng để ghi chú nằm dưới
                    displayName += Environment.NewLine + $"({item.Note})";
                }

                int rowIndex = dgvCart.Rows.Add(
                    item.ProductImage,
                    displayName,
                    $"x{item.Quantity}",
                    item.Total.ToString("N0") + "đ",
                    "✕"
                );

                grandTotal += item.Total;

                // Style riêng cho từng dòng
                var row = dgvCart.Rows[rowIndex];
                row.Cells[1].Style.Font = new Font("Segoe UI", 11F, FontStyle.Bold); // Tên đậm
                row.Cells[1].Style.WrapMode = DataGridViewTriState.True; // Cho phép xuống dòng
                row.Cells[1].Style.Padding = new Padding(10, 10, 5, 10); // Cách lề

                row.Cells[3].Style.ForeColor = Color.FromArgb(238, 77, 45); // Tiền màu đỏ
                row.Cells[3].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                row.Cells[4].Style.ForeColor = Color.Red; // Nút X xóa màu đỏ
            }

            lblTotalVal.Text = grandTotal.ToString("N0") + "đ";

            UpdateCartTotal(_cartItems.Sum(x => x.Quantity));
        }

        private void UpdateCartTotal(int totalItems)
        {
            OnCartUpdated?.Invoke(totalItems);
        }

        public void ResetCart()
        {
            _cartItems.Clear();
            ReloadCartGrid();
        }

        // --- SỰ KIỆN THANH TOÁN ---
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
                        // Tìm sản phẩm để lấy ID
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

                    // Lưu ghi chú tổng hợp vào bảng ShippingInfo
                    var allNotes = _cartItems.Where(x => !string.IsNullOrEmpty(x.Note))
                                             .Select(x => $"{x.ProductName}: {x.Note}").ToList();
                    if (allNotes.Any())
                    {
                        db.shipping_info.Add(new shipping_info
                        {
                            order_id = order.id,
                            recipient_name = Session.CurrentUser.full_name,
                            address = "Tại quầy",
                            phone_number = "",
                            notes = string.Join("; ", allNotes)
                        });
                    }

                    db.SaveChanges();

                    MessageBox.Show("Đặt hàng thành công!", "Thông báo");
                    ResetCart();
                    OnCheckoutCompleted?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nút Xóa nằm ở cột cuối cùng (Index 4)
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                _cartItems.RemoveAt(e.RowIndex);
                ReloadCartGrid();
            }
        }
    }
}