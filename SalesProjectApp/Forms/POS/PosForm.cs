using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SalesProjectApp.Forms
{
    public partial class PosForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
            public Image Img { get; set; }
            public string Description { get; set; }
        }

        List<Product> allProducts = new List<Product>();
        private UCCart ucCart; // Giỏ hàng

        public PosForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            pnlRight.Visible = false;
            // Thêm UCCart vào cột phải
            ucCart = new UCCart();
            ucCart.Dock = DockStyle.Fill;
            ucCart.BackColor = Color.White;
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(ucCart);

            InitData();
            LoadCategoryTabs();
            LoadMenu("Tất cả");
        }

        // --- HÀM TẠO THẺ SẢN PHẨM ---
        private void CreateProductCard(Product p)
        {
            // TÍNH TOÁN ĐỂ CHIA 3 CỘT
            int totalOccupied = 160 + 400 ; // Cột trái + Cột phải + Scrollbar
            int availableWidth = Screen.PrimaryScreen.Bounds.Width - totalOccupied;

            // Chia 3, trừ đi margin của mỗi thẻ
            int cardWidth = (availableWidth / 3) - 5;
            int cardHeight = 280;

            // 1. Panel Card
            Panel pnl = new Panel();
            pnl.Size = new Size(cardWidth, cardHeight);
            pnl.BackColor = Color.White;
            pnl.Margin = new Padding(10);
            pnl.Cursor = Cursors.Hand;

            // Bo tròn
            try { pnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cardWidth, cardHeight, 20, 20)); } catch { }

            // --- SỰ KIỆN CLICK ---
            EventHandler clickEvent = (s, e) =>
            {
                // Mở Form chi tiết và truyền p.Description vào
                ProductDetailForm frm = new ProductDetailForm(p.Name, p.Price, p.Img, p.Description);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Thêm vào giỏ
                    ucCart.AddToCart(p.Name, p.Price, frm.SelectedQty);

                    // Hiệu ứng nút
                    btnCart.Text = "🛒 Đã thêm!";
                    btnCart.BackColor = Color.LimeGreen;
                    Timer t = new Timer { Interval = 500 };
                    t.Tick += (ss, ee) => {
                        btnCart.Text = "🛒 Giỏ Hàng";
                        btnCart.BackColor = Color.FromArgb(233, 30, 99);
                        t.Stop();
                    };
                    t.Start();
                }
            };

            pnl.Click += clickEvent;

            // 2. Hình ảnh
            PictureBox pb = new PictureBox();
            pb.Image = p.Img;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(cardWidth - 40, 150);
            pb.Location = new Point(20, 15);
            pb.Click += clickEvent;

            // 3. Tên món
            Label lblName = new Label();
            lblName.Text = p.Name;
            lblName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(50, 50, 50);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Size = new Size(cardWidth - 20, 50);
            lblName.Location = new Point(10, 170);
            lblName.Click += clickEvent;

            // 4. Giá tiền
            Label lblPrice = new Label();
            lblPrice.Text = p.Price.ToString("N0") + "đ";
            lblPrice.ForeColor = Color.FromArgb(233, 30, 99);
            lblPrice.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Size = new Size(cardWidth - 20, 30);
            lblPrice.Location = new Point(10, 230);
            lblPrice.Click += clickEvent;

            pnl.Controls.Add(pb);
            pnl.Controls.Add(lblName);
            pnl.Controls.Add(lblPrice);
            flpMenu.Controls.Add(pnl);
        }

        // --- CÁC HÀM DỮ LIỆU ---
        private void InitData()
        {
            Image img = SystemIcons.Application.ToBitmap();
            // Thêm description vào
            allProducts.Add(new Product { Name = "Cafe Đen", Price = 25000, Category = "Cafe", Img = img, Description = "Cafe nguyên chất đậm đà" });
            allProducts.Add(new Product { Name = "Cafe Sữa", Price = 30000, Category = "Cafe", Img = img, Description = "Cafe pha sữa đặc ngọt ngào" });
            allProducts.Add(new Product { Name = "Bạc Xỉu", Price = 35000, Category = "Cafe", Img = img, Description = "Nhiều sữa ít cafe" });
            allProducts.Add(new Product { Name = "Trà Đào", Price = 40000, Category = "Trà", Img = img, Description = "Trà đào cam sả mát lạnh" });
            allProducts.Add(new Product { Name = "Trà Vải", Price = 45000, Category = "Trà", Img = img, Description = "Trà vải nhiệt đới tươi mát" });
            allProducts.Add(new Product { Name = "Tiramisu", Price = 45000, Category = "Bánh", Img = img, Description = "Bánh ngọt vị cafe Ý" });
        }

        private void LoadCategoryTabs()
        {
            flpCategory.Controls.Clear();
            var categories = new List<string> { "Tất cả" };
            categories.AddRange(allProducts.Select(p => p.Category).Distinct());

            foreach (var cat in categories)
            {
                // SỬA LỖI CHÍNH TẢ Ở ĐÂY: FlatAppearance (chứ không phải Flattenace)
                Button btn = new Button
                {
                    Text = cat,
                    Size = new Size(140, 50),
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 }, // <--- ĐÃ SỬA
                    Font = new Font("Segoe UI", 11),
                    Cursor = Cursors.Hand,
                    Margin = new Padding(0, 0, 0, 5)
                };

                if (cat == "Tất cả") { btn.BackColor = Color.FromArgb(233, 30, 99); btn.ForeColor = Color.White; }
                else { btn.BackColor = Color.White; btn.ForeColor = Color.Black; }

                btn.Click += (s, e) => {
                    foreach (Control c in flpCategory.Controls) { c.BackColor = Color.White; c.ForeColor = Color.Black; }
                    btn.BackColor = Color.FromArgb(233, 30, 99); btn.ForeColor = Color.White;
                    LoadMenu(cat);
                };
                flpCategory.Controls.Add(btn);
            }
        }

        private void LoadMenu(string category)
        {
            flpMenu.Controls.Clear();
            var list = (category == "Tất cả") ? allProducts : allProducts.Where(p => p.Category == category).ToList();
            foreach (var p in list) CreateProductCard(p);
        }

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }
        private void btnCart_Click(object sender, EventArgs e) { pnlRight.Visible = !pnlRight.Visible; }
    }
}