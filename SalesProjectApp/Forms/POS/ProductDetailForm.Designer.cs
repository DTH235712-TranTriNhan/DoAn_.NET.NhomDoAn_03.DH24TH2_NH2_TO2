namespace SalesProjectApp.Forms
{
    partial class ProductDetailForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label(); // <--- 1. MỚI THÊM
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();

            // --- ẢNH SẢN PHẨM ---
            this.pbImg.Location = new System.Drawing.Point(20, 60);
            this.pbImg.Size = new System.Drawing.Size(220, 220);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // --- NÚT ĐÓNG ---
            this.btnClose.Text = "X";
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(510, 10);
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.Click += (s, e) => this.Close();

            // --- TÊN MÓN ---
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(260, 50); // Đẩy lên xíu
            this.lblName.Size = new System.Drawing.Size(280, 40); // Giảm chiều cao
            this.lblName.Text = "Tên Món Ăn";

            // --- 2. MÔ TẢ SẢN PHẨM (MỚI) ---
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblDesc.ForeColor = System.Drawing.Color.Gray; // Màu xám cho nhạt hơn tiêu đề
            this.lblDesc.Location = new System.Drawing.Point(260, 90); // Nằm dưới tên
            this.lblDesc.Size = new System.Drawing.Size(280, 60); // Cho phép hiển thị 2-3 dòng
            this.lblDesc.Text = "Mô tả sản phẩm sẽ hiện ở đây...";

            // --- GIÁ (Đẩy xuống Y=160) ---
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.lblPrice.Location = new System.Drawing.Point(260, 160);
            this.lblPrice.Size = new System.Drawing.Size(200, 30);
            this.lblPrice.Text = "45.000đ";

            // --- SỐ LƯỢNG (Đẩy xuống Y=210) ---
            this.btnMinus.Text = "-";
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(265, 210);
            this.btnMinus.Size = new System.Drawing.Size(40, 40);

            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtQty.Location = new System.Drawing.Point(315, 212);
            this.txtQty.Size = new System.Drawing.Size(60, 40);

            this.btnPlus.Text = "+";
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(385, 210);
            this.btnPlus.Size = new System.Drawing.Size(40, 40);

            // --- TỔNG TIỀN (Đẩy xuống Y=260) ---
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Location = new System.Drawing.Point(260, 260);
            this.lblTotal.Size = new System.Drawing.Size(280, 30);
            this.lblTotal.Text = "Thành tiền: 45.000đ";

            // --- NÚT THÊM (Đẩy xuống Y=310) ---
            this.btnAdd.Text = "Thêm vào giỏ";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(20, 310);
            this.btnAdd.Size = new System.Drawing.Size(520, 50);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;

            // Form Settings (Tăng chiều cao lên 380)
            this.ClientSize = new System.Drawing.Size(560, 380);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesc); // Add label mới
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Paint += (s, e) => e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.Black), 0, 0, this.Width - 1, this.Height - 1);

            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.PictureBox pbImg;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblDesc; // Biến mới
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Button btnMinus;
        public System.Windows.Forms.Button btnPlus;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblTotal;
    }
}