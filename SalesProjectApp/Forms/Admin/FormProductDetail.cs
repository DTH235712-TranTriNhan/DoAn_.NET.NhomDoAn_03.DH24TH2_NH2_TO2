using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class FormProductDetail : Form
    {
        private int _productId;

        // Biến để kéo thả form không viền
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormProductDetail(int productId)
        {
            InitializeComponent();
            _productId = productId;

            // Kéo thả form
            pnlHeader.MouseDown += (s, e) => { dragging = true; dragCursorPoint = Cursor.Position; dragFormPoint = this.Location; };
            pnlHeader.MouseMove += (s, e) => { if (dragging) { Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint)); this.Location = Point.Add(dragFormPoint, new Size(dif)); } };
            pnlHeader.MouseUp += (s, e) => { dragging = false; };

            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var p = db.products.Find(_productId);
                    if (p != null)
                    {
                        lblTitle.Text = p.name.ToUpper();
                        lblName.Text = p.name;
                        lblPrice.Text = p.price.ToString("#,##0") + "đ";
                        lblCategory.Text = p.category != null ? p.category.name : "Chưa phân loại";
                        txtDescription.Text = string.IsNullOrEmpty(p.description) ? "Chưa có mô tả." : p.description;

                        // Load ảnh
                        if (!string.IsNullOrEmpty(p.image) && File.Exists(p.image))
                        {
                            picImage.Image = Image.FromFile(p.image);
                        }
                        else
                        {
                            picImage.Image = SystemIcons.Shield.ToBitmap(); // Ảnh mặc định
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}