using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class FormProductEdit : Form
    {
        private int _productId = 0;
        private string _imagePath = "";

        public FormProductEdit(int productId = 0)
        {
            InitializeComponent();
            _productId = productId;

            LoadCategories();

            if (_productId > 0)
            {
                this.Text = "Cập nhật sản phẩm";
                lblTitle.Text = "CẬP NHẬT SẢN PHẨM";
                LoadDataForEdit();
            }
            else
            {
                this.Text = "Thêm sản phẩm mới";
                lblTitle.Text = "THÊM SẢN PHẨM MỚI";
            }
        }

        private void LoadCategories()
        {
            using (var db = new SalesProjectNetDBEntities())
            {
                var cats = db.categories.Select(c => new { c.id, c.name }).ToList();
                cboCategory.DataSource = cats;
                cboCategory.DisplayMember = "name";
                cboCategory.ValueMember = "id";
            }
        }

        private void LoadDataForEdit()
        {
            using (var db = new SalesProjectNetDBEntities())
            {
                var p = db.products.Find(_productId);
                if (p != null)
                {
                    txtName.Text = p.name;
                    txtPrice.Text = p.price.ToString("0");
                    cboCategory.SelectedValue = p.category_id;

                    // --- NẠP MÔ TẢ ---
                    txtDescription.Text = p.description; // Load dữ liệu mô tả
                    // -----------------

                    _imagePath = p.image;
                    if (!string.IsNullOrEmpty(p.image) && File.Exists(p.image))
                        picImage.Image = Image.FromFile(p.image);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                _imagePath = open.FileName;
                picImage.Image = Image.FromFile(_imagePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập tên và giá!", "Cảnh báo");
                return;
            }

            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    product p;
                    if (_productId == 0)
                    {
                        p = new product();
                        db.products.Add(p);
                    }
                    else
                    {
                        p = db.products.Find(_productId);
                    }

                    p.name = txtName.Text;
                    p.price = decimal.Parse(txtPrice.Text);
                    p.category_id = (int)cboCategory.SelectedValue;

                    // --- LƯU MÔ TẢ ---
                    p.description = txtDescription.Text;
                    // -----------------

                    p.image = _imagePath;
                    p.is_active = true;

                    if (_productId == 0) p.created_at = DateTime.Now;

                    db.SaveChanges();
                    string action = _productId == 0 ? "ADD PRODUCT" : "EDIT PRODUCT";
                    LogHelper.Write(action, $"Đã lưu thông tin món: {txtName.Text}");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}