namespace SalesProjectApp.Forms
{
    partial class ProductDetailForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();

            this.picImage = new System.Windows.Forms.PictureBox();

            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();

            // Phần Ghi chú
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();

            // Phần Số lượng
            this.btnMinus = new SalesProjectApp.Controls.RJButton();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnPlus = new SalesProjectApp.Controls.RJButton();

            // Nút Thêm
            this.btnAdd = new SalesProjectApp.Controls.RJButton();

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();

            // 
            // 1. HEADER (Màu hồng)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(600, 50);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Text = "THÊM MÓN";

            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(560, 10);
            this.btnClose.Text = "✕";
            this.btnClose.Click += (s, e) => this.Close();

            // 
            // 2. ẢNH (Bên trái)
            // 
            this.picImage.Location = new System.Drawing.Point(20, 70);
            this.picImage.Size = new System.Drawing.Size(200, 200);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // 3. THÔNG TIN (Bên phải)
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblName.Location = new System.Drawing.Point(240, 70);
            this.lblName.Size = new System.Drawing.Size(340, 70); // Cho phép tên dài xuống dòng
            this.lblName.Text = "Tên Món Ăn";

            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.lblPrice.Location = new System.Drawing.Point(240, 140);
            this.lblPrice.Text = "0đ";

            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblDesc.Location = new System.Drawing.Point(240, 180);
            this.lblDesc.Size = new System.Drawing.Size(340, 80);
            this.lblDesc.Text = "Mô tả sản phẩm...";

            // 
            // 4. GHI CHÚ (Ở giữa)
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNote.Location = new System.Drawing.Point(20, 290);
            this.lblNote.Text = "Ghi chú cho bếp (Ít đường, không đá...):";

            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNote.Location = new System.Drawing.Point(20, 320);
            this.txtNote.Multiline = true;
            this.txtNote.Size = new System.Drawing.Size(560, 60);
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // 
            // 5. SỐ LƯỢNG & NÚT THÊM (Dưới cùng)
            // 
            // Nút Trừ
            this.btnMinus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinus.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinus.BorderRadius = 20;
            this.btnMinus.BorderSize = 1;
            this.btnMinus.BorderColor = System.Drawing.Color.Silver;
            this.btnMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(20, 400);
            this.btnMinus.Size = new System.Drawing.Size(50, 50);
            this.btnMinus.Text = "-";
            this.btnMinus.Click += (s, e) => { /* Logic trong file .cs */ };

            // Ô Số lượng
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.Location = new System.Drawing.Point(80, 405);
            this.txtQty.Size = new System.Drawing.Size(60, 43);
            this.txtQty.Text = "1";

            // Nút Cộng
            this.btnPlus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlus.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlus.BorderRadius = 20;
            this.btnPlus.BorderSize = 1;
            this.btnPlus.BorderColor = System.Drawing.Color.Silver;
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(150, 400);
            this.btnPlus.Size = new System.Drawing.Size(50, 50);
            this.btnPlus.Text = "+";
            this.btnPlus.Click += (s, e) => { /* Logic trong file .cs */ };

            // Nút Thêm vào giỏ (To, màu hồng)
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnAdd.BorderRadius = 25;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(230, 400);
            this.btnAdd.Size = new System.Drawing.Size(350, 50);
            this.btnAdd.Text = "Thêm vào giỏ - 0đ";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // Form Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // Viền đen mỏng
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Paint += (s, e) => e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.DimGray), 0, 0, this.Width - 1, this.Height - 1);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrice;

        // Biến mới
        private System.Windows.Forms.Label lblNote;
        public System.Windows.Forms.TextBox txtNote; // Public để lấy dữ liệu ra ngoài
        private SalesProjectApp.Controls.RJButton btnMinus;
        private System.Windows.Forms.TextBox txtQty;
        private SalesProjectApp.Controls.RJButton btnPlus;
        private SalesProjectApp.Controls.RJButton btnAdd;
    }
}