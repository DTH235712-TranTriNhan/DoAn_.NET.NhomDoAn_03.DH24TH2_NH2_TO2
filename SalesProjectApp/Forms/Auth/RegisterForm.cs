using System;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private Form loginForm;

        public RegisterForm(Form loginForm = null)
        {
            InitializeComponent();
            this.AcceptButton = btnRegister;
            this.loginForm = loginForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (name == "Họ và tên" || username == "Tên đăng nhập" ||
                password == "Mật khẩu" || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi");
                return;
            }

            using (var db = new SalesProjectNetDBEntities())
            {
                if (db.users.Any(u => u.username == username))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi");
                    return;
                }

                var newUser = new user
                {
                    full_name = name,
                    username = username,
                    password = password,
                    role = "user",
                    created_at = DateTime.Now
                };

                db.users.Add(newUser);
                db.SaveChanges();
            }

            MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Thành công");
            this.Close();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng register
            loginForm?.Show(); // Hiện lại login nếu truyền
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm?.Show();
        }
    }
}
