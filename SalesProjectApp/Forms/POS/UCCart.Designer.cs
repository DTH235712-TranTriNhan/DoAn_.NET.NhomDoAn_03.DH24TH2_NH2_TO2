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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();

            this.colImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlTotal (Panel chứa tổng tiền)
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotal.Controls.Add(this.lblTotalVal);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.btnPay);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 480);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(350, 120);
            this.pnlTotal.TabIndex = 0;

            // 
            // lblTotalVal
            // 
            this.lblTotalVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(238, 77, 45);
            this.lblTotalVal.Location = new System.Drawing.Point(180, 15);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(160, 25);
            this.lblTotalVal.TabIndex = 2;
            this.lblTotalVal.Text = "0 đ";
            this.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(10, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "TỔNG TIỀN:";

            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(238, 77, 45);
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(0, 60);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(350, 60);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "THANH TOÁN";
            this.btnPay.UseVisualStyleBackColor = false;

            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCart.ColumnHeadersVisible = false; // Ẩn header

            // CẤU HÌNH CỘT
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImg,
            this.colName,
            this.colQty,
            this.colTotal,
            this.colDelete});

            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvCart.Location = new System.Drawing.Point(0, 0);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;

            // QUAN TRỌNG: Chiều cao dòng = 150
            this.dgvCart.RowTemplate.Height = 150;
            this.dgvCart.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(350, 480);
            this.dgvCart.TabIndex = 1;

            // 
            // colImg (Hình ảnh)
            // 
            this.colImg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colImg.HeaderText = "";
            this.colImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom; // ZOOM ẢNH
            this.colImg.MinimumWidth = 130;
            this.colImg.Name = "colImg";
            this.colImg.ReadOnly = true;
            this.colImg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colImg.Width = 130;

            // 
            // colName (Tên + Ghi chú)
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True; // XUỐNG DÒNG
            this.colName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colName.HeaderText = "Sản phẩm";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;

            // 
            // colQty
            // 
            this.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQty.HeaderText = "SL";
            this.colQty.MinimumWidth = 40;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQty.Width = 40;

            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(238, 77, 45);
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotal.HeaderText = "Tổng";
            this.colTotal.MinimumWidth = 70;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTotal.Width = 70;

            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 30;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.Text = "✕";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 30;

            // 
            // UCCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.pnlTotal);
            this.Name = "UCCart";
            this.Size = new System.Drawing.Size(350, 600);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewImageColumn colImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}