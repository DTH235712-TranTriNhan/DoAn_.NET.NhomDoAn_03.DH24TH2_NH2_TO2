namespace SalesProjectApp.Forms.Admin
{
    partial class UCCustomer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(373, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh sách khách hàng";
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.pnlLine.Location = new System.Drawing.Point(30, 70);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(60, 5);
            this.pnlLine.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(685, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 32);
            this.txtSearch.TabIndex = 2;
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.dgvCustomer);
            this.pnlCard.Location = new System.Drawing.Point(30, 100);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(925, 620);
            this.pnlCard.TabIndex = 3;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeight = 50;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.btnEdit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 50;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(925, 620);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "MÃ KH";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.HeaderText = "HỌ TÊN";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 180;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "SĐT";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 120;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "EMAIL";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 180;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.HeaderText = "ĐỊA CHỈ";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "HÀNH ĐỘNG";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // UCCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCCustomer";
            this.Size = new System.Drawing.Size(985, 750);
            this.pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
    }
}