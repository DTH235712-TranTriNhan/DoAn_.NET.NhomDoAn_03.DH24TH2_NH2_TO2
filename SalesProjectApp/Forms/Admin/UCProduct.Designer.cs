namespace SalesProjectApp.Forms.Admin
{
    partial class UCProduct
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();

            // Khai báo các cột
            this.colImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh sách sản phẩm";

            // 
            // pnlLine (Gạch chân hồng)
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlLine.Location = new System.Drawing.Point(30, 70);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(60, 5);
            this.pnlLine.TabIndex = 1;

            // 
            // btnAdd (Nút Thêm)
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(740, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+ Thêm món mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // pnlCard (Khung trắng chứa bảng)
            // 
            this.pnlCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.dgvProduct);
            this.pnlCard.Location = new System.Drawing.Point(30, 100);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(890, 620);
            this.pnlCard.TabIndex = 3;

            // 
            // dgvProduct (Bảng dữ liệu)
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Style Header
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.Black;
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvProduct.ColumnHeadersHeight = 50;

            // Thêm các cột
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImg,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.btnEdit});

            // Style Row
            rowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            rowStyle.BackColor = System.Drawing.SystemColors.Window;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            rowStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = rowStyle;

            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 60; // Chiều cao hàng
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(890, 620);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);

            // 
            // colImg (Cột 0: Hình Ảnh)
            // 
            this.colImg.HeaderText = "HÌNH ẢNH";
            this.colImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImg.MinimumWidth = 6;
            this.colImg.Name = "colImg";
            this.colImg.Width = 120;

            // 
            // colName (Cột 1: Tên Bánh)
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "TÊN BÁNH";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";

            // 
            // colCategory (Cột 2: Danh Mục)
            // 
            this.colCategory.HeaderText = "DANH MỤC";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.Width = 180;

            // 
            // colPrice (Cột 3: Giá Bán)
            // 
            this.colPrice.HeaderText = "GIÁ BÁN";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 150;

            // 
            // btnEdit (Cột 4: Nút Sửa)
            // 
            this.btnEdit.HeaderText = "HÀNH ĐỘNG";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 120;

            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(950, 750);
            this.pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewImageColumn colImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
    }
}