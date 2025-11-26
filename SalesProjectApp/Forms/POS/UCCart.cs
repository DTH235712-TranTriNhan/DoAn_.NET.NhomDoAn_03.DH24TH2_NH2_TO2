using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models; // Đảm bảo các models (order, order_details...) có sẵn

namespace SalesProjectApp.Forms
{
    public partial class UCCart : UserControl
    {
        // ----------------------------------------------------
        // 1. KHAI BÁO EVENTS CHO POSFORM ĐĂNG KÝ
        // ----------------------------------------------------

        // Delegate cho sự kiện cập nhật Giỏ hàng (Truyền tổng số lượng món)
        public delegate void CartUpdateHandler(int totalItems);
        public event CartUpdateHandler OnCartUpdated;

        // Sự kiện Thanh toán hoàn tất (Sử dụng chuẩn EventHandler)
        public event EventHandler OnCheckoutCompleted;

        // ----------------------------------------------------

        private class CartItem
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public string Note { get; set; }
            public decimal Total => Price * Quantity;
        }

        private List<CartItem> _cartItems = new List<CartItem>();

        public UCCart()
        {
            InitializeComponent();
            // Gán sự kiện cho nút Thanh toán
            btnPay.Click += btnPay_Click;
            // Gán sự kiện cho DataGridView
            dgvCart.CellContentClick += dgvCart_CellContentClick;

            // Giả định: UIHelper.StyleDataGridView(dgvCart);
        }

        public void AddToCart(string name, decimal price, int qty, string note = "")
        {
            // Cộng dồn nếu cùng tên và cùng ghi chú
            var exist = _cartItems.FirstOrDefault(x => x.ProductName == name && x.Note == note);
            if (exist != null)
            {
                exist.Quantity += qty;
            }
            else
            {
                _cartItems.Add(new CartItem { ProductName = name, Price = price, Quantity = qty, Note = note });
            }
            ReloadCartGrid();
        }

        private void ReloadCartGrid()
        {
            dgvCart.Rows.Clear();
            decimal grandTotal = 0;

            foreach (var item in _cartItems)
            {
                string displayName = item.ProductName;
                // Hiển thị ghi chú nếu có
                if (!string.IsNullOrEmpty(item.Note)) displayName += $"\n({item.Note})";

                // Giả sử các cột: Tên món, Số lượng, Giá, Tổng, Xóa
                dgvCart.Rows.Add(displayName, item.Quantity, item.Price.ToString("N0"), item.Total.ToString("N0"), "X");
                grandTotal += item.Total;
            }
            lblTotalVal.Text = grandTotal.ToString("N0") + "đ";

            // *** KÍCH HOẠT EVENT CẬP NHẬT GIỎ HÀNG ***
            int totalItems = _cartItems.Sum(x => x.Quantity);
            OnCartUpdated?.Invoke(totalItems);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_cartItems.Count == 0) { MessageBox.Show("Giỏ hàng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Session.CurrentUser == null) { MessageBox.Show("Vui lòng đăng nhập để đặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("Xác nhận đặt hàng và thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

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
                    db.SaveChanges(); // Lưu để lấy order.id

                    // Thêm chi tiết đơn hàng
                    foreach (var item in _cartItems)
                    {
                        var prod = db.products.FirstOrDefault(p => p.name == item.ProductName);
                        if (prod != null)
                        {
                            db.order_details.Add(new order_details
                            {
                                order_id = order.id,
                                product_id = prod.id,
                                quantity = item.Quantity,
                                unit_price = item.Price
                            });
                        }
                    }

                    // Lưu Ghi chú/Shipping (nếu cần)
                    var notes = string.Join("; ", _cartItems.Where(x => !string.IsNullOrEmpty(x.Note)).Select(x => $"{x.ProductName}: {x.Note}"));
                    if (!string.IsNullOrEmpty(notes))
                    {
                        // Giả định: shipping_info tồn tại
                        db.shipping_info.Add(new shipping_info
                        {
                            order_id = order.id,
                            recipient_name = Session.CurrentUser.full_name,
                            phone_number = Session.CurrentUser.phone_number ?? "",
                            address = "Tại cửa hàng",
                            notes = notes
                        });
                    }

                    db.SaveChanges();

                    MessageBox.Show("Đặt hàng thành công! Vui lòng theo dõi trạng thái tại mục Lịch Sử.", "Thành công");
                    _cartItems.Clear();
                    ReloadCartGrid(); // Reload giỏ hàng trống

                    // *** KÍCH HOẠT EVENT THANH TOÁN HOÀN TẤT ***
                    OnCheckoutCompleted?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xóa món (Cột nút xóa là cột cuối cùng index 4)
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                _cartItems.RemoveAt(e.RowIndex);
                ReloadCartGrid();
            }
        }
    }
}