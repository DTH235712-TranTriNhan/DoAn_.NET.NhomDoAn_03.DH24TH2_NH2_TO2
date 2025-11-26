using System;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.AcceptButton = btnRegister;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string u = txtUser.Text.Trim();
            string p = txtPass.Text.Trim();
            string pc = txtConfirm.Text.Trim();

            // Validate
            if (name == "Họ và tên" || u == "Tên đăng nhập" || p == "Mật khẩu" || string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
                return;
            }
            if (p != pc)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi");
                return;
            }

            using (var db = new SalesProjectNetDBEntities())
            {
                if (db.users.Any(x => x.username == u))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi");
                    return;
                }

                var newUser = new user
                {
                    username = u,
                    password = p,
                    full_name = name,
                    role = "user",
                    created_at = DateTime.Now
                };

                db.users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Chúc mừng");
                this.Close(); // Đóng form này để quay lại Login
            }
        }
    }
}