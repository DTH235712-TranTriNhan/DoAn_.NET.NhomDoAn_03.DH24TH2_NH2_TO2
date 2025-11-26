using System;
using System.Windows.Forms;
using System.Xml.Linq;
using SalesProjectApp.Models;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SalesProjectApp.Forms.Admin
{
    public partial class FormCategoryEdit : Form
    {
        private int _categoryId = 0;

        public FormCategoryEdit(int categoryId = 0)
        {
            InitializeComponent();
            _categoryId = categoryId;

            if (_categoryId > 0)
            {
                this.Text = "Cập nhật danh mục";
                lblTitle.Text = "CẬP NHẬT DANH MỤC";
                LoadData();
            }
            else
            {
                this.Text = "Thêm danh mục mới";
                lblTitle.Text = "THÊM DANH MỤC MỚI";
            }
        }

        private void LoadData()
        {
            using (var db = new SalesProjectNetDBEntities())
            {
                var cat = db.categories.Find(_categoryId);
                if (cat != null)
                {
                    txtName.Text = cat.name;
                    txtCode.Text = cat.code;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
                return;
            }

            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    category cat;
                    if (_categoryId == 0)
                    {
                        cat = new category();
                        db.categories.Add(cat);
                    }
                    else
                    {
                        cat = db.categories.Find(_categoryId);
                    }

                    cat.name = txtName.Text.Trim();
                    cat.code = txtCode.Text.Trim().ToUpper(); // Mã nên viết hoa

                    db.SaveChanges();
                    LogHelper.Write("UPDATE CATEGORY", $"Danh mục: {txtName.Text}");
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