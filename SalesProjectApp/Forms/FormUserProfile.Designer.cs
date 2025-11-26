namespace SalesProjectApp.Forms
{
    partial class FormUserProfile
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseX = new System.Windows.Forms.Label();

            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();

            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();

            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();

            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblPassHint = new System.Windows.Forms.Label();

            // Nút bấm RJButton
            this.btnSave = new SalesProjectApp.Controls.RJButton();
            this.btnCancel = new SalesProjectApp.Controls.RJButton();

            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // 1. HEADER (Màu hồng)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlHeader.Controls.Add(this.btnCloseX);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(450, 50);
            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "THÔNG TIN CÁ NHÂN";

            this.btnCloseX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseX.AutoSize = true;
            this.btnCloseX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseX.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCloseX.ForeColor = System.Drawing.Color.White;
            this.btnCloseX.Location = new System.Drawing.Point(410, 10);
            this.btnCloseX.Name = "btnCloseX";
            this.btnCloseX.Text = "✕";
            this.btnCloseX.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // 2. BODY FORM
            // 

            // Username (Readonly)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";

            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Enabled = false; // Không cho sửa
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(30, 96);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(390, 32);
            this.txtUsername.TabIndex = 2;

            // FullName
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên";

            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFullName.Location = new System.Drawing.Point(30, 166);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(390, 32);
            this.txtFullName.TabIndex = 4;

            // Email
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(30, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";

            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(30, 236);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 32);
            this.txtEmail.TabIndex = 6;

            // Phone
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(30, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";

            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhone.Location = new System.Drawing.Point(30, 306);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(390, 32);
            this.txtPhone.TabIndex = 8;

            // New Password
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(30, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đổi mật khẩu";

            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPass.Location = new System.Drawing.Point(30, 376);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(390, 32);
            this.txtNewPass.TabIndex = 10;
            this.txtNewPass.UseSystemPasswordChar = true; // Ẩn ký tự password

            this.lblPassHint.AutoSize = true;
            this.lblPassHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblPassHint.ForeColor = System.Drawing.Color.Gray;
            this.lblPassHint.Location = new System.Drawing.Point(30, 411);
            this.lblPassHint.Name = "lblPassHint";
            this.lblPassHint.Size = new System.Drawing.Size(267, 20);
            this.lblPassHint.TabIndex = 11;
            this.lblPassHint.Text = "(Để trống nếu không muốn đổi mật khẩu)";

            // 
            // 3. BUTTONS
            // 

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 22;
            this.btnSave.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(230, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "LƯU THAY ĐỔI";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 22;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(30, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.TextColor = System.Drawing.Color.DimGray;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // FormUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 530);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPassHint);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "FormUserProfile";
            this.Text = "Thông tin cá nhân";

            // Vẽ viền mỏng quanh form
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Paint += (s, e) => e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.Silver), 0, 0, this.Width - 1, this.Height - 1);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label btnCloseX;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblPassHint;

        private SalesProjectApp.Controls.RJButton btnSave;
        private SalesProjectApp.Controls.RJButton btnCancel;
    }
}