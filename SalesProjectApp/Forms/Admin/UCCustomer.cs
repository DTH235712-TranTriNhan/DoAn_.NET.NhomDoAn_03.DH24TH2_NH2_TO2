using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Thư viện cho Placeholder
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCCustomer : UserControl
    {
        // API Placeholder
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        public UCCustomer()
        {
            InitializeComponent();

            // 1. Làm đẹp bảng
            UIHelper.StyleDataGridView(dgvCustomer);

            // 2. Placeholder tìm kiếm
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Tìm tên, SĐT, email...");

            LoadCustomerData();

            // Gắn sự kiện tìm kiếm
            this.txtSearch.TextChanged += (s, e) => LoadCustomerData(txtSearch.Text.Trim());
        }

        private void LoadCustomerData(string keyword = "")
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var query = db.users.Where(u => u.role == "user");

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(u =>
                            u.full_name.Contains(keyword) ||
                            u.phone_number.Contains(keyword) ||
                            u.email.Contains(keyword)
                        );
                    }

                    var listCustomers = query
                        .OrderByDescending(u => u.created_at)
                        .Select(u => new
                        {
                            u.id,
                            u.full_name,
                            u.phone_number,
                            u.email,
                            Address = "---" // Tạm thời
                        })
                        .ToList();

                    dgvCustomer.Rows.Clear();
                    foreach (var item in listCustomers)
                    {
                        string codeDisplay = $"KH{item.id:D3}";
                        string name = item.full_name ?? "Chưa cập nhật";
                        string phone = item.phone_number ?? "---";
                        string email = item.email ?? "---";

                        dgvCustomer.Rows.Add(codeDisplay, name, phone, email, item.Address, "Sửa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                string displayCode = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                int realCustomerId = int.Parse(displayCode.Replace("KH", ""));

                FormCustomerEdit frm = new FormCustomerEdit(realCustomerId);
                frm.ShowDialog();
                LoadCustomerData();
            }
        }
    }
}