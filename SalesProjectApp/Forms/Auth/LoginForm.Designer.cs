using System.Windows.Forms;
using System;
using System.Drawing;

namespace SalesProjectApp.Forms.Auth
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlLeft = new Panel();
            this.lblBrand = new Label();
            this.lblSlogan1 = new Label();
            this.lblSlogan2 = new Label();

            this.pnlRight = new Panel();
            this.btnClose = new Label();
            this.lblTitle = new Label();
            this.txtUser = new TextBox();
            this.pnlLineUser = new Panel();
            this.txtPass = new TextBox();
            this.pnlLinePass = new Panel();
            this.btnLogin = new Controls.RJButton();
            this.btnGoToRegister = new Label();

            // === PNL LEFT ===
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlLeft.Dock = DockStyle.Left;
            this.pnlLeft.Width = 350;

            this.lblBrand.Text = "SUGAR TOWN";
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Dock = DockStyle.Top;
            this.lblBrand.Height = 80;
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSlogan1.Text = "Chào Mừng Bạn";
            this.lblSlogan1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic);
            this.lblSlogan1.ForeColor = System.Drawing.Color.White;
            this.lblSlogan1.Dock = DockStyle.Top;
            this.lblSlogan1.Height = 60;
            this.lblSlogan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSlogan2.Text = "Đăng nhập để tiếp tục trải nghiệm tuyệt vời!";
            this.lblSlogan2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSlogan2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlogan2.Dock = DockStyle.Top;
            this.lblSlogan2.Height = 60;
            this.lblSlogan2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlLeft.Controls.Add(lblSlogan2);
            this.pnlLeft.Controls.Add(lblSlogan1);
            this.pnlLeft.Controls.Add(lblBrand);

            // === PNL RIGHT ===
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Dock = DockStyle.Fill;

            this.btnClose.Text = "✕";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.Location = new System.Drawing.Point(760, 10);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            this.lblTitle.Text = "ĐĂNG NHẬP";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(111, 78, 55);
            this.lblTitle.Location = new System.Drawing.Point(45, 50);
            this.lblTitle.AutoSize = true;

            this.txtUser.Text = "Tên đăng nhập";
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUser.BorderStyle = BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(45, 120);
            this.txtUser.Width = 350;
            this.txtUser.Enter += (s, e) => { if (txtUser.Text == "Tên đăng nhập") txtUser.Text = ""; };
            this.txtUser.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtUser.Text)) txtUser.Text = "Tên đăng nhập"; };

            this.pnlLineUser.BackColor = System.Drawing.Color.Silver;
            this.pnlLineUser.Location = new System.Drawing.Point(45, 150);
            this.pnlLineUser.Width = 350;
            this.pnlLineUser.Height = 2;

            this.txtPass.Text = "Mật khẩu";
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.BorderStyle = BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(45, 170);
            this.txtPass.Width = 350;
            this.txtPass.Enter += (s, e) => { if (txtPass.Text == "Mật khẩu") { txtPass.Text = ""; txtPass.UseSystemPasswordChar = true; } };
            this.txtPass.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtPass.Text)) { txtPass.UseSystemPasswordChar = false; txtPass.Text = "Mật khẩu"; } };

            this.pnlLinePass.BackColor = System.Drawing.Color.Silver;
            this.pnlLinePass.Location = new System.Drawing.Point(45, 200);
            this.pnlLinePass.Width = 350;
            this.pnlLinePass.Height = 2;

            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.Size = new System.Drawing.Size(350, 50);
            this.btnLogin.Location = new System.Drawing.Point(45, 220);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            this.btnGoToRegister.Text = "Chưa có tài khoản? Đăng ký ngay";
            this.btnGoToRegister.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Underline);
            this.btnGoToRegister.ForeColor = System.Drawing.Color.FromArgb(111, 78, 55);
            this.btnGoToRegister.Location = new System.Drawing.Point(110, 290);
            this.btnGoToRegister.AutoSize = true;
            this.btnGoToRegister.Cursor = Cursors.Hand;
            this.btnGoToRegister.Click += new EventHandler(this.btnGoToRegister_Click);

            this.pnlRight.Controls.Add(btnClose);
            this.pnlRight.Controls.Add(lblTitle);
            this.pnlRight.Controls.Add(txtUser);
            this.pnlRight.Controls.Add(pnlLineUser);
            this.pnlRight.Controls.Add(txtPass);
            this.pnlRight.Controls.Add(pnlLinePass);
            this.pnlRight.Controls.Add(btnLogin);
            this.pnlRight.Controls.Add(btnGoToRegister);

            // === Main Form ===
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(pnlRight);
            this.Controls.Add(pnlLeft);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";
        }

        private Panel pnlLeft;
        private Label lblBrand, lblSlogan1, lblSlogan2;
        private Panel pnlRight;
        private Label btnClose, lblTitle, btnGoToRegister;
        private TextBox txtUser, txtPass;
        private Panel pnlLineUser, pnlLinePass;
        private Controls.RJButton btnLogin;
    }
}
