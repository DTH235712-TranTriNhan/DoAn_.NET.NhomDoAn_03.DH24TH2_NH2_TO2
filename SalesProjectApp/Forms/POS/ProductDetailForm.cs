using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesProjectApp.Forms
{
    public partial class ProductDetailForm : Form
    {
        public int SelectedQty { get; private set; } = 1;
        public string Note { get; private set; } = "";
        private decimal _price;

        // Hỗ trợ kéo thả form không viền
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ProductDetailForm(string name, decimal price, Image img, string description)
        {
            InitializeComponent();

            // Xử lý kéo thả Header
            pnlHeader.MouseDown += (s, e) => { dragging = true; dragCursorPoint = Cursor.Position; dragFormPoint = this.Location; };
            pnlHeader.MouseMove += (s, e) => { if (dragging) { Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint)); this.Location = Point.Add(dragFormPoint, new Size(dif)); } };
            pnlHeader.MouseUp += (s, e) => { dragging = false; };

            // Gán dữ liệu
            lblName.Text = name;
            lblPrice.Text = price.ToString("N0") + "đ";

            // --- SỬA LỖI TẠI ĐÂY: Đổi pbImg thành picImage ---
            if (img != null) picImage.Image = img;
            // ------------------------------------------------

            lblDesc.Text = string.IsNullOrEmpty(description) ? "Chưa có mô tả chi tiết." : description;

            _price = price;
            UpdateTotal();

            // Sự kiện
            btnPlus.Click += (s, e) => { SelectedQty++; UpdateTotal(); };
            btnMinus.Click += (s, e) => { if (SelectedQty > 1) SelectedQty--; UpdateTotal(); };

            btnAdd.Click += (s, e) =>
            {
                Note = txtNote.Text.Trim(); // Lưu ghi chú
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }

        private void UpdateTotal()
        {
            txtQty.Text = SelectedQty.ToString();
            decimal total = SelectedQty * _price;
            btnAdd.Text = $"Thêm vào giỏ - {total:N0}đ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}