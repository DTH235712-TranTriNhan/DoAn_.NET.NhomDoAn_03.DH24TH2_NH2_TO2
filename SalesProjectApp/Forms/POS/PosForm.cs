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
            ucCart.BackColor = Color.White;
            pnlRight.Controls.Clear();
            pnlRight.Controls.Add(ucCart);

            // Sự kiện tìm kiếm
            txtSearch.TextChanged += (s, e) => LoadMenu(_currentCategory);

            // Sự kiện Resize để tính lại cột sản phẩm khi phóng to/thu nhỏ
            this.Resize += (s, e) => LoadMenu(_currentCategory);

            this.Load += new EventHandler(PosForm_Load);
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            LoadProductsFromDB();
            LoadCategoryTabs();
            LoadMenu("Tất cả");
            UpdateUserInterface(); // Cập nhật nút Login/Profile
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

        // Sự kiện nút Profile trong Sidebar (nếu có)
        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                LoginForm login = new LoginForm();
                if (login.ShowDialog() == DialogResult.OK) UpdateUserInterface();
            }
            else
            {
                cmsUser.Show(btnProfile, new Point(0, btnProfile.Height));
            }
        }

        private void UpdateUserInterface()
        {
            if (Session.CurrentUser != null)
            {
                // Cập nhật nút Login thành Avatar User (Màu xanh)
                btnLogin.Image = IconChar.UserCheck.ToBitmap(Color.LimeGreen, 24);

                // Cập nhật nút Profile trong Sidebar
                // Kiểm tra null để tránh lỗi nếu nút chưa được khởi tạo
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
                }
            }
        }

        // --- 2. XỬ LÝ ĐỒNG HỒ ---
        // Hàm này để sửa lỗi CS1061 trong Designer
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
            // Lấy danh sách danh mục duy nhất từ list sản phẩm
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

                // Màu sắc: Tất cả (Đen), Khác (Trắng)
                if (cat == "Tất cả") { btn.BackColor = Color.Black; btn.ForeColor = Color.White; }
                else { btn.BackColor = Color.White; btn.ForeColor = Color.DimGray; }

                btn.Click += (s, e) =>
                {
                    // Reset màu các nút khác
                    foreach (Control c in flpCategory.Controls)
                        if (c is RJButton b) { b.BackColor = Color.White; b.ForeColor = Color.DimGray; }

                    // Highlight nút chọn
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

            // Lọc theo danh mục
            var list = (category == "Tất cả") ? allProducts : allProducts.Where(p => p.Category == category).ToList();

            // Lọc theo từ khóa tìm kiếm
            string keyword = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(p => p.Name.ToLower().Contains(keyword)).ToList();
            }

            // Tạo thẻ sản phẩm
            foreach (var p in list) CreateProductCard(p);
        }

        private void CreateProductCard(Product p)
        {
            // Tính toán Responsive (Tự động chia cột)
            // Lấy chiều rộng thực tế của vùng chứa menu
            int containerWidth = flpMenu.ClientSize.Width;
            if (containerWidth == 0) containerWidth = this.Width - 250; // Fallback nếu chưa load xong

            // Trừ padding và scrollbar
            int availableWidth = containerWidth - 40;

            // Logic chia cột: Màn hình to thì 4-5 cột, nhỏ thì 3 cột
            int colCount = 3;
            if (availableWidth > 1200) colCount = 5;
            else if (availableWidth > 900) colCount = 4;

            int cardWidth = (availableWidth / colCount) - 15; // Trừ margin giữa các thẻ
            int cardHeight = 280;

            // Panel Thẻ
            Panel pnl = new Panel();
            pnl.Size = new Size(cardWidth, cardHeight);
            pnl.BackColor = Color.White;
            pnl.Margin = new Padding(7);
            pnl.Cursor = Cursors.Hand;

            // Vẽ viền nhẹ
            pnl.Paint += (s, e) => { ControlPaint.DrawBorder(e.Graphics, pnl.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid); };

            // Bo tròn góc thẻ
            try { pnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cardWidth, cardHeight, 15, 15)); } catch { }

            // Sự kiện Click -> Mở chi tiết
            EventHandler clickEvent = (s, e) =>
            {
                ProductDetailForm frm = new ProductDetailForm(p.Name, p.Price, p.Img, p.Description);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Thêm vào giỏ (Truyền Tên, Giá, SL, Ghi chú)
                    ucCart.AddToCart(p.Name, p.Price, frm.SelectedQty, frm.Note);

                    UpdateCartCount(frm.SelectedQty);
                }
            };

            pnl.Click += clickEvent;

            // Ảnh sản phẩm
            PictureBox pb = new PictureBox();
            pb.Image = p.Img;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(cardWidth - 20, 150);
            pb.Location = new Point(10, 10);
            pb.Click += clickEvent;

            // Tên món
            Label lblName = new Label();
            lblName.Text = p.Name;
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(64, 64, 64);
            lblName.TextAlign = ContentAlignment.TopCenter;
            lblName.Size = new Size(cardWidth - 10, 45);
            lblName.Location = new Point(5, 165);
            lblName.Click += clickEvent;

            // Giá tiền
            Label lblPrice = new Label();
            lblPrice.Text = p.Price.ToString("N0") + "đ";
            lblPrice.ForeColor = Color.FromArgb(233, 30, 99); // Màu hồng
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

            // Hiệu ứng nháy màu xanh lá
            btnCart.BackColor = Color.LimeGreen;
            Timer t = new Timer { Interval = 300 };
            t.Tick += (ss, ee) => {
                btnCart.BackColor = Color.FromArgb(233, 30, 99); // Trả về màu hồng
                t.Stop();
            };
            t.Start();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            pnlRight.Visible = !pnlRight.Visible;
            // Resize lại menu để tính toán lại cột khi panel phải hiện ra/ẩn đi
            LoadMenu(_currentCategory);
        }

        // --- 6. TÌM KIẾM ---
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = !txtSearch.Visible;
            if (txtSearch.Visible) txtSearch.Focus();
            else { txtSearch.Text = ""; LoadMenu(_currentCategory); }
        }

        // --- 7. CÁC HÀM TIỆN ÍCH ---
        private Image LoadImageSafe(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return SystemIcons.Application.ToBitmap();
            try
            {
                // Đọc file vào Memory để không bị khóa file ảnh (File Lock)
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(fs);
                }
            }
            catch { return SystemIcons.Application.ToBitmap(); }
        }

        private void LoadProductsFromDB()
        {
            using (var db = new SalesProjectNetDBEntities())
            {
                // Lấy dữ liệu thô từ DB
                var productDataFromDb = db.products.Where(p => p.is_active == true)
                    .Select(p => new {
                        Name = p.name,
                        Price = p.price,
                        CategoryName = p.category != null ? p.category.name : "Khác",
                        Description = p.description,
                        ImagePath = p.image
                    }).ToList();

                // Chuyển đổi sang List<Product> của Form
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

        // Các nút điều hướng khác
        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }

        // Nếu có nút Menu, History trong Sidebar
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Reset về trang Menu
            if (ucOrderHistory != null) ucOrderHistory.Visible = false;
            flpMenu.Visible = true;
            flpCategory.Visible = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null) { MessageBox.Show("Vui lòng đăng nhập!"); return; }

            if (ucOrderHistory != null)
            {
                ucOrderHistory.Visible = true;
                ucOrderHistory.LoadHistory();
                ucOrderHistory.BringToFront();
            }
        }
    }
}