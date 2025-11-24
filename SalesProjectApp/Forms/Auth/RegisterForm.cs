using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesProjectApp.Forms.Auth
{
    public partial class Register : Form
    {
        // Khai báo màu sắc cho đẹp
        Color placeholderColor = Color.Gray;
        Color inputColor = Color.Black;

        public Register()
        {
            InitializeComponent();
            SetupPlaceholders(); // Gọi hàm thiết lập khi mở form;\
            this.lnkLogin.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);
        }

        // Hàm này dùng để gán sự kiện cho các ô nhập
        private void SetupPlaceholders()
        {
            // 1. Cài đặt cho ô HỌ TÊN
            SetPlaceholder(txtName, "Họ và tên");

            // 2. Cài đặt cho ô EMAIL
            SetPlaceholder(txtEmail, "Email hoặc SĐT");

            // 3. Cài đặt cho ô MẬT KHẨU (Xử lý đặc biệt vì có dấu *)
            SetPlaceholderPassword(txtPassword, "Mật khẩu");

            // 4. Cài đặt cho ô NHẬP LẠI MẬT KHẨU
            SetPlaceholderPassword(txtConfirmPassword, "Nhập lại mật khẩu");
        }

        // --- LOGIC XỬ LÝ CHO Ô THƯỜNG (Tên, Email) ---
        private void SetPlaceholder(TextBox txt, string placeholderText)
        {
            txt.Text = placeholderText;
            txt.ForeColor = placeholderColor;

            // Sự kiện khi bấm chuột VÀO (Enter)
            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = inputColor;
                }
            };

            // Sự kiện khi bấm chuột RA (Leave)
            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = placeholderColor;
                }
            };
        }

        // --- LOGIC XỬ LÝ RIÊNG CHO Ô MẬT KHẨU (Ẩn hiện dấu *) ---
        private void SetPlaceholderPassword(TextBox txt, string placeholderText)
        {
            txt.Text = placeholderText;
            txt.ForeColor = placeholderColor;
            txt.UseSystemPasswordChar = false; // Lúc đầu hiện chữ "Mật khẩu" thì không che

            // Khi bấm VÀO
            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = inputColor;
                    txt.UseSystemPasswordChar = true; // Bắt đầu nhập thì bật chế độ che mật khẩu (*)
                }
            };

            // Khi bấm RA
            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = placeholderColor;
                    txt.UseSystemPasswordChar = false; // Hiện lại chữ gợi ý thì tắt che đi
                }
            };
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1.Mở lại form Đăng nhập
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // 2. Đóng form Đăng ký hiện tại đi cho nhẹ máy
            this.Close();
        }
    }
}
