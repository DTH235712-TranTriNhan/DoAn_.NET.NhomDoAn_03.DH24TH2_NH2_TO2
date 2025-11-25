using System;
using System.Drawing;
using System.Runtime.InteropServices; // Thư viện bo tròn
using System.Windows.Forms;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCOverview : UserControl
    {
        // --- 1. API BO TRÒN GÓC ---
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        public UCOverview()
        {
            InitializeComponent();

            // Cấu hình UserControl
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;

            // Nạp dữ liệu giả lập
            LoadDashboardData();

            // Bo tròn các thẻ khi Form tải xong
            this.Load += (s, e) => RoundCorners();
        }

        private void LoadDashboardData()
        {
            // 1. Điền số liệu vào 4 thẻ
            lblC1Val.Text = "15.200.000đ"; // Doanh thu
            lblC2Val.Text = "5";           // Đơn chờ
            lblC3Val.Text = "42";          // Sản phẩm
            lblC4Val.Text = "128";         // Khách hàng

            // 2. Điền dữ liệu vào bảng đơn hàng
            // (Xóa dữ liệu cũ nếu có)
            dgvRecent.Rows.Clear();

            dgvRecent.Rows.Add("#ORD001", "Nguyễn Văn A", "150.000đ", "Hoàn thành", "10:30");
            dgvRecent.Rows.Add("#ORD002", "Trần Thị B", "320.000đ", "Chờ duyệt", "11:15");
            dgvRecent.Rows.Add("#ORD003", "Lê Văn C", "85.000đ", "Đang giao", "12:00");
            dgvRecent.Rows.Add("#ORD004", "Phạm Văn D", "500.000đ", "Hoàn thành", "12:45");
            dgvRecent.Rows.Add("#ORD005", "Hoàng Thị E", "1.200.000đ", "Hủy", "13:10");
        }

        private void RoundCorners()
        {
            // Bo tròn 4 thẻ Card (Độ cong 20)
            int r = 20;
            try
            {
                pnlCard1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard1.Width, pnlCard1.Height, r, r));
                pnlCard2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard2.Width, pnlCard2.Height, r, r));
                pnlCard3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard3.Width, pnlCard3.Height, r, r));
                pnlCard4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard4.Width, pnlCard4.Height, r, r));
            }
            catch { }
        }
    }
}