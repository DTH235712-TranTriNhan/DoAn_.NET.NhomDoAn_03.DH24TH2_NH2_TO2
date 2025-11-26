using System;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms
{
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (Session.CurrentUser != null)
            {
                txtUsername.Text = Session.CurrentUser.username;
                txtFullName.Text = Session.CurrentUser.full_name;
                txtPhone.Text = Session.CurrentUser.phone_number;
                txtEmail.Text = Session.CurrentUser.email;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var user = db.users.Find(Session.CurrentUser.id);
                    if (user != null)
                    {
                        user.full_name = txtFullName.Text.Trim();
                        user.phone_number = txtPhone.Text.Trim();
                        user.email = txtEmail.Text.Trim();

                        // Đổi mật khẩu (nếu có nhập)
                        if (!string.IsNullOrEmpty(txtNewPass.Text))
                        {
                            user.password = txtNewPass.Text.Trim();
                        }

                        db.SaveChanges();

                        // Cập nhật lại Session
                        Session.CurrentUser = user;

                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) { this.Close(); }
    }
}