namespace SalesProjectApp.Forms.Admin
{
    partial class AdminDashboardForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            // --- THAY ĐỔI LOẠI NÚT THÀNH ICONBUTTON ---
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnWebsite = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnOverview = new FontAwesome.Sharp.IconButton();
            this.btnLog = new FontAwesome.Sharp.IconButton();
            // ------------------------------------------
            this.lblSubLogo = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnWebsite);
            this.pnlSidebar.Controls.Add(this.btnCustomer);
            this.pnlSidebar.Controls.Add(this.btnLog);
            this.pnlSidebar.Controls.Add(this.btnOrder);
            this.pnlSidebar.Controls.Add(this.btnCategory);
            this.pnlSidebar.Controls.Add(this.btnProduct);
            this.pnlSidebar.Controls.Add(this.btnOverview);
            this.pnlSidebar.Controls.Add(this.lblSubLogo);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 750);
            this.pnlSidebar.TabIndex = 0;

            // --- CẤU HÌNH CHUNG CHO CÁC NÚT MENU ---
            // IconSize: 32, ImageAlign: Left, TextImageRelation: ImageBeforeText (Hình trước chữ)

            // 
            // btnOverview (Tổng quan - Icon ChartPie)
            // 
            this.btnOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOverview.ForeColor = System.Drawing.Color.White; // Mặc định trắng
            this.btnOverview.IconChar = FontAwesome.Sharp.IconChar.ChartPie; // Icon Biểu đồ
            this.btnOverview.IconColor = System.Drawing.Color.White;
            this.btnOverview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOverview.IconSize = 32;
            this.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.Location = new System.Drawing.Point(0, 100); // Đẩy xuống dưới Logo
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0); // Căn lề đẹp
            this.btnOverview.Size = new System.Drawing.Size(250, 60);
            this.btnOverview.TabIndex = 2;
            this.btnOverview.Text = "Tổng Quan";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnUCOverview_Click);

            // 
            // btnProduct (Sản phẩm - Icon Tag)
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProduct.ForeColor = System.Drawing.Color.Silver;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Tags; // Icon Thẻ giá
            this.btnProduct.IconColor = System.Drawing.Color.Silver;
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.IconSize = 32;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 160);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProduct.Size = new System.Drawing.Size(250, 60);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Sản Phẩm";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);

            // 
            // btnCategory (Danh mục - Icon List)
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCategory.ForeColor = System.Drawing.Color.Silver;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.ListUl; // Icon Danh sách
            this.btnCategory.IconColor = System.Drawing.Color.Silver;
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategory.IconSize = 32;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 220);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCategory.Size = new System.Drawing.Size(250, 60);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Danh Mục";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);

            // 
            // btnOrder (Đơn hàng - Icon ShoppingCart)
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOrder.ForeColor = System.Drawing.Color.Silver;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart; // Icon Giỏ hàng
            this.btnOrder.IconColor = System.Drawing.Color.Silver;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 32;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 280);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrder.Size = new System.Drawing.Size(250, 60);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Đơn Hàng";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);

            // 
            // btnCustomer (Khách hàng - Icon Users)
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCustomer.ForeColor = System.Drawing.Color.Silver;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.Users; // Icon Nhóm người
            this.btnCustomer.IconColor = System.Drawing.Color.Silver;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.IconSize = 32;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 340);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCustomer.Size = new System.Drawing.Size(250, 60);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Khách Hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);

            // 
            // btnLog (Log Hệ thống - Icon FileAlt)
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLog.ForeColor = System.Drawing.Color.Silver;
            this.btnLog.IconChar = FontAwesome.Sharp.IconChar.FileAlt; // Icon Log/File
            this.btnLog.IconColor = System.Drawing.Color.Silver;
            this.btnLog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLog.IconSize = 32;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(0, 400); // Đặt sau btnCustomer (340 + 60)
            this.btnLog.Name = "btnLog";
            this.btnLog.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLog.Size = new System.Drawing.Size(250, 60);
            this.btnLog.TabIndex = 7; // Chuyển TabIndex thành 7
            this.btnLog.Text = "Log Hệ thống";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);

            // 
            // btnWebsite (Icon Globe)
            // 
            this.btnWebsite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnWebsite.FlatAppearance.BorderSize = 0;
            this.btnWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebsite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWebsite.ForeColor = System.Drawing.Color.Silver;
            this.btnWebsite.IconChar = FontAwesome.Sharp.IconChar.Globe; // Icon Quả địa cầu
            this.btnWebsite.IconColor = System.Drawing.Color.Silver;
            this.btnWebsite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWebsite.IconSize = 32;
            this.btnWebsite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebsite.Location = new System.Drawing.Point(0, 630);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnWebsite.Size = new System.Drawing.Size(250, 60);
            this.btnWebsite.TabIndex = 7;
            this.btnWebsite.Text = "Xem Website";
            this.btnWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebsite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWebsite.UseVisualStyleBackColor = true;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);

            // 
            // btnLogout (Icon SignOut)
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100); // Màu đỏ nhạt
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt; // Icon Đăng xuất
            this.btnLogout.IconColor = System.Drawing.Color.FromArgb(255, 100, 100);
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 690);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 60);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Logo Labels (Giữ nguyên vị trí nhưng chỉnh Dock để không bị đè)
            this.lblSubLogo.AutoSize = true;
            this.lblSubLogo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubLogo.Location = new System.Drawing.Point(45, 75);
            this.lblSubLogo.Name = "lblSubLogo";
            this.lblSubLogo.Size = new System.Drawing.Size(137, 16);
            this.lblSubLogo.TabIndex = 1;
            this.lblSubLogo.Text = "Pastry Shop Manager";

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.lblLogo.Location = new System.Drawing.Point(40, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(124, 41);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ADMIN";

            // Panel Logo giả (để đẩy các nút xuống dưới 100px)
            System.Windows.Forms.Panel pnlLogoArea = new System.Windows.Forms.Panel();
            pnlLogoArea.Controls.Add(this.lblLogo);
            pnlLogoArea.Controls.Add(this.lblSubLogo);
            pnlLogoArea.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLogoArea.Size = new System.Drawing.Size(250, 100);
            pnlLogoArea.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.pnlSidebar.Controls.Add(pnlLogoArea); // Add panel logo vào sidebar trước các nút

            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(250, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(950, 750);
            this.pnlMain.TabIndex = 1;

            // AdminDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubLogo;

        // Đổi loại biến thành IconButton
        private FontAwesome.Sharp.IconButton btnOverview;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnCategory;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnWebsite;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnLog;
    }
}