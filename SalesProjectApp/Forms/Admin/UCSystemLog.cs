using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCSystemLog : UserControl
    {
        // --- KHAI BÁO API ĐỂ TẠO PLACEHOLDER ---
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        // ---------------------------------------

        // Biến kiểm tra để đảm bảo cấu hình cột chỉ chạy một lần hoặc khi cần thiết
        private bool isColumnConfigured = false;

        public UCSystemLog()
        {
            InitializeComponent();
            UIHelper.StyleDataGridView(dgvLogs);

            // 1. Tạo Placeholder xịn
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Tìm Mã người dùng, Tên, hoặc Mô tả...");

            // 2. Gắn sự kiện tìm kiếm và làm mới
            this.txtSearch.TextChanged += (s, e) => LoadLogs(txtSearch.Text.Trim());
            this.btnSearch.Click += (s, e) => LoadLogs(txtSearch.Text.Trim());

            // 3. Gắn sự kiện Load cho UserControl
            this.Load += new EventHandler(this.UCSystemLog_Load);

            // *** 4. FIX LỖI: Gán sự kiện xử lý sau khi dữ liệu đã được gán hoàn tất ***
            this.dgvLogs.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.DgvLogs_DataBindingComplete);
        }

        // --- HÀM XỬ LÝ SỰ KIỆN LOAD ---
        private void UCSystemLog_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void LoadLogs(string searchTerm = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    searchTerm = null;
                }

                // Đặt lại cờ cấu hình khi tải dữ liệu mới (để xử lý tìm kiếm)
                isColumnConfigured = false;

                using (var db = new SalesProjectNetDBEntities())
                {
                    var query = db.system_logs.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        searchTerm = searchTerm.ToLower();

                        // --- ƯU TIÊN LỌC THEO MÃ NGƯỜI DÙNG (USER ID) ---
                        if (int.TryParse(searchTerm, out int userId))
                        {
                            query = query.Where(x => x.user_id == userId);
                        }
                        else
                        {
                            // Lọc theo Tên đầy đủ, Mô tả, hoặc Loại hành động
                            query = query.Where(x =>
                                (x.user.full_name != null && x.user.full_name.ToLower().Contains(searchTerm)) ||
                                (x.description != null && x.description.ToLower().Contains(searchTerm)) ||
                                (x.action_type != null && x.action_type.ToLower().Contains(searchTerm))
                            );
                        }
                    }

                    var logs = query
                        .OrderByDescending(x => x.created_at)
                        .Take(100)
                        .Select(x => new
                        {
                            ID = x.id,
                            UserID = x.user_id.HasValue ? x.user_id.Value.ToString() : "SYS",
                            User = x.user != null ? x.user.full_name : "Hệ thống",
                            Action = x.action_type,
                            Desc = x.description,
                            Time = x.created_at
                        }).ToList();

                    // CHỈ GÁN DỮ LIỆU. Việc cấu hình cột sẽ được xử lý trong sự kiện DataBindingComplete
                    dgvLogs.DataSource = logs;

                    // Nếu có dữ liệu, buộc DataBindingComplete chạy ngay lập tức
                    if (logs.Any())
                    {
                        dgvLogs.PerformLayout();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải Log: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- HÀM FIX LỖI KÍCH THƯỚC CỘT ---
        private void DgvLogs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Cờ kiểm tra để đảm bảo cấu hình cột chỉ chạy một lần sau mỗi lần LoadLogs
            if (isColumnConfigured || dgvLogs.Columns.Count == 0) return;

            try
            {
                // 1. Tắt chế độ AutoSizeColumnsMode tổng thể (nếu nó vẫn là Fill trong Designer)
                dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                // 2. Thiết lập HeaderText và chiều rộng cố định/Autosize riêng cho từng cột
                dgvLogs.Columns["ID"].HeaderText = "ID";
                dgvLogs.Columns["ID"].Width = 50;
                dgvLogs.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvLogs.Columns["UserID"].HeaderText = "MÃ KH";
                dgvLogs.Columns["UserID"].Width = 60;
                dgvLogs.Columns["UserID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Các cột có tiêu đề dài, buộc phải hiển thị đủ tiêu đề (AllCells hoặc AllCellsExceptHeader)
                dgvLogs.Columns["User"].HeaderText = "NGƯỜI THỰC HIỆN";
                dgvLogs.Columns["User"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvLogs.Columns["Action"].HeaderText = "LOẠI HÀNH ĐỘNG";
                dgvLogs.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvLogs.Columns["Time"].HeaderText = "THỜI GIAN";
                dgvLogs.Columns["Time"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                dgvLogs.Columns["Time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Cột CHI TIẾT sẽ chiếm phần không gian còn lại (Fill)
                dgvLogs.Columns["Desc"].HeaderText = "CHI TIẾT";
                dgvLogs.Columns["Desc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // 3. BUỘC TÍNH TOÁN LẠI KÍCH THƯỚC:
                // Gọi AutoResizeColumns sau khi đã đặt chế độ AutoSize cho từng cột.
                // Điều này kích hoạt việc tính toán AllCells ngay lập tức.
                dgvLogs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Kích hoạt lại Fill cho cột Desc sau khi đã tính toán xong
                dgvLogs.Columns["Desc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                isColumnConfigured = true;
            }
            catch (Exception ex)
            {
                // Có thể xuất hiện lỗi nếu cột không tồn tại, bạn có thể bỏ qua hoặc ghi log lỗi.
                // MessageBox.Show("Lỗi cấu hình cột: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Xóa nội dung tìm kiếm và tải lại
            txtSearch.Text = "";
            LoadLogs();
        }
    }
}