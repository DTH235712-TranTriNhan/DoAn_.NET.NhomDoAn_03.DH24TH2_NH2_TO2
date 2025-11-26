using System;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin; // Enter = Login
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = txtUser.Text.Trim();
            string p = txtPass.Text.Trim();

            if (u == "Tên đăng nhập" || p == "Mật khẩu" || string.IsNullOrEmpty(u))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo");
                return;
            }

            using (var db = new SalesProjectNetDBEntities())
            {
                var user = db.users.FirstOrDefault(x => (x.username == u || x.email == u) && x.password == p);

                if (user != null)
                {
                    Session.CurrentUser = user;
                    LogHelper.Write("LOGIN", $"User {u} đã đăng nhập.");

                    this.DialogResult = DialogResult.OK; // Báo cho PosForm biết là OK
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- CHUYỂN SANG FORM ĐĂNG KÝ ---
        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog(); // Hiện form đăng ký (Modal)
        }
    }
}