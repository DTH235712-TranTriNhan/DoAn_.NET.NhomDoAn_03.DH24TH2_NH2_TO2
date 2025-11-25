using System.Drawing;
using System.Windows.Forms;

namespace SalesProjectApp.Models
{
    public static class UIHelper
    {
        public static void StyleDataGridView(DataGridView dgv)
        {
            // 1. Cấu hình chung
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false; // Bắt buộc để custom màu header

            // 2. Cấu hình Header (Tiêu đề cột)
            var headerStyle = dgv.ColumnHeadersDefaultCellStyle;

            headerStyle.BackColor = Color.FromArgb(33, 37, 41); // Màu nền đen xám
            headerStyle.ForeColor = Color.White; // Chữ trắng
            headerStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // --- KHẮC PHỤC LỖI CLICK BỊ TRẮNG Ở ĐÂY ---
            // Ép màu khi click (Selection) giống hệt màu bình thường
            headerStyle.SelectionBackColor = Color.FromArgb(33, 37, 41);
            headerStyle.SelectionForeColor = Color.White;
            // -------------------------------------------

            dgv.ColumnHeadersHeight = 45;

            // 3. Cấu hình Dòng dữ liệu (Rows)
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 30, 99); // Màu hồng khi chọn dòng
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowTemplate.Height = 45;

            // Màu xen kẽ
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Ẩn cột tiêu đề dòng bên trái
            dgv.RowHeadersVisible = false;
        }
    }
}