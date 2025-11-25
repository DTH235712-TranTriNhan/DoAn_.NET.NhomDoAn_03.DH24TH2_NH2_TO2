using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class FormOrderDetail : Form
    {
        private int _orderId;

        // Hỗ trợ di chuyển Form khi không có Border
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormOrderDetail(int orderId)
        {
            InitializeComponent();
            UIHelper.StyleDataGridView(dgvItems);
            _orderId = orderId;

            // Gắn sự kiện kéo thả Form cho phần Header
            pnlHeader.MouseDown += (s, e) => { dragging = true; dragCursorPoint = Cursor.Position; dragFormPoint = this.Location; };
            pnlHeader.MouseMove += (s, e) => { if (dragging) { Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint)); this.Location = Point.Add(dragFormPoint, new Size(dif)); } };
            pnlHeader.MouseUp += (s, e) => { dragging = false; };

            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    // 1. Lấy thông tin đơn hàng & user & shipping_info (nếu có)
                    var order = db.orders.Find(_orderId);
                    if (order != null)
                    {
                        lblTitle.Text = $"🧾 Đơn hàng #{order.id}";

                        // Thông tin khách hàng
                        string name = order.user != null ? order.user.full_name : "Khách vãng lai";
                        string phone = order.user != null ? order.user.phone_number : "---";

                        // Nếu có bảng ShippingInfo thì lấy địa chỉ từ đó, không thì lấy tạm
                        // Vì DB của bạn bảng ShippingInfo dùng order_id làm khóa ngoại
                        var shipInfo = db.shipping_info.FirstOrDefault(s => s.order_id == _orderId);
                        string address = shipInfo != null ? shipInfo.address : "Tại cửa hàng";
                        string note = shipInfo != null ? shipInfo.notes : "Không có ghi chú.";

                        lblCusName.Text = "👤 " + name;
                        lblCusPhone.Text = "📞 " + phone;
                        lblCusAddress.Text = "📍 " + address;
                        lblNoteContent.Text = note;

                        // Tổng tiền
                        lblTotalMoney.Text = (order.total_money?.ToString("#,##0") ?? "0") + "đ";

                        // Trạng thái
                        cboStatus.Text = TranslateStatus(order.status);
                    }

                    // 2. Lấy danh sách sản phẩm
                    var items = db.order_details
                        .Where(od => od.order_id == _orderId)
                        .Select(od => new {
                            ProductName = od.product.name,
                            Image = od.product.image,
                            Qty = od.quantity,
                            Price = od.unit_price
                        }).ToList();

                    dgvItems.Rows.Clear();
                    foreach (var item in items)
                    {
                        // Xử lý ảnh
                        Image img = SystemIcons.Shield.ToBitmap(); // Ảnh mặc định
                        if (!string.IsNullOrEmpty(item.Image) && File.Exists(item.Image))
                        {
                            img = Image.FromFile(item.Image);
                        }

                        decimal totalRow = item.Qty * item.Price;

                        dgvItems.Rows.Add(
                            img,
                            item.ProductName,
                            item.Qty,
                            item.Price.ToString("#,##0") + "đ",
                            totalRow.ToString("#,##0") + "đ"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private string TranslateStatus(string statusEn)
        {
            switch (statusEn)
            {
                case "Pending": return "Chờ xử lý";
                case "Processing": return "Đang giao";
                case "Completed": return "Hoàn thành";
                case "Canceled": return "Đã hủy";
                default: return "Chờ xử lý";
            }
        }

        private string TranslateStatusToEn(string statusVi)
        {
            switch (statusVi)
            {
                case "Chờ xử lý": return "Pending";
                case "Đang giao": return "Processing";
                case "Hoàn thành": return "Completed";
                case "Đã hủy": return "Canceled";
                default: return "Pending";
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var order = db.orders.Find(_orderId);
                    if (order != null)
                    {
                        order.status = TranslateStatusToEn(cboStatus.Text);
                        db.SaveChanges();
                        MessageBox.Show("Đã cập nhật trạng thái đơn hàng!", "Thành công");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }
    }
}