using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesProjectApp.Forms
{
    public partial class ProductDetailForm : Form
    {
        public int SelectedQty { get; private set; } = 1;
        private decimal _price;

        public ProductDetailForm(string name, decimal price, Image img, string description)
        {
            InitializeComponent();

            // Gán dữ liệu
            lblName.Text = name;
            lblPrice.Text = price.ToString("N0") + "đ";
            pbImg.Image = img;

            // Dòng này gán mô tả (đã xóa dấu comment //)
            if (string.IsNullOrEmpty(description))
            {
                lblDesc.Text = "Chưa có mô tả cho sản phẩm này.";
            }
            else
            {
                lblDesc.Text = description;
            }

            _price = price;
            UpdateTotal();

            // Sự kiện nút bấm
            btnPlus.Click += (s, e) => { SelectedQty++; UpdateTotal(); };
            btnMinus.Click += (s, e) => { if (SelectedQty > 1) SelectedQty--; UpdateTotal(); };

            btnAdd.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.OK;
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