using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Cần thêm thư viện này cho API Windows
using SalesProjectApp.Models;
using FontAwesome.Sharp;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCProduct : UserControl
    {
        // --- KHAI BÁO API ĐỂ TẠO PLACEHOLDER ---
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        // ---------------------------------------

        private int _selectedId = 0;

        public UCProduct()
        {
            InitializeComponent();
            UIHelper.StyleDataGridView(dgvProduct);

            // 1. Tạo Placeholder xịn cho ô tìm kiếm
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Tìm kiếm món ăn...");

            // 2. Setup sự kiện
            tsmiView.Click += TsmiView_Click;
            tsmiEdit.Click += TsmiEdit_Click;
            tsmiDelete.Click += TsmiDelete_Click;

            this.txtSearch.TextChanged += (s, e) => LoadProductData();
            this.cboFilter.SelectedIndexChanged += (s, e) => LoadProductData();

            LoadCategoriesForFilter();
            LoadProductData();
        }

        private void LoadCategoriesForFilter()
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var cats = db.categories.Select(c => new { c.id, c.name }).ToList();
                    cats.Insert(0, new { id = 0, name = "Tất cả" });

                    cboFilter.DataSource = cats;
                    cboFilter.DisplayMember = "name";
                    cboFilter.ValueMember = "id";
                    cboFilter.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void LoadProductData()
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();
                int filterCatId = 0;
                if (cboFilter.SelectedValue != null && int.TryParse(cboFilter.SelectedValue.ToString(), out int val))
                {
                    filterCatId = val;
                }

                using (var db = new SalesProjectNetDBEntities())
                {
                    var query = db.products.Where(p => p.is_active == true);

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(p => p.name.ToLower().Contains(keyword));
                    }

                    if (filterCatId > 0)
                    {
                        query = query.Where(p => p.category_id == filterCatId);
                    }

                    var listProducts = query.Select(p => new {
                        p.id,
                        p.name,
                        CategoryName = p.category != null ? p.category.name : "Khác",
                        p.price,
                        p.image
                    }).ToList();

                    dgvProduct.Rows.Clear();
                    foreach (var item in listProducts)
                    {
                        Image imgDisplay = (!string.IsNullOrEmpty(item.image) && File.Exists(item.image))
                            ? Image.FromFile(item.image)
                            : SystemIcons.Shield.ToBitmap();

                        string priceStr = item.price.ToString("#,##0") + "đ";

                        int rowIndex = dgvProduct.Rows.Add(imgDisplay, item.name, item.CategoryName, priceStr, "...");
                        dgvProduct.Rows[rowIndex].Tag = item.id;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormProductEdit frm = new FormProductEdit(0);
            frm.ShowDialog();
            LoadProductData();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProduct.Columns[e.ColumnIndex].Name == "colAction")
            {
                _selectedId = (int)dgvProduct.Rows[e.RowIndex].Tag;
                Rectangle cellRect = dgvProduct.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point location = dgvProduct.PointToScreen(new Point(cellRect.Left, cellRect.Bottom));
                cmsAction.Show(location);
            }
        }

        // --- SỰ KIỆN XEM CHI TIẾT ---
        private void TsmiView_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                // Mở form chi tiết (Read-only)
                FormProductDetail frm = new FormProductDetail(_selectedId);
                frm.ShowDialog();
                // Không cần LoadProductData() vì xem chi tiết không thay đổi gì
            }
        }

        private void TsmiEdit_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                FormProductEdit frm = new FormProductEdit(_selectedId);
                frm.ShowDialog();
                LoadProductData();
            }
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                string productName = "";
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    if ((int)row.Tag == _selectedId)
                    {
                        productName = row.Cells["colName"].Value.ToString();
                        break;
                    }
                }

                DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: '{productName}'?\n(Sản phẩm sẽ bị ẩn)",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes) DeleteProduct(_selectedId);
            }
        }

        private void DeleteProduct(int id)
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var p = db.products.Find(id);
                    if (p != null)
                    {
                        p.is_active = false;
                        db.SaveChanges();
                        MessageBox.Show("Đã xóa thành công!", "Thông báo");
                        LoadProductData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khi xóa: " + ex.Message); }
        }
    }
}