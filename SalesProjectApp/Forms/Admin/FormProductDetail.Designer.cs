namespace SalesProjectApp.Forms.Admin
{
    partial class FormProductDetail
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
            this.picImageBg = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.picImage = new SalesProjectApp.Controls.RJPictureBox(); // Ảnh bo tròn
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnClose = new SalesProjectApp.Controls.RJButton(); // Nút bo tròn

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageBg)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader (Thanh tiêu đề màu hồng)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlHeader.Controls.Add(this.btnCloseX);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(500, 50);
            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "CHI TIẾT SẢN PHẨM";

            this.btnCloseX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseX.AutoSize = true;
            this.btnCloseX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseX.ForeColor = System.Drawing.Color.White;
            this.btnCloseX.Location = new System.Drawing.Point(465, 12);
            this.btnCloseX.Name = "btnCloseX";
            this.btnCloseX.Size = new System.Drawing.Size(25, 28);
            this.btnCloseX.TabIndex = 0;
            this.btnCloseX.Text = "X";
            this.btnCloseX.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // picImageBg (Ảnh nền mờ ở trên)
            // 
            this.picImageBg.Dock = System.Windows.Forms.DockStyle.Top;
            this.picImageBg.Location = new System.Drawing.Point(0, 50);
            this.picImageBg.Name = "picImageBg";
            this.picImageBg.Size = new System.Drawing.Size(500, 150);
            this.picImageBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage; // Sẽ được xử lý làm mờ trong code
            this.picImageBg.TabIndex = 1;
            this.picImageBg.TabStop = false;

            // 
            // pnlContent (Thẻ thông tin chính)
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblCategory);
            this.pnlContent.Controls.Add(this.lblPrice);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.picImage);
            this.pnlContent.Location = new System.Drawing.Point(20, 120); // Đặt đè lên ảnh nền một chút
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(460, 120);
            this.pnlContent.TabIndex = 2;
            // Cần thêm hiệu ứng đổ bóng cho panel này (sẽ làm trong code logic)

            // picImage (Ảnh sản phẩm chính - Bo tròn)
            // Bạn cần tạo thêm control RJPictureBox (tương tự RJButton)
            this.picImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picImage.BorderColor = System.Drawing.Color.White;
            this.picImage.BorderColor2 = System.Drawing.Color.White;
            this.picImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picImage.BorderSize = 3;
            this.picImage.GradientAngle = 50F;
            this.picImage.Location = new System.Drawing.Point(20, -30); // Nổi lên trên
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(100, 100);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;

            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblName.Location = new System.Drawing.Point(130, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(171, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên sản phẩm";

            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99); // Màu hồng
            this.lblPrice.Location = new System.Drawing.Point(130, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 37);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "50.000đ";

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblCategory.Location = new System.Drawing.Point(135, 90);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 23);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Danh mục: Bánh";

            // 
            // pnlDescription (Phần mô tả)
            // 
            this.pnlDescription.Controls.Add(this.txtDescription);
            this.pnlDescription.Controls.Add(this.label1);
            this.pnlDescription.Location = new System.Drawing.Point(20, 260);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(460, 180);
            this.pnlDescription.TabIndex = 3;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mô tả chi tiết";

            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.txtDescription.Location = new System.Drawing.Point(5, 30);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(450, 140);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "Nội dung mô tả sản phẩm...";

            // 
            // btnClose (Nút Đóng bo tròn)
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 20;
            this.btnClose.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(175, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // FormProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke; // Nền xám nhạt
            this.ClientSize = new System.Drawing.Size(500, 530);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.picImageBg);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProductDetail";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageBg)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label btnCloseX;
        private System.Windows.Forms.PictureBox picImageBg;
        private System.Windows.Forms.Panel pnlContent;
        private SalesProjectApp.Controls.RJPictureBox picImage; // Cần tạo control này
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private SalesProjectApp.Controls.RJButton btnClose;
    }
}