using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SalesProjectApp.Forms.Auth;
using SalesProjectApp.Models; // Thêm using cho LogHelper

namespace SalesProjectApp.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        private UCOverview _ucOverview;
        private UCProduct _ucProduct;
        private UCOrder _ucOrder;
        private UCCustomer _ucCustomer;
        private UCCategory _ucCategory;
        private UCSystemLog _ucSystemLog; // Thêm biến cho UC SystemLog

        public AdminDashboardForm()
        {
            InitializeComponent();
            btnUCOverview_Click(btnOverview, EventArgs.Empty);

            // Ghi Log khi ADMIN mở Dashboard
            LogHelper.Write("LOGIN_SUCCESS", $"Admin '{Session.CurrentUser?.username}' đã đăng nhập hệ thống.");
        }

        private void LoadUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void MoveIndicator(IconButton activeBtn)
        {
            foreach (Control c in pnlSidebar.Controls)
            {
                // Reset màu
                if (c is IconButton btn && btn.Name != "btnLogout" && btn.Name != "btnWebsite")
                {
                    btn.BackColor = Color.FromArgb(33, 37, 41);
                    btn.ForeColor = Color.Silver;
                    btn.IconColor = Color.Silver; // Reset màu Icon
                }
            }

            // Highlight
            if (activeBtn != null)
            {
                activeBtn.BackColor = Color.FromArgb(45, 50, 55);
                activeBtn.ForeColor = Color.FromArgb(233, 30, 99);
                activeBtn.IconColor = Color.FromArgb(233, 30, 99); // Icon chuyển hồng
            }
        }

        // --- CÁC HÀM CLICK ---

        private void btnUCOverview_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            if (_ucOverview == null) _ucOverview = new UCOverview();
            LoadUserControl(_ucOverview);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            if (_ucProduct == null) _ucProduct = new UCProduct();
            LoadUserControl(_ucProduct);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            if (_ucCategory == null) _ucCategory = new UCCategory();
            LoadUserControl(_ucCategory);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            if (_ucOrder == null) _ucOrder = new UCOrder();
            LoadUserControl(_ucOrder);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            if (_ucCustomer == null) _ucCustomer = new UCCustomer();
            LoadUserControl(_ucCustomer);
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            // Ghi Log khi Admin chuyển sang chế độ POS/Website
            LogHelper.Write("SWITCH_MODE", "Admin chuyển sang chế độ bán hàng (POS/Website).");

            SalesProjectApp.Forms.PosForm frmPos = new SalesProjectApp.Forms.PosForm();

            this.Hide();
            frmPos.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Ghi Log trước khi Đăng xuất
                LogHelper.Write("LOGOUT", $"Admin '{Session.CurrentUser?.username}' đã đăng xuất khỏi hệ thống.");

                this.Hide();
                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Close();
            }
        }

        // --- HÀM CLICK MỚI CHO LOG HỆ THỐNG ---
        private void btnLog_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            // Ghi Log khi Admin xem Log hệ thống
            LogHelper.Write("VIEW_LOGS", "Admin truy cập xem Log Hệ thống.");

            if (_ucSystemLog == null) _ucSystemLog = new UCSystemLog();
            LoadUserControl(_ucSystemLog);
        }
    }
}