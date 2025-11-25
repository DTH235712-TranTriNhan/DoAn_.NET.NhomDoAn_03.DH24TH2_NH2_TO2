namespace SalesProjectApp.Forms.Admin
{
    partial class FormOrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseX = new System.Windows.Forms.Label();

            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.pnlDecor1 = new System.Windows.Forms.Panel(); // Thanh màu xanh bên trái

            this.pnlNote = new System.Windows.Forms.Panel();
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.lblNoteContent = new System.Windows.Forms.Label();
            this.pnlDecor2 = new System.Windows.Forms.Panel(); // Thanh màu vàng bên trái

            this.pnlList = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();

            // Các cột bảng
            this.colImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();

            // Nút Cập nhật trạng thái (Đặt dưới cùng)
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveStatus = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlNote.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // 
            // 1. HEADER (Màu hồng đậm)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlHeader.Controls.Add(this.btnCloseX);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.Name = "pnlHeader";

            // Title Header
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "🧾 Đơn hàng #...";

            // Nút X đóng form
            this.btnCloseX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseX.AutoSize = true;
            this.btnCloseX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseX.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCloseX.ForeColor = System.Drawing.Color.White;
            this.btnCloseX.Location = new System.Drawing.Point(760, 15);
            this.btnCloseX.Text = "✕";
            this.btnCloseX.Click += (s, e) => this.Close();

            // 
            // 2. PANEL INFO (Thông tin giao hàng)
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.pnlDecor1);
            this.pnlInfo.Controls.Add(this.lblCusAddress);
            this.pnlInfo.Controls.Add(this.lblCusPhone);
            this.pnlInfo.Controls.Add(this.lblCusName);
            this.pnlInfo.Controls.Add(this.lblInfoTitle);
            this.pnlInfo.Location = new System.Drawing.Point(20, 80);
            this.pnlInfo.Size = new System.Drawing.Size(370, 150);
            this.pnlInfo.Name = "pnlInfo";

            this.pnlDecor1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlDecor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDecor1.Width = 5;

            this.lblInfoTitle.Text = "THÔNG TIN GIAO HÀNG";
            this.lblInfoTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblInfoTitle.Location = new System.Drawing.Point(15, 15);
            this.lblInfoTitle.AutoSize = true;

            this.lblCusName.Text = "👤 Nguyễn Văn A";
            this.lblCusName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCusName.Location = new System.Drawing.Point(15, 50);
            this.lblCusName.AutoSize = true;

            this.lblCusPhone.Text = "📞 0909 123 456";
            this.lblCusPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCusPhone.Location = new System.Drawing.Point(15, 80);
            this.lblCusPhone.AutoSize = true;

            this.lblCusAddress.Text = "📍 Q.1, TP.HCM";
            this.lblCusAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCusAddress.Location = new System.Drawing.Point(15, 110);
            this.lblCusAddress.AutoSize = true;

            // 
            // 3. PANEL NOTE (Ghi chú)
            // 
            this.pnlNote.BackColor = System.Drawing.Color.White;
            this.pnlNote.Controls.Add(this.pnlDecor2);
            this.pnlNote.Controls.Add(this.lblNoteContent);
            this.pnlNote.Controls.Add(this.lblNoteTitle);
            this.pnlNote.Location = new System.Drawing.Point(410, 80);
            this.pnlNote.Size = new System.Drawing.Size(370, 150);
            this.pnlNote.Name = "pnlNote";

            this.pnlDecor2.BackColor = System.Drawing.Color.Gold;
            this.pnlDecor2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDecor2.Width = 5;

            this.lblNoteTitle.Text = "GHI CHÚ";
            this.lblNoteTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNoteTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblNoteTitle.Location = new System.Drawing.Point(15, 15);
            this.lblNoteTitle.AutoSize = true;

            this.lblNoteContent.Text = "Không có ghi chú.";
            this.lblNoteContent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblNoteContent.ForeColor = System.Drawing.Color.DimGray;
            this.lblNoteContent.Location = new System.Drawing.Point(15, 50);
            this.lblNoteContent.Size = new System.Drawing.Size(340, 80);

            // 
            // 4. PANEL LIST (Danh sách sản phẩm)
            // 
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.Controls.Add(this.lblTotalMoney);
            this.pnlList.Controls.Add(this.lblTotalLabel);
            this.pnlList.Controls.Add(this.lblShipping);
            this.pnlList.Controls.Add(this.dgvItems);
            this.pnlList.Controls.Add(this.lblListTitle);
            this.pnlList.Controls.Add(this.cboStatus);
            this.pnlList.Controls.Add(this.btnSaveStatus);
            this.pnlList.Location = new System.Drawing.Point(20, 250);
            this.pnlList.Size = new System.Drawing.Size(760, 400);
            this.pnlList.Name = "pnlList";

            this.lblListTitle.Text = "DANH SÁCH SẢN PHẨM";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblListTitle.Location = new System.Drawing.Point(20, 20);
            this.lblListTitle.AutoSize = true;

            // GridView
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            headerStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.Black;
            headerStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            headerStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvItems.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvItems.ColumnHeadersHeight = 40;

            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colImg, this.colName, this.colQty, this.colPrice, this.colTotal
            });

            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.SelectionBackColor = System.Drawing.Color.White;
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvItems.DefaultCellStyle = rowStyle;
            this.dgvItems.RowTemplate.Height = 60;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.Location = new System.Drawing.Point(20, 50);
            this.dgvItems.Size = new System.Drawing.Size(720, 230);

            // Cột Hình Ảnh
            this.colImg.HeaderText = "SẢN PHẨM";
            this.colImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImg.Name = "colImg";
            this.colImg.Width = 80;

            // Cột Tên
            this.colName.HeaderText = "";
            this.colName.Name = "colName";

            // Cột SL
            this.colQty.HeaderText = "SL";
            this.colQty.Name = "colQty";
            this.colQty.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQty.Width = 50;

            // Cột Giá
            this.colPrice.HeaderText = "GIÁ";
            this.colPrice.Name = "colPrice";
            this.colPrice.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            // Cột Tổng
            this.colTotal.HeaderText = "TỔNG";
            this.colTotal.Name = "colTotal";
            this.colTotal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // Footer (Phí ship, Tổng tiền)
            this.lblShipping.Text = "Phí vận chuyển: 0đ";
            this.lblShipping.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblShipping.Location = new System.Drawing.Point(500, 290);
            this.lblShipping.Size = new System.Drawing.Size(240, 25);

            this.lblTotalLabel.Text = "TỔNG CỘNG:";
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalLabel.Location = new System.Drawing.Point(400, 320);
            this.lblTotalLabel.Size = new System.Drawing.Size(200, 30);

            this.lblTotalMoney.Text = "0đ";
            this.lblTotalMoney.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalMoney.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.lblTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalMoney.Location = new System.Drawing.Point(600, 318);
            this.lblTotalMoney.Size = new System.Drawing.Size(140, 35);

            // Cập nhật trạng thái
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboStatus.Items.AddRange(new object[] { "Chờ xử lý", "Đang giao", "Hoàn thành", "Đã hủy" });
            this.cboStatus.Location = new System.Drawing.Point(20, 330);
            this.cboStatus.Size = new System.Drawing.Size(180, 33);

            this.btnSaveStatus.Text = "Cập nhật trạng thái";
            this.btnSaveStatus.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnSaveStatus.ForeColor = System.Drawing.Color.White;
            this.btnSaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveStatus.Location = new System.Drawing.Point(210, 328);
            this.btnSaveStatus.Size = new System.Drawing.Size(160, 35);
            this.btnSaveStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);

            // 
            // Form Main Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke; // Màu nền xám nhạt
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlNote);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Bỏ viền Windows mặc định để tự làm Header đẹp
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormOrderDetail";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label btnCloseX;

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblCusPhone;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.Panel pnlDecor1;

        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Label lblNoteTitle;
        private System.Windows.Forms.Label lblNoteContent;
        private System.Windows.Forms.Panel pnlDecor2;

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewImageColumn colImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalMoney;

        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSaveStatus;
    }
}