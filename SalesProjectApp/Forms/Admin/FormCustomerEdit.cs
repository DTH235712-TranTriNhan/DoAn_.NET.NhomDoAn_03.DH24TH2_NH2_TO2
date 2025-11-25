using System;
using System.Linq;
using System.Windows.Forms;
using SalesProjectApp.Models;

namespace SalesProjectApp.Forms.Admin
{
    public partial class FormCustomerEdit : Form
    {
        private int _userId; // ID của khách hàng đang sửa

        public FormCustomerEdit(int userId)
        {
            InitializeComponent();
            _userId = userId;

            // Nếu có ID > 0 thì tự động nạp dữ liệu cũ lên để sửa
            if (_userId > 0)
            {
                LoadCustomerData();
            }
        }

        private void LoadCustomerData()
        {
            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var user = db.users.Find(_userId);
                    if (user != null)
                    {
                        lblHeader.Text = $"CHỈNH SỬA KHÁCH HÀNG: {user.username}";
                        txtFullName.Text = user.full_name;
                        txtEmail.Text = user.email;
                        txtPhone.Text = user.phone_number;

                        // Lưu ý: Database của bạn chưa có cột 'address' trong bảng 'users'
                        // Nên mình tạm thời chưa load địa chỉ vào đây nhé.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Cảnh báo");
                return;
            }

            try
            {
                using (var db = new SalesProjectNetDBEntities())
                {
                    var user = db.users.Find(_userId);
                    if (user != null)
                    {
                        user.full_name = txtFullName.Text.Trim();
                        user.email = txtEmail.Text.Trim();
                        user.phone_number = txtPhone.Text.Trim();

                        // Nếu sau này bạn thêm cột Address vào DB thì mở comment dòng dưới ra:
                        // user.address = txtAddress.Text.Trim();

                        db.SaveChanges(); // Lưu xuống DB
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
                        this.Close(); // Đóng form
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng này!", "Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}