namespace SalesProjectApp.Forms
{
    partial class UCOrderHistory
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Lịch sử đơn hàng";

            // Line
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlLine.Location = new System.Drawing.Point(20, 70);
            this.pnlLine.Size = new System.Drawing.Size(60, 5);

            // Card Panel
            this.pnlCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.dgvHistory);
            this.pnlCard.Location = new System.Drawing.Point(20, 90);
            this.pnlCard.Size = new System.Drawing.Size(540, 600);

            // GridView
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.ColumnHeadersHeight = 40;

            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = headerStyle;

            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCode, this.colDate, this.colTotal, this.colStatus });

            // Columns
            this.colCode.HeaderText = "MÃ ĐƠN";
            this.colDate.HeaderText = "NGÀY GIỜ";
            this.colTotal.HeaderText = "TỔNG TIỀN";
            this.colStatus.HeaderText = "TRẠNG THÁI";

            // Main
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblTitle);
            this.Size = new System.Drawing.Size(580, 700);

            this.pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}