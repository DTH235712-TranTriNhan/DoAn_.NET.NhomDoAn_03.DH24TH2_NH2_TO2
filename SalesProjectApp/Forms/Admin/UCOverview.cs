using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // QUAN TRỌNG: Để vẽ biểu đồ
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCOverview : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        private Timer dashboardTimer;

        public UCOverview()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;

            // Config Label tiền không bị che
            lblC1Val.AutoSize = true; lblC1Val.BringToFront();
            lblC2Val.AutoSize = true; lblC2Val.BringToFront();
            lblC3Val.AutoSize = true; lblC3Val.BringToFront();
            lblC4Val.AutoSize = true; lblC4Val.BringToFront();

            lblDate.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy");

            // Tải dữ liệu lần đầu
            LoadDashboardData();

            // --- FIX LỖI BO TRÒN KHI PHÓNG TO ---
            this.Load += (s, e) => RoundCorners();
            this.Resize += (s, e) => RoundCorners(); // Cập nhật lại góc bo khi form thay đổi kích thước
            // ------------------------------------

            InitDashboardTimer();
        }

        private void InitDashboardTimer()
        {
            dashboardTimer = new Timer();
            dashboardTimer.Interval = 30000; // 30s refresh 1 lần
            dashboardTimer.Tick += (s, e) => {
                lblDate.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy");
                LoadDashboardData();
            };
            dashboardTimer.Start();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dashboardTimer != null) { dashboardTimer.Stop(); dashboardTimer.Dispose(); }
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
                    // 1. SỐ LIỆU TỔNG QUAN
                    decimal revenue = db.orders.Where(o => o.status == "Completed").Sum(o => (decimal?)o.total_money) ?? 0;
                    int pendingOrders = db.orders.Count(o => o.status == "Pending");
                    int totalProducts = db.products.Count(p => p.is_active == true);
                    int totalCustomers = db.users.Count(u => u.role == "user");

                    lblC1Val.Text = revenue.ToString("#,##0") + "đ";
                    lblC2Val.Text = pendingOrders.ToString();
                    lblC3Val.Text = totalProducts.ToString();
                    lblC4Val.Text = totalCustomers.ToString();

                    // 2. VẼ BIỂU ĐỒ (ĐÃ THÊM VÀO)
                    LoadChartData(db);

                    // 3. BẢNG ĐƠN HÀNG MỚI NHẤT
                    dgvRecent.Rows.Clear();
                    var recentOrders = db.orders
                        .OrderByDescending(o => o.created_at)
                        .Take(5)
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
                // --- FIX LỖI SPAM MESSAGEBOX ---
                // Không hiện MessageBox ở đây vì Timer chạy liên tục. 
                // Chỉ ghi log ra Console hoặc bỏ qua để app không bị treo.
                Console.WriteLine("Lỗi Dashboard: " + ex.Message);
            }
        }

        // --- HÀM VẼ BIỂU ĐỒ (MỚI THÊM) ---
        private void LoadChartData(SalesProjectNetDBEntities db)
        {
            // Kiểm tra chartRevenue có null không (đề phòng lỗi Designer chưa load kịp)
            if (chartRevenue == null) return;

            chartRevenue.Series["Doanh Thu"].Points.Clear();

            DateTime sevenDaysAgo = DateTime.Today.AddDays(-6);

            // Lấy dữ liệu thô
            var rawData = db.orders
                .Where(o => o.status == "Completed" && o.created_at >= sevenDaysAgo)
                .Select(o => new { o.created_at, o.total_money })
                .ToList();

            // Group theo ngày
            var chartData = rawData
                .GroupBy(o => o.created_at.Value.Date)
                .Select(g => new { Date = g.Key, Sum = g.Sum(x => x.total_money) })
                .ToList();

            // Đổ dữ liệu 7 ngày
            for (int i = 0; i < 7; i++)
            {
                DateTime d = sevenDaysAgo.AddDays(i);
                var dayData = chartData.FirstOrDefault(x => x.Date == d);
                decimal total = dayData != null ? (decimal)dayData.Sum : 0;

                DataPoint p = new DataPoint();
                p.SetValueXY(d.ToString("dd/MM"), total);
                p.ToolTip = total.ToString("#,##0") + "đ";
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