namespace SalesProjectApp.Forms.Auth
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(50, 115);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 32);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Tên đăng nhập";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(50, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Mật khẩu";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            // Màu sắc sẽ được set tự động bằng AppTheme
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(350, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lnkRegister
            // 
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkRegister.Location = new System.Drawing.Point(0, 320);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(450, 30);
            this.lnkRegister.TabIndex = 5;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Chưa có tài khoản? Đăng ký ngay";
            this.lnkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegisterLinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 45);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picEye
            // 
            this.picEye.BackColor = System.Drawing.Color.White;
            this.picEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye.Image = global::SalesProjectApp.Properties.Resources.AnPW;
            // Đặt ở 368 để đè lên góc phải (50 + 350 - 30 - 2)
            this.picEye.Location = new System.Drawing.Point(368, 186);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(30, 30);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 7;
            this.picEye.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnLogin;
            this.ClientSize = new System.Drawing.Size(450, 420);

            // --- DANH SÁCH ADD CONTROL ---
            // 1. Add các control nền tảng trước
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsername);

            // 2. Add TextBox Mật khẩu
            this.Controls.Add(this.txtPassword);

            // 3. QUAN TRỌNG: Add picEye SAU CÙNG để nó NỔI LÊN TRÊN TextBox
            this.Controls.Add(this.picEye);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picEye;
    }
}