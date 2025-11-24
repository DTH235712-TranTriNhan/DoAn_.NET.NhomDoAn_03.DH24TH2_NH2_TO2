namespace SalesProjectApp.Forms.Auth
{
    partial class RegisterForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.picEyePass = new System.Windows.Forms.PictureBox();
            this.picEyeConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEyePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            // Căn giữa theo chiều ngang
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TẠO TÀI KHOẢN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            // Căn giữa
            this.lblSubtitle.Location = new System.Drawing.Point(0, 75);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(442, 23);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Điền thông tin để trở thành thành viên:";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(50, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 32);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Họ và tên";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(50, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 32);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Tên đăng nhập ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(50, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Mật khẩu";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.Location = new System.Drawing.Point(50, 265);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(350, 32);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.Text = "Nhập lại mật khẩu";
            // 
            // picEyePass
            // 
            this.picEyePass.BackColor = System.Drawing.Color.White;
            this.picEyePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyePass.Image = global::SalesProjectApp.Properties.Resources.AnPW;
            // Đè lên txtPassword
            this.picEyePass.Location = new System.Drawing.Point(368, 216);
            this.picEyePass.Name = "picEyePass";
            this.picEyePass.Size = new System.Drawing.Size(30, 30);
            this.picEyePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyePass.TabIndex = 9;
            this.picEyePass.TabStop = false;
            // 
            // picEyeConfirm
            // 
            this.picEyeConfirm.BackColor = System.Drawing.Color.White;
            this.picEyeConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeConfirm.Image = global::SalesProjectApp.Properties.Resources.AnPW;
            // Đè lên txtConfirmPassword
            this.picEyeConfirm.Location = new System.Drawing.Point(368, 266);
            this.picEyeConfirm.Name = "picEyeConfirm";
            this.picEyeConfirm.Size = new System.Drawing.Size(30, 30);
            this.picEyeConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeConfirm.TabIndex = 10;
            this.picEyeConfirm.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(50, 320);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(350, 50);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "ĐĂNG KÝ NGAY";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFooter.ForeColor = System.Drawing.Color.Gray;
            this.lblFooter.Location = new System.Drawing.Point(90, 390);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(138, 23);
            this.lblFooter.TabIndex = 7;
            this.lblFooter.Text = "Đã có tài khoản?";
            // 
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.lnkLogin.Location = new System.Drawing.Point(235, 390);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(142, 23);
            this.lnkLogin.TabIndex = 8;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Đăng nhập ngay";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLoginLinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 455);
            // THÊM 2 CON MẮT TRƯỚC TEXTBOX ĐỂ NÓ NỔI LÊN TRÊN
            this.Controls.Add(this.picEyePass);
            this.Controls.Add(this.picEyeConfirm);

            this.Controls.Add(this.lnkLogin);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký thành viên";
            ((System.ComponentModel.ISupportInitialize)(this.picEyePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.LinkLabel lnkLogin;
        // KHAI BÁO 2 CON MẮT
        private System.Windows.Forms.PictureBox picEyePass;
        private System.Windows.Forms.PictureBox picEyeConfirm;
    }
}