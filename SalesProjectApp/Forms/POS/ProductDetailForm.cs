using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesProjectApp.Forms
{
    public partial class ProductDetailForm : Form
    {
        public int SelectedQty { get; private set; } = 1;
        private decimal _price;

        // Constructor nhận đầy đủ thông tin: Tên, Giá, Ảnh, Mô tả
        public ProductDetailForm(string name, decimal price, Image img, string description)
        {
            InitializeComponent();

            // 1. Gán dữ liệu vào giao diện
            lblName.Text = name;
            lblPrice.Text = price.ToString("N0") + "đ";
            pbImg.Image = img;
            lblDesc.Text = description; // <--- Hiển thị mô tả ở đây

            _price = price;
            UpdateTotal();

            // 2. Các sự kiện nút bấm
            btnPlus.Click += (s, e) => { SelectedQty++; UpdateTotal(); };
            btnMinus.Click += (s, e) => { if (SelectedQty > 1) SelectedQty--; UpdateTotal(); };

            btnAdd.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.OK; // Bấm thêm thì trả về OK
                this.Close();
            };
        }

        private void UpdateTotal()
        {
            txtQty.Text = SelectedQty.ToString();
            decimal total = SelectedQty * _price;
            lblTotal.Text = "Thành tiền: " + total.ToString("N0") + "đ";
            btnAdd.Text = $"Thêm vào giỏ - {total:N0}đ";
        }
    }
}