using System;
using System.Drawing; // Thư viện quan trọng để dùng Hình ảnh
using System.Windows.Forms;

namespace SalesProjectApp.Forms.Admin
{
    public partial class UCProduct : UserControl
    {
        public UCProduct()
        {
            InitializeComponent();

            // Gọi hàm nạp dữ liệu giả ngay khi trang được mở
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // 1. Tạo ảnh giả lập (Lấy icon khiên bảo vệ của Windows làm ảnh bánh cho đẹp)
            // Sau này làm thật bạn sẽ dùng Image.FromFile("link_anh.jpg")
            Image imgBanh = SystemIcons.Shield.ToBitmap();
            Image imgNuoc = SystemIcons.Information.ToBitmap();

            // 2. Thêm các dòng dữ liệu vào bảng
            // Thứ tự thêm: Hình ảnh -> Tên Bánh -> Danh Mục -> Giá -> (Nút Sửa tự động có)

            dgvProduct.Rows.Add(imgBanh, "Bánh Mousse Dâu Tây", "Bánh Ngọt", "45.000đ");
            dgvProduct.Rows.Add(imgBanh, "Bánh Mì Bơ Tỏi", "Bánh Mặn", "25.000đ");
            dgvProduct.Rows.Add(imgNuoc, "Trà Đào Cam Sả", "Đồ Uống", "35.000đ");
            dgvProduct.Rows.Add(imgBanh, "Bánh Crepe Sầu Riêng", "Tráng Miệng", "55.000đ");
            dgvProduct.Rows.Add(imgNuoc, "Cafe Sữa Đá", "Đồ Uống", "20.000đ");
            dgvProduct.Rows.Add(imgBanh, "Bánh Tiramisu", "Bánh Ngọt", "40.000đ");
        }

        // Sự kiện khi bấm nút "Thêm món mới"
        // (Đảm bảo bên Designer bạn đã gán sự kiện Click cho nút này, nếu chưa thì code này không chạy cũng không sao)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thêm sản phẩm mới đang xây dựng!", "Thông báo");
        }

        // Sự kiện khi bấm vào nút "Sửa" trên bảng
        // Bạn có thể vào Designer -> Chọn bảng -> Events -> CellContentClick để gán hàm này
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu bấm vào cột nút Sửa (Cột index số 4)
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                string tenMon = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                MessageBox.Show("Bạn đang muốn sửa món: " + tenMon);
            }
        }
    }
}