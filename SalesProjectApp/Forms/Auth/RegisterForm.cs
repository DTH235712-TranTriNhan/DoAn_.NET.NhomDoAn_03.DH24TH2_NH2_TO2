using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        Color placeholderColor = Color.Gray;
        Color inputColor = Color.Black;

        // Biến theo dõi trạng thái ẩn/hiện cho 2 ô mật khẩu
        private bool isPassVisible = false;
        private bool isConfirmVisible = false;

        public RegisterForm()
        {
            InitializeComponent();
            SetupPlaceholders();

            // Nhấn Enter là bấm nút Đăng ký
            this.AcceptButton = btnRegister;

            // Gắn sự kiện Click thủ công
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);
            this.lnkLogin.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkLoginLinkClicked);

            // Gắn sự kiện cho 2 Con mắt (Nếu Designer đã tạo)
            if (this.picEyePass != null && this.picEyeConfirm != null)
            {
                // Mặc định là mắt đóng
                this.picEyePass.Image = Properties.Resources.AnPW;
                this.picEyeConfirm.Image = Properties.Resources.AnPW;

                this.picEyePass.Click += new EventHandler(this.picEyePass_Click);
                this.picEyeConfirm.Click += new EventHandler(this.picEyeConfirm_Click);
            }
        }

        // --- SỰ KIỆN: CON MẮT 1 (MẬT KHẨU) ---
        private void picEyePass_Click(object sender, EventArgs e)
        {
            isPassVisible = !isPassVisible;
            if (isPassVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                picEyePass.Image = Properties.Resources.XemPW;
            }
            else
            {
                if (txtPassword.Text != "Mật khẩu") txtPassword.UseSystemPasswordChar = true;
                picEyePass.Image = Properties.Resources.AnPW;
            }
        }

        // --- SỰ KIỆN: CON MẮT 2 (NHẬP LẠI MẬT KHẨU) ---
        private void picEyeConfirm_Click(object sender, EventArgs e)
        {
            isConfirmVisible = !isConfirmVisible;
            if (isConfirmVisible)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                picEyeConfirm.Image = Properties.Resources.XemPW;
            }
            else
            {
                if (txtConfirmPassword.Text != "Nhập lại mật khẩu") txtConfirmPassword.UseSystemPasswordChar = true;
                picEyeConfirm.Image = Properties.Resources.AnPW;
            }
        }

        // --- CẤU HÌNH PLACEHOLDER ---
        private void SetupPlaceholders()
        {
            SetPlaceholder(txtName, "Họ và tên");
            SetPlaceholder(txtEmail, "Tên đăng nhập ");

            // Cần hàm riêng cho từng ô Password để check biến visible riêng
            SetPlaceholderPassword(txtPassword, "Mật khẩu", () => isPassVisible);
            SetPlaceholderPassword(txtConfirmPassword, "Nhập lại mật khẩu", () => isConfirmVisible);
        }

        private void SetPlaceholder(TextBox txt, string placeholderText)
        {
            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = inputColor;
                }
            };
            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = placeholderColor;
                }
            };
        }

        // Hàm xử lý placeholder cho mật khẩu (nhận vào biến trạng thái tương ứng)
        private void SetPlaceholderPassword(TextBox txt, string placeholderText, Func<bool> getVisibleState)
        {
            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = inputColor;
                    // Nếu mắt đang đóng thì mới hiện dấu chấm
                    if (!getVisibleState()) txt.UseSystemPasswordChar = true;
                }
            };
            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = placeholderColor;
                    txt.UseSystemPasswordChar = false;
                }
            };
        }

        // --- LOGIC CHUYỂN TRANG ---
        private void lnkLoginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng form đăng ký đi
        }

        // --- LOGIC ĐĂNG KÝ ---
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim();
            string username = txtEmail.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            // Validate
            if (fullName == "Họ và tên" || username == "Tên đăng nhập " ||
                pass == "Mật khẩu" || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
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
                    newUser.password = pass;
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