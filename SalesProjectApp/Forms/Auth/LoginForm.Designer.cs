namespace SalesProjectApp.Forms.Auth
{
    partial class LoginForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSlogan2 = new System.Windows.Forms.Label();
            this.lblSlogan1 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();

            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();

            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlLine1 = new System.Windows.Forms.Panel(); // Gạch chân
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlLine2 = new System.Windows.Forms.Panel(); // Gạch chân

            this.btnLogin = new SalesProjectApp.Controls.RJButton();
            this.btnGoToRegister = new System.Windows.Forms.Label(); // Dạng link

            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // 
            // 1. PANEL TRÁI (Banner Giới thiệu)
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(233, 30, 99); // Màu hồng chủ đạo
            // Bạn có thể thay dòng trên bằng: this.pnlLeft.BackgroundImage = Image.FromFile("đường_dẫn_ảnh.jpg");
            this.pnlLeft.Controls.Add(this.lblSlogan2);
            this.pnlLeft.Controls.Add(this.lblSlogan1);
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Size = new System.Drawing.Size(350, 500);
            this.pnlLeft.TabIndex = 0;

            // Brand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(30, 50);
            this.lblBrand.Text = "SUGAR TOWN";

            // Slogan 1
            this.lblSlogan1.AutoSize = true;
            this.lblSlogan1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSlogan1.ForeColor = System.Drawing.Color.White;
            this.lblSlogan1.Location = new System.Drawing.Point(30, 180);
            this.lblSlogan1.Text = "Vị Ngọt Yêu Thương";

            // Slogan 2
            this.lblSlogan2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSlogan2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlogan2.Location = new System.Drawing.Point(35, 230);
            this.lblSlogan2.Size = new System.Drawing.Size(280, 60);
            this.lblSlogan2.Text = "Bánh tươi mỗi ngày - Trao gửi trọn vẹn hương vị hạnh phúc";

            // 
            // 2. PANEL PHẢI (Form Nhập liệu)
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.btnGoToRegister);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.pnlLine2);
            this.pnlRight.Controls.Add(this.txtPass);
            this.pnlRight.Controls.Add(this.pnlLine1);
            this.pnlRight.Controls.Add(this.txtUser);
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(350, 0);
            this.pnlRight.Size = new System.Drawing.Size(450, 500);
            this.pnlRight.TabIndex = 1;

            // Nút X đóng
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(410, 10);
            this.btnClose.Text = "✕";
            this.btnClose.Click += (s, e) => this.Close();

            // Tiêu đề Form
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(111, 78, 55); // Màu Nâu Cafe
            this.lblTitle.Location = new System.Drawing.Point(40, 60);
            this.lblTitle.Text = "ĐĂNG NHẬP";

            // Text User
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(45, 150);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(350, 27);
            this.txtUser.Text = "Tên đăng nhập";
            this.txtUser.Enter += (s, e) => { if (txtUser.Text == "Tên đăng nhập") { txtUser.Text = ""; txtUser.ForeColor = System.Drawing.Color.Black; } };
            this.txtUser.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtUser.Text)) { txtUser.Text = "Tên đăng nhập"; txtUser.ForeColor = System.Drawing.Color.Gray; } };

            // Gạch chân User
            this.pnlLine1.BackColor = System.Drawing.Color.Silver;
            this.pnlLine1.Location = new System.Drawing.Point(45, 180);
            this.pnlLine1.Size = new System.Drawing.Size(350, 2);

            // Text Pass
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(45, 220);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(350, 27);
            this.txtPass.Text = "Mật khẩu";
            this.txtPass.UseSystemPasswordChar = false; // Hiện chữ "Mật khẩu"
            this.txtPass.Enter += (s, e) => {
                if (txtPass.Text == "Mật khẩu")
                {
                    txtPass.Text = "";
                    txtPass.ForeColor = System.Drawing.Color.Black;
                    txtPass.UseSystemPasswordChar = true; // Ẩn mật khẩu
                }
            };
            this.txtPass.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    txtPass.Text = "Mật khẩu";
                    txtPass.ForeColor = System.Drawing.Color.Gray;
                    txtPass.UseSystemPasswordChar = false;
                }
            };

            // Gạch chân Pass
            this.pnlLine2.BackColor = System.Drawing.Color.Silver;
            this.pnlLine2.Location = new System.Drawing.Point(45, 250);
            this.pnlLine2.Size = new System.Drawing.Size(350, 2);

            // Nút Login (RJButton)
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 25;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(45, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(350, 50);
            this.btnLogin.Text = "ĐĂNG NHẬP NGAY";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Link Đăng ký
            this.btnGoToRegister.AutoSize = true;
            this.btnGoToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.btnGoToRegister.ForeColor = System.Drawing.Color.FromArgb(111, 78, 55);
            this.btnGoToRegister.Location = new System.Drawing.Point(110, 370);
            this.btnGoToRegister.Text = "Chưa có tài khoản? Đăng ký tại đây";
            this.btnGoToRegister.Click += new System.EventHandler(this.btnGoToRegister_Click);

            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSlogan1;
        private System.Windows.Forms.Label lblSlogan2;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlLine2;
        private SalesProjectApp.Controls.RJButton btnLogin;
        private System.Windows.Forms.Label btnGoToRegister;
    }
}