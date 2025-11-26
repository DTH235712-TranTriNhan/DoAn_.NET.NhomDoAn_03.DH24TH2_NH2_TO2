namespace SalesProjectApp.Forms
{
    partial class UCBanner
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnAction = new SalesProjectApp.Controls.RJButton();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlContent (Khung mờ chứa nội dung)
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(180, 255, 255, 255); // Trắng mờ
            this.pnlContent.Controls.Add(this.btnAction);
            this.pnlContent.Controls.Add(this.lblSub);
            this.pnlContent.Controls.Add(this.lblSlogan);
            this.pnlContent.Location = new System.Drawing.Point(200, 50); // Vị trí tương đối
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(600, 200);
            this.pnlContent.TabIndex = 0;

            // 
            // lblSlogan
            // 
            this.lblSlogan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99); // Màu hồng
            this.lblSlogan.Location = new System.Drawing.Point(0, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(600, 80);
            this.lblSlogan.TabIndex = 0;
            this.lblSlogan.Text = "Vị Ngọt Yêu Thương";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;

            // 
            // lblSub
            // 
            this.lblSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblSub.Location = new System.Drawing.Point(0, 80);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(600, 40);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Trao gửi trọn vẹn hương vị hạnh phúc trong từng chiếc bánh";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnAction.BackgroundColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnAction.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAction.BorderRadius = 25;
            this.btnAction.BorderSize = 0;
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(200, 130);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(200, 50);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "KHÁM PHÁ NGAY";
            this.btnAction.TextColor = System.Drawing.Color.White;
            this.btnAction.UseVisualStyleBackColor = false;

            // 
            // UCBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; // Để bạn set ảnh nền
            this.Controls.Add(this.pnlContent);
            this.Name = "UCBanner";
            this.Size = new System.Drawing.Size(1000, 300);

            // Căn giữa panel khi resize
            this.Resize += (s, e) => {
                pnlContent.Location = new System.Drawing.Point((this.Width - pnlContent.Width) / 2, (this.Height - pnlContent.Height) / 2);
            };

            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblSub;
        private SalesProjectApp.Controls.RJButton btnAction;
    }
}