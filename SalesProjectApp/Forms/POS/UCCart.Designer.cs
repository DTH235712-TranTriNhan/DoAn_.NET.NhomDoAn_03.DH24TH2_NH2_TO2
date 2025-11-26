namespace SalesProjectApp.Forms
{
    partial class UCCart
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Khởi tạo các Control
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();

            // Khởi tạo các cột
            this.colImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.DataGridViewButtonColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();

            // 
            // dgvCart (Bảng giỏ hàng)
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ColumnHeadersHeight = 40;
            this.dgvCart.ColumnHeadersVisible = false; // Ẩn header

            // THÊM CÁC CỘT VÀO GRID
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colImg,    // 0: Ảnh
                this.colName,   // 1: Tên
                this.colQty,    // 2: Số lượng
                this.colTotal,  // 3: Tiền
                this.btnDel     // 4: Nút xóa
            });

            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.EnableHeadersVisualStyles = false;

            // 
            // colImg (Cột Hình Ảnh)
            // 
            this.colImg.HeaderText = "";
            this.colImg.Width = 100; // Độ rộng cột ảnh
            this.colImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;

            // 
            // colName (Cột Tên Món)
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True; // Cho phép xuống dòng
            this.colName.HeaderText = "Món ăn";

            // 
            // colQty (Cột Số lượng)
            // 
            this.colQty.Width = 50;
            this.colQty.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQty.HeaderText = "SL";

            // 
            // colTotal (Cột Thành tiền)
            // 
            this.colTotal.Width = 110;
            this.colTotal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.HeaderText = "Tiền";

            // 
            // btnDel (Cột Nút Xóa)
            // 
            this.btnDel.Width = 40;
            this.btnDel.HeaderText = "";
            this.btnDel.Text = "X";
            this.btnDel.UseColumnTextForButtonValue = true;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // 
            // pnlTotal (Panel chứa Tổng tiền)
            // 
            this.pnlTotal.Controls.Add(this.lblTotalText);
            this.pnlTotal.Controls.Add(this.lblTotalVal);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Height = 70;

            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblTotalText.Location = new System.Drawing.Point(15, 25);
            this.lblTotalText.Text = "Tổng cộng:";

            // 
            // lblTotalVal
            // 
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalVal.Location = new System.Drawing.Point(130, 20);
            this.lblTotalVal.Size = new System.Drawing.Size(250, 40);
            this.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalVal.Text = "0đ";

            // 
            // btnPay (Nút Thanh toán)
            // 
            this.btnPay.Text = "THANH TOÁN";
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPay.Height = 60;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // UCCart
            // 
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.btnPay);
            this.Size = new System.Drawing.Size(527, 600);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
        }

        // Khai báo biến Control
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Button btnPay;

        // Khai báo cột mới
        private System.Windows.Forms.DataGridViewImageColumn colImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnDel;
    }
}