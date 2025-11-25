using System;
using System.Data;
using System.Drawing;
using System.IO; // Cần thư viện này để ghi file
using System.Linq;
using System.Text; // Cần thư viện này cho Encoding
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCOrder : UserControl
    {
        // API Placeholder (nếu cần)
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        public UCOrder()
        {
            InitializeComponent();
            UIHelper.StyleDataGridView(dgvOrder);

            // Placeholder
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Tìm tên khách, mã đơn...");

            LoadOrderData();
            this.txtSearch.TextChanged += (s, e) => LoadOrderData(txtSearch.Text.Trim());
        }

        private void LoadOrderData(string keyword = "")
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var query = db.orders.AsQueryable();

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(o =>
                            o.user.full_name.Contains(keyword) ||
                            o.id.ToString().Contains(keyword)
                        );
                    }

                    var listOrders = query
                        .OrderByDescending(o => o.created_at)
                        .Select(o => new {
                            o.id,
                            CustomerName = o.user != null ? o.user.full_name : "Khách vãng lai",
                            Total = o.total_money,
                            o.status,
                            Time = o.created_at
                        })
                        .ToList();

                    dgvOrder.Rows.Clear();

                    foreach (var item in listOrders)
                    {
                        string orderCode = $"#ORD{item.id:D3}";
                        string money = item.Total.HasValue ? item.Total.Value.ToString("#,##0") + "đ" : "0đ";
                        string date = item.Time.HasValue ? item.Time.Value.ToString("dd/MM/yyyy HH:mm") : "";
                        string statusVi = TranslateStatus(item.status);

                        dgvOrder.Rows.Add(orderCode, item.CustomerName, money, statusVi, date, "Xem");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách: " + ex.Message); }
        }

        private string TranslateStatus(string statusEn)
        {
            switch (statusEn)
            {
                case "Pending": return "Chờ duyệt";
                case "Processing": return "Đang giao";
                case "Completed": return "Hoàn thành";
                case "Canceled": return "Đã hủy";
                default: return statusEn;
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.Columns[e.ColumnIndex].Name == "btnView" && e.RowIndex >= 0)
            {
                string orderCode = dgvOrder.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                string rawId = orderCode.Replace("#ORD", "");

                FormOrderDetail frm = new FormOrderDetail(int.Parse(rawId));
                frm.ShowDialog();
                LoadOrderData();
            }
        }

        // --- LOGIC XUẤT EXCEL (CSV) ---
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.csv";
            sfd.FileName = "DanhSachDonHang_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // 1. Ghi tiêu đề cột
                    string[] columnNames = { "Mã Đơn", "Khách Hàng", "Tổng Tiền", "Trạng Thái", "Ngày Đặt" };
                    sb.AppendLine(string.Join(",", columnNames));

                    // 2. Ghi dữ liệu dòng
                    foreach (DataGridViewRow row in dgvOrder.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] fields = {
                                row.Cells["colID"].Value.ToString(),
                                "\"" + row.Cells["colCus"].Value.ToString() + "\"", // Bọc ngoặc kép để tránh lỗi nếu tên có dấu phẩy
                                row.Cells["colTotal"].Value.ToString().Replace("đ", "").Replace(".", ""), // Xóa chữ đ và dấu chấm để Excel hiểu là số
                                row.Cells["colStatus"].Value.ToString(),
                                row.Cells["colDate"].Value.ToString()
                            };
                            sb.AppendLine(string.Join(",", fields));
                        }
                    }

                    // 3. Lưu file với định dạng UTF8 (để hiển thị tiếng Việt không lỗi)
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show("Xuất file thành công!\nĐường dẫn: " + sfd.FileName, "Thông báo");

                    // Mở file lên luôn cho ngầu
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message);
                }
            }
        }
    }
}