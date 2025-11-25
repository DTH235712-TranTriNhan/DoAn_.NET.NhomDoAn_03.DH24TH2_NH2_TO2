using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCCustomer : UserControl
    {
        public UCCustomer()
        {
            InitializeComponent();
            LoadSampleData(); // Nạp dữ liệu giả
        }

        private void LoadSampleData()
        {
            // Thêm dữ liệu mẫu vào bảng Khách hàng
            // Cột: Mã KH | Họ Tên | SĐT | Email | Địa Chỉ | Nút Sửa

            dgvCustomer.Rows.Add("KH001", "Nguyễn Văn An", "0909123456", "an.nguyen@gmail.com", "Q.1, TP.HCM");
            dgvCustomer.Rows.Add("KH002", "Trần Thị Bích", "0912345678", "bich.tran@yahoo.com", "Q.3, TP.HCM");
            dgvCustomer.Rows.Add("KH003", "Lê Hoàng Nam", "0987654321", "nam.le@outlook.com", "Q.Bình Thạnh, TP.HCM");
            dgvCustomer.Rows.Add("KH004", "Phạm Thu Hà", "0368889999", "thuha.pham@gmail.com", "TP. Thủ Đức");
            dgvCustomer.Rows.Add("KH005", "Hoàng Anh Tuấn", "0933444555", "tuan.hoang@company.vn", "Q.7, TP.HCM");
        }

        // Sự kiện khi bấm nút "Sửa" trong bảng
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5) // Cột nút bấm là cột số 5
            {
                string tenKhach = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                MessageBox.Show("Sửa thông tin khách hàng: " + tenKhach);
            }
        }
    }
}