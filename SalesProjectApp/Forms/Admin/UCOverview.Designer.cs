using System.Drawing;
using FontAwesome.Sharp; // Cần thư viện này

namespace SalesProjectApp.Forms.Admin
{
    partial class UCOverview
    {
        private System.ComponentModel.IContainer components = null;

        // Đã xóa hàm Dispose

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();

            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.iconRevenue = new FontAwesome.Sharp.IconPictureBox(); // Thay Label bằng IconPictureBox
            this.lblC1Val = new System.Windows.Forms.Label();
            this.lblC1Title = new System.Windows.Forms.Label();

            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.iconPending = new FontAwesome.Sharp.IconPictureBox();
            this.lblC2Val = new System.Windows.Forms.Label();
            this.lblC2Title = new System.Windows.Forms.Label();

            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.iconProduct = new FontAwesome.Sharp.IconPictureBox();
            this.lblC3Val = new System.Windows.Forms.Label();
            this.lblC3Title = new System.Windows.Forms.Label();

            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.iconCustomer = new FontAwesome.Sharp.IconPictureBox();
            this.lblC4Val = new System.Windows.Forms.Label();
            this.lblC4Title = new System.Windows.Forms.Label();

            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.tlpCards.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRevenue)).BeginInit(); // Init Icon
            this.pnlCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPending)).BeginInit();
            this.pnlCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProduct)).BeginInit();
            this.pnlCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 50);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Tổng Quan";

            // lblDate
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(725, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "Hôm nay: ...";

            // tlpCards
            this.tlpCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.pnlCard1, 0, 0);
            this.tlpCards.Controls.Add(this.pnlCard2, 1, 0);
            this.tlpCards.Controls.Add(this.pnlCard3, 2, 0);
            this.tlpCards.Controls.Add(this.pnlCard4, 3, 0);
            this.tlpCards.Location = new System.Drawing.Point(30, 90);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(895, 120);
            this.tlpCards.TabIndex = 5;

            // 
            // Card 1 (Doanh thu)
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(233, 30, 99);
            this.pnlCard1.Controls.Add(this.iconRevenue); // Add Icon mới
            this.pnlCard1.Controls.Add(this.lblC1Val);
            this.pnlCard1.Controls.Add(this.lblC1Title);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard1.Location = new System.Drawing.Point(3, 3);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.pnlCard1.Name = "pnlCard1";

            // Icon Money
            this.iconRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRevenue.BackColor = System.Drawing.Color.Transparent;
            this.iconRevenue.ForeColor = System.Drawing.Color.FromArgb(80, 255, 255, 255); // Trắng mờ
            this.iconRevenue.IconChar = FontAwesome.Sharp.IconChar.DollarSign; // Biểu tượng Tiền
            this.iconRevenue.IconColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
            this.iconRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRevenue.IconSize = 70;
            this.iconRevenue.Location = new System.Drawing.Point(130, 10);
            this.iconRevenue.Name = "iconRevenue";
            this.iconRevenue.Size = new System.Drawing.Size(70, 70);
            this.iconRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRevenue.TabIndex = 0;
            this.iconRevenue.TabStop = false;

            this.lblC1Val.AutoSize = true;
            this.lblC1Val.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblC1Val.ForeColor = System.Drawing.Color.White;
            this.lblC1Val.Location = new System.Drawing.Point(10, 50);
            this.lblC1Val.Text = "0";

            this.lblC1Title.AutoSize = true;
            this.lblC1Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblC1Title.Location = new System.Drawing.Point(10, 15);
            this.lblC1Title.Text = "DOANH THU";

            // 
            // Card 2 (Đơn chờ)
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.pnlCard2.Controls.Add(this.iconPending);
            this.pnlCard2.Controls.Add(this.lblC2Val);
            this.pnlCard2.Controls.Add(this.lblC2Title);
            this.pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard2.Location = new System.Drawing.Point(224, 3);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.pnlCard2.Name = "pnlCard2";

            // Icon Clock
            this.iconPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPending.BackColor = System.Drawing.Color.Transparent;
            this.iconPending.ForeColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
            this.iconPending.IconChar = FontAwesome.Sharp.IconChar.Clock; // Biểu tượng Đồng hồ
            this.iconPending.IconColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
            this.iconPending.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPending.IconSize = 70;
            this.iconPending.Location = new System.Drawing.Point(130, 10);
            this.iconPending.Name = "iconPending";
            this.iconPending.Size = new System.Drawing.Size(70, 70);
            this.iconPending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPending.TabIndex = 0;
            this.iconPending.TabStop = false;

            this.lblC2Val.AutoSize = true;
            this.lblC2Val.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblC2Val.ForeColor = System.Drawing.Color.White;
            this.lblC2Val.Location = new System.Drawing.Point(10, 50);
            this.lblC2Val.Text = "0";

            this.lblC2Title.AutoSize = true;
            this.lblC2Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblC2Title.Location = new System.Drawing.Point(10, 15);
            this.lblC2Title.Text = "ĐƠN CHỜ";

            // 
            // Card 3 (Sản phẩm)
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(156, 39, 176);
            this.pnlCard3.Controls.Add(this.iconProduct);
            this.pnlCard3.Controls.Add(this.lblC3Val);
            this.pnlCard3.Controls.Add(this.lblC3Title);
            this.pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard3.Location = new System.Drawing.Point(445, 3);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.pnlCard3.Name = "pnlCard3";

            // Icon Box
            this.iconProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconProduct.BackColor = System.Drawing.Color.Transparent;
            this.iconProduct.ForeColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
            this.iconProduct.IconChar = FontAwesome.Sharp.IconChar.BoxOpen; // Biểu tượng Hộp
            this.iconProduct.IconColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
            this.iconProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProduct.IconSize = 70;
            this.iconProduct.Location = new System.Drawing.Point(130, 10);
            this.iconProduct.Name = "iconProduct";
            this.iconProduct.Size = new System.Drawing.Size(70, 70);
            this.iconProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconProduct.TabIndex = 0;
            this.iconProduct.TabStop = false;

            this.lblC3Val.AutoSize = true;
            this.lblC3Val.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblC3Val.ForeColor = System.Drawing.Color.White;
            this.lblC3Val.Location = new System.Drawing.Point(10, 50);
            this.lblC3Val.Text = "0";

            this.lblC3Title.AutoSize = true;
            this.lblC3Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblC3Title.Location = new System.Drawing.Point(10, 15);
            this.lblC3Title.Text = "SẢN PHẨM";

            // 
            // Card 4 (Khách hàng)
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(0, 188, 212);
            this.pnlCard4.Controls.Add(this.iconCustomer);
            this.pnlCard4.Controls.Add(this.lblC4Val);
            this.pnlCard4.Controls.Add(this.lblC4Title);
            this.pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard4.Location = new System.Drawing.Point(666, 3);
            this.pnlCard4.Name = "pnlCard4";

            // Icon Users
            this.iconCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCustomer.BackColor = System.Drawing.Color.Transparent;
            this.iconCustomer.ForeColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
            this.iconCustomer.IconChar = FontAwesome.Sharp.IconChar.Users; // Biểu tượng Khách hàng
            this.iconCustomer.IconColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
            this.iconCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCustomer.IconSize = 70;
            this.iconCustomer.Location = new System.Drawing.Point(130, 10);
            this.iconCustomer.Name = "iconCustomer";
            this.iconCustomer.Size = new System.Drawing.Size(70, 70);
            this.iconCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCustomer.TabIndex = 0;
            this.iconCustomer.TabStop = false;

            this.lblC4Val.AutoSize = true;
            this.lblC4Val.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblC4Val.ForeColor = System.Drawing.Color.White;
            this.lblC4Val.Location = new System.Drawing.Point(10, 50);
            this.lblC4Val.Text = "0";

            this.lblC4Title.AutoSize = true;
            this.lblC4Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblC4Title.Location = new System.Drawing.Point(10, 15);
            this.lblC4Title.Text = "KHÁCH HÀNG";

            // Chart
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.None;
            this.chartRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(30, 230);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(895, 250);
            this.chartRevenue.TabIndex = 8;
            this.chartRevenue.Text = "Biểu đồ doanh thu";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ DOANH THU 7 NGÀY GẦN NHẤT";
            this.chartRevenue.Titles.Add(title1);

            // List Title
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblListTitle.Location = new System.Drawing.Point(30, 500);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Text = "Đơn hàng mới nhất";

            // Table Panel
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.White;
            this.pnlTable.Controls.Add(this.dgvRecent);
            this.pnlTable.Location = new System.Drawing.Point(30, 540);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(895, 180);

            // GridView
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecent.ColumnHeadersHeight = 45;

            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            this.dgvRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colCus, colTotal, colStatus, colTime });
            this.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.RowTemplate.Height = 50;

            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvRecent.DefaultCellStyle = dataGridViewCellStyle2;

            // Columns
            this.colID.HeaderText = "MÃ ĐƠN";
            this.colCus.HeaderText = "KHÁCH HÀNG";
            this.colTotal.HeaderText = "TỔNG TIỀN";
            this.colStatus.HeaderText = "TRẠNG THÁI";
            this.colTime.HeaderText = "THỜI GIAN";

            // Main Layout
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.tlpCards);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCOverview";
            this.Size = new System.Drawing.Size(955, 750);

            this.tlpCards.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRevenue)).EndInit(); // Icon
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPending)).EndInit(); // Icon
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProduct)).EndInit(); // Icon
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCustomer)).EndInit(); // Icon
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tlpCards;

        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblC1Val;
        private System.Windows.Forms.Label lblC1Title;
        private FontAwesome.Sharp.IconPictureBox iconRevenue; // Thay Label bằng IconPictureBox

        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblC2Val;
        private System.Windows.Forms.Label lblC2Title;
        private FontAwesome.Sharp.IconPictureBox iconPending;

        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblC3Val;
        private System.Windows.Forms.Label lblC3Title;
        private FontAwesome.Sharp.IconPictureBox iconProduct;

        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblC4Val;
        private System.Windows.Forms.Label lblC4Title;
        private FontAwesome.Sharp.IconPictureBox iconCustomer;

        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
    }
}