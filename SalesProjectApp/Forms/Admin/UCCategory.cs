using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCCategory : UserControl
    {
        private int _selectedId = 0; // Lưu ID của dòng đang được bấm nút "..."

        public UCCategory()
        {
            InitializeComponent();
            UIHelper.StyleDataGridView(dgvCategory);
            // Gán sự kiện cho Menu (Vì trong Designer khó gán trực tiếp hàm logic)
            tsmiEdit.Click += TsmiEdit_Click;
            tsmiDelete.Click += TsmiDelete_Click;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var list = db.categories.ToList();
                    dgvCategory.Rows.Clear();
                    foreach (var item in list)
                    {
                        // Chỉ thêm 1 nút "..." (Action)
                        int idx = dgvCategory.Rows.Add(item.id, item.name, item.code, "...");
                        dgvCategory.Rows[idx].Tag = item.id; // Giấu ID vào Tag
                    }
                    GlobalEvents.RaiseCategoryUpdated();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCategoryEdit frm = new FormCategoryEdit(0);
            frm.ShowDialog();
            LoadData();
        }

        // --- SỰ KIỆN BẤM VÀO NÚT "..." ---
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra click vào cột Action (colAction)
            if (e.RowIndex >= 0 && dgvCategory.Columns[e.ColumnIndex].Name == "colAction")
            {
                // 1. Lưu ID của dòng đó lại để tí nữa Menu dùng
                _selectedId = (int)dgvCategory.Rows[e.RowIndex].Tag;

                // 2. Tính toán vị trí để hiện Menu ngay dưới nút bấm
                Rectangle cellRect = dgvCategory.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point location = dgvCategory.PointToScreen(new Point(cellRect.Left, cellRect.Bottom));

                // 3. Hiện Menu
                cmsAction.Show(location);
            }
        }

        // --- XỬ LÝ KHI CHỌN MENU "SỬA" ---
        private void TsmiEdit_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                FormCategoryEdit frm = new FormCategoryEdit(_selectedId);
                frm.ShowDialog();
                LoadData();
            }
        }

        // --- XỬ LÝ KHI CHỌN MENU "XÓA" ---
        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa danh mục này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    DeleteCategory(_selectedId);
                }
            }
        }

        private void DeleteCategory(int id)
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    bool isUsed = db.products.Any(p => p.category_id == id && p.is_active == true);
                    if (isUsed)
                    {
                        MessageBox.Show("Danh mục đang được sử dụng, không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var cat = db.categories.Find(id);
                    if (cat != null)
                    {
                        db.categories.Remove(cat);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
        }
    }
}