using SalesProjectApp.Models;
using SalesProjectApp.Controls;
using SalesProjectApp.Forms.Auth;
using SalesProjectApp.Forms.Admin; // Để gọi AdminDashboard
using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

// --- FIX LỖI AMBIGUOUS REFERENCE (QUAN TRỌNG) ---
using Label = System.Windows.Forms.Label;
using Image = System.Drawing.Image;
using Control = System.Windows.Forms.Control;
using Panel = System.Windows.Forms.Panel;
using Button = System.Windows.Forms.Button;
// ------------------------------------------------

namespace SalesProjectApp.Forms
{
    public partial class PosForm : Form
    {
        // API Bo tròn góc
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // API Placeholder cho ô tìm kiếm
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        // Class nội bộ lưu thông tin sản phẩm
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
            public Image Img { get; set; }
            public string Description { get; set; }
        }

        List<Product> allProducts = new List<Product>();
        private UCCart ucCart;
        private string _currentCategory = "Tất cả";
        private int _totalItemsInCart = 0;

        public PosForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Cấu hình giao diện ban đầu
            pnlRight.Visible = false; // Ẩn giỏ hàng
            txtSearch.Visible = false; // Ẩn ô tìm kiếm
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Tìm bánh, đồ uống..."); // Placeholder

            // Khởi tạo Giỏ hàng (UserControl)
            ucCart = new UCCart();
            ucCart.Dock = DockStyle.Fill;
            ucCart.OnCartUpdated += (total) => { btnCart.Text = $"Giỏ hàng ({total})"; };
            ucCart.OnCheckoutCompleted += (s, e) => { pnlRight.Visible = false; };
            ucCart.BackColor = Color.White;
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(ucCart);

            // Mặc định ẩn Lịch sử đơn, hiện Menu
            ucOrderHistory.Visible = false;
            flpMenu.Visible = true;
            ucBanner.Visible = true;
            flpCategory.Visible = true;

            // Sự kiện tìm kiếm
            txtSearch.TextChanged += (s, e) => LoadMenu(_currentCategory);

            // Sự kiện Resize để tính lại cột sản phẩm khi phóng to/thu nhỏ
            this.Resize += (s, e) => FixHeaderLayout();

            this.Load += new EventHandler(PosForm_Load);
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            LoadProductsFromDB();
            LoadCategoryTabs();
            LoadMenu("Tất cả");
            UpdateUserInterface(); // Cập nhật nút Login/Profile
            FixHeaderLayout();
        }

        // --- 1. XỬ LÝ NGƯỜI DÙNG (ĐĂNG NHẬP / PROFILE) ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                // Chưa đăng nhập -> Mở form Login
                LoginForm login = new LoginForm();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    UpdateUserInterface();
                }
            }
            else
            {
                // Đã đăng nhập -> Hiện Menu ngữ cảnh
                cmsUser.Show(btnLogin, new Point(0, btnLogin.Height));
            }
        }

        // Sự kiện nút Profile trong Sidebar
        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                LoginForm login = new LoginForm();
                if (login.ShowDialog() == DialogResult.OK) UpdateUserInterface();
            }
            else
            {
                // Mở form thông tin cá nhân
                FormUserProfile frm = new FormUserProfile();
                frm.ShowDialog();
                UpdateUserInterface();
            }
        }

        private void UpdateUserInterface()
        {
            if (Session.CurrentUser != null)
            {
                // Cập nhật nút Login thành Avatar User (Màu xanh)
                btnLogin.Image = IconChar.UserCheck.ToBitmap(Color.LimeGreen, 24);

                // Cập nhật nút Profile trong Sidebar
                if (btnProfile != null)
                {
                    btnProfile.Text = "👤 " + Session.CurrentUser.full_name;
                    btnProfile.ForeColor = Color.White;
                }

                // Cập nhật Menu ngữ cảnh
                tsmiInfo.Text = $"Xin chào, {Session.CurrentUser.full_name}";
                tsmiAdmin.Visible = (Session.CurrentUser.role == "admin"); // Chỉ hiện nút Quản lý nếu là Admin
            }
            else
            {
                // Trạng thái chưa đăng nhập
                btnLogin.Image = IconChar.User.ToBitmap(Color.Gray, 24);
                if (btnProfile != null)
                {
                    btnProfile.Text = "👤 Cá nhân";
                    btnProfile.ForeColor = Color.Silver;
                }
                tsmiInfo.Text = "Khách vãng lai";
                tsmiAdmin.Visible = false;
            }
        }

        // Vào trang Admin Dashboard
        private void tsmiAdmin_Click(object sender, EventArgs e)
        {
            AdminDashboardForm admin = new AdminDashboardForm();
            this.Hide();
            admin.ShowDialog();
            this.Show(); // Hiện lại POS sau khi đóng Admin
        }

        // Đăng xuất
        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Session.CurrentUser = null;
                    UpdateUserInterface();
                    MessageBox.Show("Đã đăng xuất!", "Thông báo");

                    // Reset về trang chủ
                    btnMenu_Click(null, null);
                }
            }
        }

        // --- 2. XỬ LÝ ĐỒNG HỒ ---
        private void timerClock_Tick(object sender, EventArgs e)
        {
            if (lblClock != null)
            {
                lblClock.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            }
        }

        // --- 3. XỬ LÝ DANH MỤC ---
        private void LoadCategoryTabs()
        {
            flpCategory.Controls.Clear();
            var categories = new List<string> { "Tất cả" };
            categories.AddRange(allProducts.Select(p => p.Category).Distinct());

            foreach (var cat in categories)
            {
                RJButton btn = new RJButton
                {
                    Text = cat,
                    Size = new Size(160, 50),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Margin = new Padding(10, 0, 0, 10),
                    BorderRadius = 20,
                    BorderSize = 0
                };

                if (cat == "Tất cả") { btn.BackColor = Color.Black; btn.ForeColor = Color.White; }
                else { btn.BackColor = Color.White; btn.ForeColor = Color.DimGray; }

                btn.Click += (s, e) =>
                {
                    foreach (Control c in flpCategory.Controls)
                        if (c is RJButton b) { b.BackColor = Color.White; b.ForeColor = Color.DimGray; }

                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;

                    _currentCategory = cat;
                    LoadMenu(cat);
                };

                flpCategory.Controls.Add(btn);
            }
        }

        // --- 4. XỬ LÝ MENU & TÌM KIẾM ---
        private void LoadMenu(string category)
        {
            flpMenu.Controls.Clear();

            var list = (category == "Tất cả") ? allProducts : allProducts.Where(p => p.Category == category).ToList();

            string keyword = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(p => p.Name.ToLower().Contains(keyword)).ToList();
            }

            foreach (var p in list) CreateProductCard(p);
        }

        private void CreateProductCard(Product p)
        {
            // Tính toán Responsive dựa trên pnlMainContainer
            int containerWidth = pnlMainContainer.Width;
            if (containerWidth == 0) containerWidth = Screen.PrimaryScreen.Bounds.Width;

            int scrollBarWidth = SystemInformation.VerticalScrollBarWidth;
            int availableWidth = containerWidth - scrollBarWidth - 60;

            int colCount = 3;
            if (availableWidth > 1400) colCount = 5;
            else if (availableWidth > 1100) colCount = 4;

            int cardWidth = (availableWidth / colCount) - 15;
            int cardHeight = 280;

            Panel pnl = new Panel();
            pnl.Size = new Size(cardWidth, cardHeight);
            pnl.BackColor = Color.White;
            pnl.Margin = new Padding(7);
            pnl.Cursor = Cursors.Hand;

            pnl.Paint += (s, e) => {
                ControlPaint.DrawBorder(e.Graphics, pnl.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
            };
            try { pnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cardWidth, cardHeight, 15, 15)); } catch { }

            // Sự kiện Click -> Mở chi tiết
            EventHandler clickEvent = (s, e) =>
            {
                ProductDetailForm frm = new ProductDetailForm(p.Name, p.Price, p.Img, p.Description);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ucCart.AddToCart(p.Name, p.Price, frm.SelectedQty, frm.Note);
                    UpdateCartCount(frm.SelectedQty);
                }
            };
            pnl.Click += clickEvent;

            // Ảnh
            PictureBox pb = new PictureBox();
            pb.Image = p.Img;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(cardWidth - 20, 150);
            pb.Location = new Point(10, 10);
            pb.Click += clickEvent;

            // Tên
            Label lblName = new Label();
            lblName.Text = p.Name;
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(64, 64, 64);
            lblName.TextAlign = ContentAlignment.TopCenter;
            lblName.Size = new Size(cardWidth - 10, 50);
            lblName.Location = new Point(5, 165);
            lblName.Click += clickEvent;

            // Giá
            Label lblPrice = new Label();
            lblPrice.Text = p.Price.ToString("N0") + "đ";
            lblPrice.ForeColor = Color.FromArgb(233, 30, 99);
            lblPrice.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Size = new Size(cardWidth - 10, 30);
            lblPrice.Location = new Point(5, 220);
            lblPrice.Click += clickEvent;

            pnl.Controls.Add(pb);
            pnl.Controls.Add(lblName);
            pnl.Controls.Add(lblPrice);

            flpMenu.Controls.Add(pnl);
        }

        // --- 5. CẬP NHẬT GIỎ HÀNG ---
        private void UpdateCartCount(int quantityToAdd)
        {
            _totalItemsInCart += quantityToAdd;
            btnCart.Text = $"   Giỏ hàng ({_totalItemsInCart})";
            btnCart.BackColor = Color.LimeGreen;
            Timer t = new Timer { Interval = 300 };
            t.Tick += (ss, ee) => {
                btnCart.BackColor = Color.FromArgb(233, 30, 99);
                t.Stop();
            };
            t.Start();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            pnlRight.Visible = !pnlRight.Visible;
            LoadMenu(_currentCategory); // Resize lại lưới sản phẩm
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = !txtSearch.Visible;
            if (txtSearch.Visible) txtSearch.Focus();
            else { txtSearch.Text = ""; LoadMenu(_currentCategory); }
        }

        // --- CÁC HÀM HỖ TRỢ ---
        private Image LoadImageSafe(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return SystemIcons.Application.ToBitmap();
            try { using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read)) { return Image.FromStream(fs); } }
            catch { return SystemIcons.Application.ToBitmap(); }
        }

        private void LoadProductsFromDB()
        {
            using (var db = new SalesProjectNetDBEntities())
            {
                var productDataFromDb = db.products.Where(p => p.is_active == true)
                    .Select(p => new {
                        Name = p.name,
                        Price = p.price,
                        CategoryName = p.category != null ? p.category.name : "Khác",
                        Description = p.description,
                        ImagePath = p.image
                    }).ToList();

                allProducts = productDataFromDb.Select(p => new Product
                {
                    Name = p.Name,
                    Price = p.Price,
                    Category = p.CategoryName,
                    Description = p.Description,
                    Img = LoadImageSafe(p.ImagePath)
                }).ToList();
            }
        }

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }

        // Navigation Sidebar
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ucOrderHistory.Visible = false;
            flpMenu.Visible = true;
            flpCategory.Visible = true;
            ucBanner.Visible = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null) { MessageBox.Show("Vui lòng đăng nhập!"); return; }

            // Ẩn Menu, Hiện Lịch sử
            flpMenu.Visible = false;
            flpCategory.Visible = false;
            ucBanner.Visible = false;

            ucOrderHistory.Visible = true;
            ucOrderHistory.LoadHistory();
            ucOrderHistory.BringToFront();
        }
        private void FixHeaderLayout()
        {
            int rightMargin = 20;
            int spacing = 10;

            // EXIT
            btnExit.Location = new Point(
                pnlHeader.Width - btnExit.Width - rightMargin,
                12);

            // CART
            btnCart.Location = new Point(
                btnExit.Left - btnCart.Width - spacing,
                12);

            // LOGIN
            btnLogin.Location = new Point(
                btnCart.Left - btnLogin.Width - spacing,
                12);

            // SEARCH
            btnSearch.Location = new Point(
                btnLogin.Left - btnSearch.Width - spacing,
                12);

            // SEARCH BOX
            txtSearch.Width = 250;
            txtSearch.Location = new Point(
                btnSearch.Left - txtSearch.Width - spacing,
                18);
        }
    }
}