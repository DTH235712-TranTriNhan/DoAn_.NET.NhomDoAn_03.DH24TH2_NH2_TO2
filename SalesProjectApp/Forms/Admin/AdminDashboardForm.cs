using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp; // Thêm using này
using SalesProjectApp.Forms.Auth;

namespace SalesProjectApp.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        private UCOverview _ucOverview;
        private UCProduct _ucProduct;
        private UCOrder _ucOrder;
        private UCCustomer _ucCustomer;
        private UCCategory _ucCategory;

        public AdminDashboardForm()
        {
            InitializeComponent();
            btnUCOverview_Click(btnOverview, EventArgs.Empty);
        }

        private void LoadUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
            uc.BringToFront();
        }

        // --- SỬA LẠI HÀM NÀY ---
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

        // --- CẬP NHẬT CÁC HÀM CLICK ---
        // Ép kiểu về IconButton

        private void btnUCOverview_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            if (_ucOverview == null) _ucOverview = new UCOverview();
            LoadUserControl(_ucOverview);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            _ucProduct = new UCProduct();
            LoadUserControl(_ucProduct);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            _ucCategory = new UCCategory();
            LoadUserControl(_ucCategory);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            _ucOrder = new UCOrder();
            LoadUserControl(_ucOrder);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MoveIndicator((IconButton)sender);
            _ucCustomer = new UCCustomer();
            LoadUserControl(_ucCustomer);
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("https://google.com"); } catch { }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}