using FontAwesome.Sharp;

namespace SalesProjectApp.Forms
{
    partial class PosForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();

            // --- KHAI BÁO CÁC NÚT RJBUTTON ---
            this.btnSearch = new SalesProjectApp.Controls.RJButton();
            this.btnLogin = new SalesProjectApp.Controls.RJButton();
            this.btnCart = new SalesProjectApp.Controls.RJButton();
            this.btnExit = new SalesProjectApp.Controls.RJButton();
            // ----------------------------------

            this.pnlRight = new System.Windows.Forms.Panel();

            // Sidebar & Center
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMenu = new SalesProjectApp.Controls.RJButton();
            this.btnHistory = new SalesProjectApp.Controls.RJButton();
            this.btnProfile = new SalesProjectApp.Controls.RJButton();
            this.btnLogout = new SalesProjectApp.Controls.RJButton();

            this.pnlCenter = new System.Windows.Forms.Panel();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.ucOrderHistory = new SalesProjectApp.Forms.UCOrderHistory(); // UserControl Lịch sử
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar = new System.Windows.Forms.Panel();

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);

            // --- KHAI BÁO MENU CONTEXT ---
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            // -----------------------------

            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.cmsUser.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader (Top)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.btnLogin);
            this.pnlHeader.Controls.Add(this.btnCart);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(111, 78, 55);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "POS BÁN HÀNG";

            // txtSearch
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(520, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Visible = false; // Mặc định ẩn

            // btnSearch
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 22;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = FontAwesome.Sharp.IconChar.Search.ToBitmap(System.Drawing.Color.Gray, 20);
            this.btnSearch.Location = new System.Drawing.Point(780, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnLogin
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 22;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Image = FontAwesome.Sharp.IconChar.User.ToBitmap(System.Drawing.Color.Gray, 20);
            this.btnLogin.Location = new System.Drawing.Point(840, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(45, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnCart
            this.btnCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnCart.BackgroundColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnCart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCart.BorderRadius = 22;
            this.btnCart.BorderSize = 0;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Image = FontAwesome.Sharp.IconChar.ShoppingCart.ToBitmap(System.Drawing.Color.White, 20);
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(900, 12);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCart.Size = new System.Drawing.Size(180, 45);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "   Giỏ Hàng (0)";
            this.btnCart.TextColor = System.Drawing.Color.White;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);

            // btnExit
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BorderRadius = 22;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = FontAwesome.Sharp.IconChar.SignOutAlt.ToBitmap(System.Drawing.Color.Gray, 20);
            this.btnExit.Location = new System.Drawing.Point(1140, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // cmsUser (Menu chuột phải)
            // 
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInfo,
            this.tsmiAdmin,
            this.tsmiLogout});
            this.cmsUser.Name = "cmsUser";
            this.cmsUser.Size = new System.Drawing.Size(181, 76);

            this.tsmiInfo.Enabled = false;
            this.tsmiInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmiInfo.Name = "tsmiInfo";
            this.tsmiInfo.Size = new System.Drawing.Size(180, 24);
            this.tsmiInfo.Text = "Xin chào...";

            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(180, 24);
            this.tsmiAdmin.Text = "🔧 Trang Quản Lý";
            this.tsmiAdmin.Click += new System.EventHandler(this.tsmiAdmin_Click);

            this.tsmiLogout.ForeColor = System.Drawing.Color.Red;
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(180, 24);
            this.tsmiLogout.Text = "🚪 Đăng xuất";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);

            // 
            // pnlSidebar (Trái)
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnProfile);
            this.pnlSidebar.Controls.Add(this.btnHistory);
            this.pnlSidebar.Controls.Add(this.btnMenu);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 70);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 630); // Chiều cao còn lại
            this.pnlSidebar.TabIndex = 1;

            // Logo Sidebar
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "MENU";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Nút Sidebar
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnMenu.BackgroundColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.BorderSize = 0;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 80);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(220, 50);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "🍽️ Thực đơn";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);

            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnHistory.BackgroundColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnHistory.BorderRadius = 0;
            this.btnHistory.BorderSize = 0;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHistory.ForeColor = System.Drawing.Color.Silver;
            this.btnHistory.Location = new System.Drawing.Point(0, 130);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(220, 50);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "🕒 Lịch sử đơn";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.TextColor = System.Drawing.Color.Silver;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);

            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnProfile.BackgroundColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnProfile.BorderRadius = 0;
            this.btnProfile.BorderSize = 0;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnProfile.ForeColor = System.Drawing.Color.Silver;
            this.btnProfile.Location = new System.Drawing.Point(0, 180);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(220, 50);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "👤 Cá nhân";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextColor = System.Drawing.Color.Silver;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Location = new System.Drawing.Point(0, 580);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "🚪 Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextColor = System.Drawing.Color.IndianRed;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.tsmiLogout_Click); // Dùng chung hàm Logout

            // 
            // pnlRight (Giỏ hàng)
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(800, 70);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(400, 630);
            this.pnlRight.TabIndex = 2;
            this.pnlRight.Visible = false;

            // 
            // pnlCenter (Nội dung chính)
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCenter.Controls.Add(this.flpMenu);
            this.pnlCenter.Controls.Add(this.ucOrderHistory);
            this.pnlCenter.Controls.Add(this.flpCategory);
            this.pnlCenter.Controls.Add(this.pnlTopBar);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(220, 70);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(580, 630);
            this.pnlCenter.TabIndex = 3;

            // TopBar (Dự phòng)
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 0; // Ẩn đi vì đã có trên Header
            this.pnlTopBar.TabIndex = 0;

            // Category
            this.flpCategory.BackColor = System.Drawing.Color.White;
            this.flpCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCategory.Height = 60;
            this.flpCategory.Padding = new System.Windows.Forms.Padding(10);
            this.flpCategory.WrapContents = false;
            this.flpCategory.AutoScroll = true;

            // Menu
            this.flpMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.AutoScroll = true;
            this.flpMenu.Padding = new System.Windows.Forms.Padding(20);

            // UC History
            this.ucOrderHistory.BackColor = System.Drawing.Color.White;
            this.ucOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderHistory.Location = new System.Drawing.Point(0, 60);
            this.ucOrderHistory.Name = "ucOrderHistory";
            this.ucOrderHistory.Size = new System.Drawing.Size(580, 570);
            this.ucOrderHistory.TabIndex = 5;
            this.ucOrderHistory.Visible = false;

            // 
            // pnlFooter (Bottom)
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlFooter.Controls.Add(this.lblClock);
            this.pnlFooter.Controls.Add(this.lblCopyright);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 700); // Điều chỉnh lại
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1200, 40);
            this.pnlFooter.TabIndex = 4;
            // Đặt Dock Bottom cho Form
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;

            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCopyright.ForeColor = System.Drawing.Color.Gray;
            this.lblCopyright.Location = new System.Drawing.Point(20, 10);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(200, 20);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "© 2025 Sugar Town - POS";

            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.Color.DimGray;
            this.lblClock.Location = new System.Drawing.Point(1000, 10);
            this.lblClock.Name = "lblClock";
            this.lblClock.Text = "00:00:00";

            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // Main Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Name = "PosForm";
            this.Text = "POS Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.cmsUser.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private SalesProjectApp.Controls.RJButton btnSearch;
        private SalesProjectApp.Controls.RJButton btnLogin;
        private SalesProjectApp.Controls.RJButton btnCart;
        private SalesProjectApp.Controls.RJButton btnExit;

        private System.Windows.Forms.Panel pnlRight;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private SalesProjectApp.Controls.RJButton btnMenu;
        private SalesProjectApp.Controls.RJButton btnHistory;
        private SalesProjectApp.Controls.RJButton btnProfile;
        private SalesProjectApp.Controls.RJButton btnLogout;

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private System.Windows.Forms.Panel pnlTopBar;
        private SalesProjectApp.Forms.UCOrderHistory ucOrderHistory;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerClock;

        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
    }
}