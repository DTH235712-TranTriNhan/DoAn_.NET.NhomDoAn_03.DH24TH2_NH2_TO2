namespace SalesProjectApp.Forms.Auth
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSlogan2 = new System.Windows.Forms.Label();
            this.lblSlogan1 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnBackToLogin = new System.Windows.Forms.Label();
            this.btnRegister = new SalesProjectApp.Controls.RJButton();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlLine0 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();

            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // PNL LEFT (Giống Login)
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlLeft.Controls.Add(this.lblSlogan2);
            this.pnlLeft.Controls.Add(this.lblSlogan1);
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Size = new System.Drawing.Size(350, 550); // Cao hơn chút

            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(30, 50);
            this.lblBrand.Text = "SUGAR TOWN";

            this.lblSlogan1.AutoSize = true;
            this.lblSlogan1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSlogan1.ForeColor = System.Drawing.Color.White;
            this.lblSlogan1.Location = new System.Drawing.Point(30, 180);
            this.lblSlogan1.Text = "Thành Viên Mới";

            this.lblSlogan2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSlogan2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlogan2.Location = new System.Drawing.Point(35, 230);
            this.lblSlogan2.Size = new System.Drawing.Size(280, 60);
            this.lblSlogan2.Text = "Đăng ký ngay để nhận nhiều ưu đãi hấp dẫn!";

            // PNL RIGHT
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.btnBackToLogin);
            this.pnlRight.Controls.Add(this.btnRegister);
            this.pnlRight.Controls.Add(this.pnlLine3);
            this.pnlRight.Controls.Add(this.txtConfirm);
            this.pnlRight.Controls.Add(this.pnlLine2);
            this.pnlRight.Controls.Add(this.txtPass);
            this.pnlRight.Controls.Add(this.pnlLine1);
            this.pnlRight.Controls.Add(this.txtUser);
            this.pnlRight.Controls.Add(this.pnlLine0);
            this.pnlRight.Controls.Add(this.txtName);
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;

            // Nút Đóng
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(410, 10);
            this.btnClose.Text = "✕";
            this.btnClose.Click += (s, e) => this.Close();

            // Tiêu đề
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(111, 78, 55);
            this.lblTitle.Location = new System.Drawing.Point(40, 40);
            this.lblTitle.Text = "ĐĂNG KÝ";

            // Họ tên
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(45, 110);
            this.txtName.Size = new System.Drawing.Size(350, 27);
            this.txtName.Text = "Họ và tên";
            this.pnlLine0.BackColor = System.Drawing.Color.Silver;
            this.pnlLine0.Location = new System.Drawing.Point(45, 140);
            this.pnlLine0.Size = new System.Drawing.Size(350, 2);
            this.txtName.Enter += (s, e) => { if (txtName.Text == "Họ và tên") { txtName.Text = ""; } };

            // Username
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUser.Location = new System.Drawing.Point(45, 170);
            this.txtUser.Size = new System.Drawing.Size(350, 27);
            this.txtUser.Text = "Tên đăng nhập";
            this.pnlLine1.BackColor = System.Drawing.Color.Silver;
            this.pnlLine1.Location = new System.Drawing.Point(45, 200);
            this.pnlLine1.Size = new System.Drawing.Size(350, 2);
            this.txtUser.Enter += (s, e) => { if (txtUser.Text == "Tên đăng nhập") { txtUser.Text = ""; } };

            // Password
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.Location = new System.Drawing.Point(45, 230);
            this.txtPass.Size = new System.Drawing.Size(350, 27);
            this.txtPass.Text = "Mật khẩu";
            this.pnlLine2.BackColor = System.Drawing.Color.Silver;
            this.pnlLine2.Location = new System.Drawing.Point(45, 260);
            this.pnlLine2.Size = new System.Drawing.Size(350, 2);
            this.txtPass.Enter += (s, e) => { if (txtPass.Text == "Mật khẩu") { txtPass.Text = ""; txtPass.UseSystemPasswordChar = true; } };

            // Confirm Pass
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.Location = new System.Drawing.Point(45, 290);
            this.txtConfirm.Size = new System.Drawing.Size(350, 27);
            this.txtConfirm.Text = "Nhập lại mật khẩu";
            this.pnlLine3.BackColor = System.Drawing.Color.Silver;
            this.pnlLine3.Location = new System.Drawing.Point(45, 320);
            this.pnlLine3.Size = new System.Drawing.Size(350, 2);
            this.txtConfirm.Enter += (s, e) => { if (txtConfirm.Text == "Nhập lại mật khẩu") { txtConfirm.Text = ""; txtConfirm.UseSystemPasswordChar = true; } };

            // Button Register
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnRegister.BackgroundColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnRegister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegister.BorderRadius = 25;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(45, 370);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(350, 50);
            this.btnRegister.Text = "ĐĂNG KÝ";
            this.btnRegister.TextColor = System.Drawing.Color.White;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // Back Link
            this.btnBackToLogin.AutoSize = true;
            this.btnBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.btnBackToLogin.ForeColor = System.Drawing.Color.FromArgb(111, 78, 55);
            this.btnBackToLogin.Location = new System.Drawing.Point(115, 440);
            this.btnBackToLogin.Text = "Đã có tài khoản? Đăng nhập ngay";
            this.btnBackToLogin.Click += (s, e) => this.Close(); // Đóng form đăng ký sẽ lộ ra form login bên dưới

            // Main Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSlogan1;
        private System.Windows.Forms.Label lblSlogan2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label btnClose;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlLine0;

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pnlLine1;

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlLine2;

        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Panel pnlLine3;

        private SalesProjectApp.Controls.RJButton btnRegister;
        private System.Windows.Forms.Label btnBackToLogin;
    }
}