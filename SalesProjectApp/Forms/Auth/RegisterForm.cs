using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models; // Gọi AppTheme

namespace SalesProjectApp.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        // Biến theo dõi trạng thái ẩn/hiện cho 2 ô mật khẩu
        private bool isPassVisible = false;
        private bool isConfirmVisible = false;

        public RegisterForm()
        {
            InitializeComponent();

            // 1. QUAN TRỌNG: Đưa 2 con mắt lên lớp trên cùng để không bị che
            if (picEyePass != null) picEyePass.BringToFront();
            if (picEyeConfirm != null) picEyeConfirm.BringToFront();

            // 2. Áp dụng giao diện từ AppTheme
            ApplyTheme();

            SetupPlaceholders();

            // Nhấn Enter là bấm nút Đăng ký
            this.AcceptButton = btnRegister;

            // Events
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);
            this.lnkLogin.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkLoginLinkClicked);

            // Gắn sự kiện cho 2 Con mắt
            if (this.picEyePass != null && this.picEyeConfirm != null)
            {
                this.picEyePass.Image = Properties.Resources.AnPW;
                this.picEyeConfirm.Image = Properties.Resources.AnPW;

                this.picEyePass.Click += new EventHandler(this.picEyePass_Click);
                this.picEyeConfirm.Click += new EventHandler(this.picEyeConfirm_Click);
            }

            // --- HIỆU ỨNG HOVER NÚT ĐĂNG KÝ (Giống LoginForm) ---
            this.btnRegister.MouseEnter += (s, e) => {
                this.btnRegister.BackColor = AppTheme.PrimaryHover;
            };
            this.btnRegister.MouseLeave += (s, e) => {
                this.btnRegister.BackColor = AppTheme.PrimaryColor;
            };
        }

        // --- HÀM ÁP DỤNG THEME ---
        private void ApplyTheme()
        {
            // Màu nền form
            this.BackColor = AppTheme.BackgroundColor;

            // Tiêu đề & Link
            lblTitle.ForeColor = AppTheme.PrimaryColor;
            lnkLogin.LinkColor = AppTheme.PrimaryColor;

            // Nút đăng ký
            btnRegister.BackColor = AppTheme.PrimaryColor;
            btnRegister.ForeColor = Color.White;
        }

        // --- CÁC SỰ KIỆN LOGIC GIỮ NGUYÊN ---

        private void picEyePass_Click(object sender, EventArgs e)
        {
            isPassVisible = !isPassVisible;
            TogglePasswordVisibility(txtPassword, picEyePass, isPassVisible, "Mật khẩu");
        }

        private void picEyeConfirm_Click(object sender, EventArgs e)
        {
            isConfirmVisible = !isConfirmVisible;
            TogglePasswordVisibility(txtConfirmPassword, picEyeConfirm, isConfirmVisible, "Nhập lại mật khẩu");
        }

        // Hàm chung để xử lý ẩn hiện password gọn hơn
        private void TogglePasswordVisibility(TextBox txt, PictureBox pic, bool isVisible, string placeholder)
        {
            if (isVisible)
            {
                txt.UseSystemPasswordChar = false;
                pic.Image = Properties.Resources.XemPW;
            }
            else
            {
                // Chỉ ẩn password nếu text không phải là placeholder
                if (txt.Text != placeholder) txt.UseSystemPasswordChar = true;
                pic.Image = Properties.Resources.AnPW;
            }
        }

        private void SetupPlaceholders()
        {
            SetPlaceholder(txtName, "Họ và tên");
            SetPlaceholder(txtEmail, "Tên đăng nhập ");

            // Cần hàm riêng cho password
            SetPlaceholderPassword(txtPassword, "Mật khẩu", () => isPassVisible);
            SetPlaceholderPassword(txtConfirmPassword, "Nhập lại mật khẩu", () => isConfirmVisible);
        }

        private void SetPlaceholder(TextBox txt, string placeholderText)
        {
            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = AppTheme.TextColor; // Dùng màu AppTheme
                }
            };
            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = AppTheme.PlaceholderColor; // Dùng màu AppTheme
                }
            };
        }

        private void SetPlaceholderPassword(TextBox txt, string placeholderText, Func<bool> getVisibleState)
        {
            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = AppTheme.TextColor; // Dùng màu AppTheme
                    if (!getVisibleState()) txt.UseSystemPasswordChar = true;
                }
            };
            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = AppTheme.PlaceholderColor; // Dùng màu AppTheme
                    txt.UseSystemPasswordChar = false;
                }
            };
        }

        private void lnkLoginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim();
            string username = txtEmail.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            // Validate
            if (fullName == "Họ và tên" || string.IsNullOrEmpty(fullName) ||
                username == "Tên đăng nhập " || string.IsNullOrEmpty(username) ||
                pass == "Mật khẩu" || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    if (db.users.Any(u => u.username == username))
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    user newUser = new user();
                    newUser.username = username;
                    newUser.password = pass; // Lưu ý: Thực tế nên mã hóa MD5/BCrypt trước khi lưu
                    newUser.full_name = fullName;
                    newUser.role = "user";
                    newUser.created_at = DateTime.Now;
                    if (username.Contains("@")) newUser.email = username;

                    db.users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}