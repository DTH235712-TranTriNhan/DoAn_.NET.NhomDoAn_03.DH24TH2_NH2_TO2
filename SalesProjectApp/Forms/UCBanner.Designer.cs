namespace SalesProjectApp.Forms
{
    partial class UCBanner
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.btnAction = new SalesProjectApp.Controls.RJButton();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlCard (Cái khung mờ ở giữa banner)
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(150, 255, 255, 255); // Trắng trong suốt
            this.pnlCard.Controls.Add(this.btnAction);
            this.pnlCard.Controls.Add(this.lblSub);
            this.pnlCard.Controls.Add(this.lblSlogan);
            this.pnlCard.Location = new System.Drawing.Point(250, 40); // Căn giữa tương đối
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(500, 220);
            this.pnlCard.TabIndex = 0;
            // Bo tròn panel này bằng code paint nếu muốn đẹp hơn, tạm thời để vuông bo nhẹ

            // 
            // lblSlogan
            // 
            this.lblSlogan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSlogan.ForeColor = System.Drawing.Color.White; // Sẽ dùng Shadow
            this.lblSlogan.Location = new System.Drawing.Point(0, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(500, 80);
            this.lblSlogan.TabIndex = 0;
            this.lblSlogan.Text = "Vị Ngọt Yêu Thương";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSlogan.UseCompatibleTextRendering = true; // Để render đẹp hơn

            // 
            // lblSub
            // 
            this.lblSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblSub.Location = new System.Drawing.Point(0, 80);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(500, 50);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Bánh tươi mỗi ngày - Trao gửi trọn vẹn hương vị hạnh phúc";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnAction.BackgroundColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnAction.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAction.BorderRadius = 25;
            this.btnAction.BorderSize = 0;
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(150, 140);
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
            this.Controls.Add(this.pnlCard);
            this.Name = "UCBanner";
            this.Size = new System.Drawing.Size(1000, 300); // Banner to

            // Sự kiện Resize để căn giữa khung nội dung
            this.Resize += (s, e) => {
                pnlCard.Location = new System.Drawing.Point((this.Width - pnlCard.Width) / 2, (this.Height - pnlCard.Height) / 2);
            };

            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblSub;
        private SalesProjectApp.Controls.RJButton btnAction;
    }
}