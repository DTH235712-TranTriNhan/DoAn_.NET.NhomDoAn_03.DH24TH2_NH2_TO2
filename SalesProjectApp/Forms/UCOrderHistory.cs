using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms
{
    public partial class UCOrderHistory : UserControl
    {
        public UCOrderHistory()
        {
            InitializeComponent();
            UIHelper.StyleDataGridView(dgvHistory); // Làm đẹp bảng
            LoadHistory();
        }

        public void LoadHistory()
        {
            if (Session.CurrentUser == null) return;

            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    // Chỉ lấy đơn của User đang đăng nhập
                    var list = db.orders
                        .Where(o => o.user_id == Session.CurrentUser.id)
                        .OrderByDescending(o => o.created_at)
                        .Select(o => new {
                            o.id,
                            o.created_at,
                            o.total_money,
                            o.status
                        }).ToList();

                    dgvHistory.Rows.Clear();
                    foreach (var item in list)
                    {
                        string statusVi = "Chờ xử lý";
                        if (item.status == "Processing") statusVi = "Đang làm món";
                        if (item.status == "Completed") statusVi = "Hoàn thành";
                        if (item.status == "Canceled") statusVi = "Đã bị hủy";

                        dgvHistory.Rows.Add($"#ORD{item.id:D3}", item.created_at.Value.ToString("dd/MM HH:mm"), item.total_money.Value.ToString("#,##0") + "đ", statusVi);
                    }
                }
            }
            catch { }
        }
    }
}