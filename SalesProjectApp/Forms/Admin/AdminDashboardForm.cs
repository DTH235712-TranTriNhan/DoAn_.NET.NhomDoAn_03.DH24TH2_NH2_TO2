using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProjectApp.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            ApplyRoundedCorners();

            // --- SỬA LẠI TÊN ĐÚNG Ở ĐÂY ---
            ShowUserControl(new UCOverview());
        }

        private void ShowUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
            uc.BringToFront();
        }

        // --- SỰ KIỆN NÚT BẤM ---

        private void btnUCOverview_Click(object sender, EventArgs e)
        {
            // --- SỬA LẠI TÊN ĐÚNG Ở ĐÂY ---
            ShowUserControl(new UCOverview());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCProduct());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCOrder());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCCustomer());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- HÀM BO TRÒN ---
        private void ApplyRoundedCorners()
        {
            // HelperBoTron(pnlSidebar, 20); 
        }

        //private void HelperBoTron(Control c, int radius)
        //{
        //    c.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, radius, radius));
        //}

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ApplyRoundedCorners();
        }
    }
}
