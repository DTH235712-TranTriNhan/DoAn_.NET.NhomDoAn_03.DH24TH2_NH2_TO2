using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Thư viện biểu đồ
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCOverview : UserControl
    {
        // API Bo tròn góc
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        private Timer dashboardTimer;

        public UCOverview()
        {
            InitializeComponent();
            UIHelper.StyleDataGridView(dgvRecent);
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;

            // 1. Cấu hình Label tiền để không bị che
            lblC1Val.AutoSize = true;
            lblC2Val.AutoSize = true;
            lblC3Val.AutoSize = true;
            lblC4Val.AutoSize = true;

            // Đưa lên lớp trên cùng
            lblC1Val.BringToFront();
            lblC2Val.BringToFront();
            lblC3Val.BringToFront();
            lblC4Val.BringToFront();

            // 2. Hiển thị ngày
            lblDate.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy");

            // 3. Tải dữ liệu
            LoadDashboardData();

            // 4. Sự kiện vẽ lại góc bo khi thay đổi kích thước
            this.Load += (s, e) => RoundCorners();
            this.Resize += (s, e) => RoundCorners();

            // 5. Kích hoạt Timer cập nhật mỗi 30s
            InitDashboardTimer();
        }

        private void InitDashboardTimer()
        {
            dashboardTimer = new Timer();
            dashboardTimer.Interval = 30000; // 30 giây
            dashboardTimer.Tick += (s, e) => {
                lblDate.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy");
                LoadDashboardData();
            };
            dashboardTimer.Start();
        }

        // Hủy Timer khi đóng để tránh lỗi ngầm
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dashboardTimer != null)
                {
                    dashboardTimer.Stop();
                    dashboardTimer.Dispose();
                }
                if (components != null) components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void LoadDashboardData()
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    // --- PHẦN 1: 4 THẺ CARD ---
                    decimal revenue = db.orders.Where(o => o.status == "Completed").Sum(o => (decimal?)o.total_money) ?? 0;
                    int pendingOrders = db.orders.Count(o => o.status == "Pending");
                    int totalProducts = db.products.Count(p => p.is_active == true);
                    int totalCustomers = db.users.Count(u => u.role == "user");

                    lblC1Val.Text = revenue.ToString("#,##0") + "đ";
                    lblC2Val.Text = pendingOrders.ToString();
                    lblC3Val.Text = totalProducts.ToString();
                    lblC4Val.Text = totalCustomers.ToString();

                    // --- PHẦN 2: BIỂU ĐỒ DOANH THU (7 NGÀY) ---
                    LoadChartData(db);

                    // --- PHẦN 3: BẢNG ĐƠN HÀNG (TIẾNG VIỆT) ---
                    dgvRecent.Rows.Clear();
                    var recentOrders = db.orders
                        .OrderByDescending(o => o.created_at)
                        .Take(5) // Lấy 5 đơn để nhường chỗ cho Chart
                        .Select(o => new
                        {
                            o.id,
                            CustomerName = o.user != null ? o.user.full_name : "Khách vãng lai",
                            Total = o.total_money,
                            o.status,
                            Time = o.created_at
                        }).ToList();

                    foreach (var item in recentOrders)
                    {
                        string timeStr = item.Time.HasValue ? item.Time.Value.ToString("HH:mm dd/MM") : "";
                        string moneyStr = item.Total.HasValue ? item.Total.Value.ToString("#,##0") + "đ" : "0đ";
                        string codeStr = $"#ORD{item.id:D3}";

                        // Dịch trạng thái
                        string statusVi = "Chờ xử lý";
                        if (item.status == "Processing") statusVi = "Đang giao";
                        if (item.status == "Completed") statusVi = "Hoàn thành";
                        if (item.status == "Canceled") statusVi = "Đã hủy";

                        dgvRecent.Rows.Add(codeStr, item.CustomerName, moneyStr, statusVi, timeStr);
                    }
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message); // Log lỗi nếu cần
            }
        }

        private void LoadChartData(SalesProjectNetDBEntities db)
        {
            // Xóa dữ liệu cũ trên biểu đồ
            chartRevenue.Series["Doanh Thu"].Points.Clear();

            // Lấy mốc 7 ngày trước
            DateTime sevenDaysAgo = DateTime.Today.AddDays(-6);

            // Lấy dữ liệu thô về RAM trước khi Group By (để tránh lỗi EF)
            var rawData = db.orders
                .Where(o => o.status == "Completed" && o.created_at >= sevenDaysAgo)
                .Select(o => new { o.created_at, o.total_money })
                .ToList();

            var chartData = rawData
                .GroupBy(o => o.created_at.Value.Date)
                .Select(g => new { Date = g.Key, Sum = g.Sum(x => x.total_money) })
                .ToList();

            // Vòng lặp 7 ngày để ngày nào không bán được cũng hiện số 0
            for (int i = 0; i < 7; i++)
            {
                DateTime d = sevenDaysAgo.AddDays(i);
                var dayData = chartData.FirstOrDefault(x => x.Date == d);
                decimal total = dayData != null ? (decimal)dayData.Sum : 0;

                // Thêm điểm vào biểu đồ
                DataPoint p = new DataPoint();
                p.SetValueXY(d.ToString("dd/MM"), total);
                p.ToolTip = total.ToString("#,##0") + "đ"; // Hover chuột hiện tiền
                chartRevenue.Series["Doanh Thu"].Points.Add(p);
            }
        }

        private void RoundCorners()
        {
            int r = 20;
            try
            {
                if (pnlCard1 != null) pnlCard1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard1.Width, pnlCard1.Height, r, r));
                if (pnlCard2 != null) pnlCard2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard2.Width, pnlCard2.Height, r, r));
                if (pnlCard3 != null) pnlCard3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard3.Width, pnlCard3.Height, r, r));
                if (pnlCard4 != null) pnlCard4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCard4.Width, pnlCard4.Height, r, r));
            }
            catch { }
        }
    }
}