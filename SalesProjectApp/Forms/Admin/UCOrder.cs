using System;
using System.Windows.Forms;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCOrder : UserControl
    {
        public UCOrder()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            dgvOrder.Rows.Add("#ORD001", "Nguyễn Văn A", "150.000đ", "Hoàn thành", "24/11/2025");
            dgvOrder.Rows.Add("#ORD002", "Trần Thị B", "320.000đ", "Chờ duyệt", "24/11/2025");
            dgvOrder.Rows.Add("#ORD003", "Lê Văn C", "85.000đ", "Đang giao", "23/11/2025");
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}