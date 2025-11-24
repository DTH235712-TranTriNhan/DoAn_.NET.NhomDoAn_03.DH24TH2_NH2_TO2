using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models; // Quan trọng: Gọi file AppTheme

namespace SalesProjectApp.Forms.Auth
{
    public partial class LoginForm : Form
    {
        // Không cần khai báo biến màu cứng nữa, dùng trực tiếp từ AppTheme
        private bool isPasswordVisible = false;

        public LoginForm()
        {
            InitializeComponent();

            // 1. ÁP DỤNG MÀU SẮC TỰ ĐỘNG
            ApplyTheme();

            SetupPlaceholders();
            this.AcceptButton = btnLogin;

            // Events
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            this.lnkRegister.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkRegisterLinkClicked);

            // Logic Mắt thần
            if (this.picEye != null)
            {
                this.picEye.Image = Properties.Resources.AnPW;
                this.picEye.Click += new EventHandler(this.picEye_Click);
            }

            // --- HIỆU ỨNG HOVER DÙNG THEME ---
            this.btnLogin.MouseEnter += (s, e) => {
                this.btnLogin.BackColor = AppTheme.PrimaryHover; // Màu đậm khi rê chuột
            };
            this.btnLogin.MouseLeave += (s, e) => {
                this.btnLogin.BackColor = AppTheme.PrimaryColor; // Màu gốc khi rời chuột
            };
        }

        // --- HÀM ÁP DỤNG THEME ---
        private void ApplyTheme()
        {
            this.BackColor = AppTheme.BackgroundColor;

            lblTitle.ForeColor = AppTheme.PrimaryColor;

            btnLogin.BackColor = AppTheme.PrimaryColor;
            btnLogin.ForeColor = Color.White; // Chữ trên nút nên để trắng cho nổi

            lnkRegister.LinkColor = AppTheme.PrimaryColor;
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                picEye.Image = Properties.Resources.XemPW;
            }
            else
            {
                if (txtPassword.Text != "Mật khẩu")
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
                picEye.Image = Properties.Resources.AnPW;
            }
        }

        private void SetupPlaceholders()
        {
            SetPlaceholder(txtUsername, "Tên đăng nhập");
            SetPlaceholderPassword(txtPassword, "Mật khẩu");
        }

        private void SetPlaceholder(TextBox txt, string placeholderText)
        {
            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = AppTheme.TextColor; // Dùng màu Theme
                }
            };
            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = AppTheme.PlaceholderColor; // Dùng màu Theme
                }
            };
        }

        private void SetPlaceholderPassword(TextBox txt, string placeholderText)
        {
            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = AppTheme.TextColor; // Dùng màu Theme
                    if (!isPasswordVisible) txt.UseSystemPasswordChar = true;
                }
            };
            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = AppTheme.PlaceholderColor; // Dùng màu Theme
                    txt.UseSystemPasswordChar = false;
                }
            };
        }

        private void lnkRegisterLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUser = txtUsername.Text.Trim();
            string inputPass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(inputUser) || inputUser == "Tên đăng nhập" ||
                string.IsNullOrEmpty(inputPass) || inputPass == "Mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var user = db.users.FirstOrDefault(u =>
                        (u.username == inputUser || u.email == inputUser)
                        && u.password == inputPass);

                    if (user != null)
                    {
                        Session.CurrentUser = user;
                        MessageBox.Show($"Đăng nhập thành công! Xin chào {user.full_name}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mở form chính (Đã bỏ comment để chạy được)
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}