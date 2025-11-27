using System.Windows.Forms;
using System;
using System.Drawing;

namespace SalesProjectApp.Forms.Auth
{
    partial class RegisterForm
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
            this.txtName = new TextBox();
            this.pnlLineName = new Panel();
            this.txtUser = new TextBox();
            this.pnlLineUser = new Panel();
            this.txtPass = new TextBox();
            this.pnlLinePass = new Panel();
            this.txtConfirm = new TextBox();
            this.pnlLineConfirm = new Panel();
            this.btnRegister = new Controls.RJButton();
            this.btnBackToLogin = new Label();

            // === PNL LEFT ===
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlLeft.Dock = DockStyle.Left;
            this.pnlLeft.Width = 350;

            this.lblBrand.Text = "SUGAR TOWN";
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = Color.White;
            this.lblBrand.Dock = DockStyle.Top;
            this.lblBrand.Height = 80;
            this.lblBrand.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSlogan1.Text = "Thành Viên Mới";
            this.lblSlogan1.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Italic);
            this.lblSlogan1.ForeColor = Color.White;
            this.lblSlogan1.Dock = DockStyle.Top;
            this.lblSlogan1.Height = 60;
            this.lblSlogan1.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSlogan2.Text = "Đăng ký ngay để nhận nhiều ưu đãi hấp dẫn!";
            this.lblSlogan2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSlogan2.ForeColor = Color.WhiteSmoke;
            this.lblSlogan2.Dock = DockStyle.Top;
            this.lblSlogan2.Height = 60;
            this.lblSlogan2.TextAlign = ContentAlignment.MiddleCenter;

            this.pnlLeft.Controls.Add(lblSlogan2);
            this.pnlLeft.Controls.Add(lblSlogan1);
            this.pnlLeft.Controls.Add(lblBrand);

            // === PNL RIGHT ===
            this.pnlRight.BackColor = Color.White;
            this.pnlRight.Dock = DockStyle.Fill;

            this.btnClose.Text = "✕";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 16F, FontStyle.Bold);
            this.btnClose.ForeColor = Color.Gray;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.Location = new System.Drawing.Point(760, 10);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            this.lblTitle.Text = "ĐĂNG KÝ";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(111, 78, 55);
            this.lblTitle.Location = new System.Drawing.Point(45, 50);
            this.lblTitle.AutoSize = true;

            int txtWidth = 350;
            int txtStartY = 120;
            int txtHeight = 27;
            int lineHeight = 2;
            int space = 50;

            // Họ và tên
            this.txtName.Text = "Họ và tên";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.BorderStyle = BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(45, txtStartY);
            this.txtName.Width = txtWidth;
            this.txtName.Enter += (s, e) => { if (txtName.Text == "Họ và tên") txtName.Text = ""; };
            this.txtName.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtName.Text)) txtName.Text = "Họ và tên"; };

            this.pnlLineName.BackColor = Color.Silver;
            this.pnlLineName.Location = new System.Drawing.Point(45, txtStartY + txtHeight + 5);
            this.pnlLineName.Size = new System.Drawing.Size(txtWidth, lineHeight);

            // Username
            this.txtUser.Text = "Tên đăng nhập";
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUser.BorderStyle = BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(45, txtStartY + space);
            this.txtUser.Width = txtWidth;
            this.txtUser.Enter += (s, e) => { if (txtUser.Text == "Tên đăng nhập") txtUser.Text = ""; };
            this.txtUser.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtUser.Text)) txtUser.Text = "Tên đăng nhập"; };

            this.pnlLineUser.BackColor = Color.Silver;
            this.pnlLineUser.Location = new System.Drawing.Point(45, txtStartY + space + txtHeight + 5);
            this.pnlLineUser.Size = new System.Drawing.Size(txtWidth, lineHeight);

            // Password
            this.txtPass.Text = "Mật khẩu";
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.BorderStyle = BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(45, txtStartY + space * 2);
            this.txtPass.Width = txtWidth;
            this.txtPass.Enter += (s, e) => { if (txtPass.Text == "Mật khẩu") { txtPass.Text = ""; txtPass.UseSystemPasswordChar = true; } };
            this.txtPass.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtPass.Text)) { txtPass.UseSystemPasswordChar = false; txtPass.Text = "Mật khẩu"; } };

            this.pnlLinePass.BackColor = Color.Silver;
            this.pnlLinePass.Location = new System.Drawing.Point(45, txtStartY + space * 2 + txtHeight + 5);
            this.pnlLinePass.Size = new System.Drawing.Size(txtWidth, lineHeight);

            // Confirm Password
            this.txtConfirm.Text = "Nhập lại mật khẩu";
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.BorderStyle = BorderStyle.None;
            this.txtConfirm.Location = new System.Drawing.Point(45, txtStartY + space * 3);
            this.txtConfirm.Width = txtWidth;
            this.txtConfirm.Enter += (s, e) => { if (txtConfirm.Text == "Nhập lại mật khẩu") { txtConfirm.Text = ""; txtConfirm.UseSystemPasswordChar = true; } };
            this.txtConfirm.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtConfirm.Text)) { txtConfirm.UseSystemPasswordChar = false; txtConfirm.Text = "Nhập lại mật khẩu"; } };

            this.pnlLineConfirm.BackColor = Color.Silver;
            this.pnlLineConfirm.Location = new System.Drawing.Point(45, txtStartY + space * 3 + txtHeight + 5);
            this.pnlLineConfirm.Size = new System.Drawing.Size(txtWidth, lineHeight);

            // Button Register
            this.btnRegister.Text = "ĐĂNG KÝ";
            this.btnRegister.Size = new System.Drawing.Size(txtWidth, 50);
            this.btnRegister.Location = new System.Drawing.Point(45, txtStartY + space * 4);
            this.btnRegister.BackColor = Color.FromArgb(233, 30, 99);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            // Back to Login
            this.btnBackToLogin.Text = "Đã có tài khoản? Đăng nhập ngay";
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Underline);
            this.btnBackToLogin.ForeColor = Color.FromArgb(111, 78, 55);
            this.btnBackToLogin.Location = new System.Drawing.Point(90, txtStartY + space * 5 + 10);
            this.btnBackToLogin.AutoSize = true;
            this.btnBackToLogin.Cursor = Cursors.Hand;
            this.btnBackToLogin.Click += new EventHandler(this.btnBackToLogin_Click);

            this.pnlRight.Controls.Add(btnClose);
            this.pnlRight.Controls.Add(lblTitle);
            this.pnlRight.Controls.Add(txtName);
            this.pnlRight.Controls.Add(pnlLineName);
            this.pnlRight.Controls.Add(txtUser);
            this.pnlRight.Controls.Add(pnlLineUser);
            this.pnlRight.Controls.Add(txtPass);
            this.pnlRight.Controls.Add(pnlLinePass);
            this.pnlRight.Controls.Add(txtConfirm);
            this.pnlRight.Controls.Add(pnlLineConfirm);
            this.pnlRight.Controls.Add(btnRegister);
            this.pnlRight.Controls.Add(btnBackToLogin);

            // === Main Form ===
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(pnlRight);
            this.Controls.Add(pnlLeft);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Register";
        }

        private Panel pnlLeft, pnlRight;
        private Label lblBrand, lblSlogan1, lblSlogan2, lblTitle, btnClose, btnBackToLogin;
        private TextBox txtName, txtUser, txtPass, txtConfirm;
        private Panel pnlLineName, pnlLineUser, pnlLinePass, pnlLineConfirm;
        private Controls.RJButton btnRegister;
    }
}
