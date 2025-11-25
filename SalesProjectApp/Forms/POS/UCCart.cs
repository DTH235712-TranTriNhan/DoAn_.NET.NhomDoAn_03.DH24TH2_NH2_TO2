using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesProjectApp.Forms
{
    public partial class UCCart : UserControl
    {
        public UCCart()
        {
            InitializeComponent();

            // --- QUAN TRỌNG: XÓA DÒNG NÀY ĐI NẾU CÓ ---
            // StyleDataGridView();  <-- XÓA DÒNG NÀY
            // ApplyModernStyle();   <-- HOẶC XÓA DÒNG NÀY
        }

        // --- HÀM THÊM MÓN ---
        // Sửa dòng này: thêm int quantity = 1
        public void AddToCart(string name, decimal price, int quantity = 1)
        {
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells[0].Value.ToString() == name)
                {
                    // Cộng thêm số lượng mới vào số lượng cũ
                    int currentQty = int.Parse(row.Cells[1].Value.ToString());
                    int newQty = currentQty + quantity;

                    row.Cells[1].Value = newQty;
                    row.Cells[3].Value = (newQty * price).ToString("N0");
                    UpdateTotal();
                    return;
                }
            }
            // Thêm mới với số lượng đã chọn
            dgvCart.Rows.Add(name, quantity, price.ToString("N0"), (price * quantity).ToString("N0"));
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                string priceStr = row.Cells[3].Value.ToString().Replace(".", "").Replace("đ", "");
                if (decimal.TryParse(priceStr, out decimal p)) total += p;
            }
            lblTotalVal.Text = total.ToString("N0") + "đ";
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4) // Cột Xóa
            {
                dgvCart.Rows.RemoveAt(e.RowIndex);
                UpdateTotal();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0) return;
            MessageBox.Show("Thanh toán thành công: " + lblTotalVal.Text);
            dgvCart.Rows.Clear();
            lblTotalVal.Text = "0đ";
        }

        // NẾU BẠN THẤY HÀM StyleDataGridView() Ở DƯỚI CÙNG -> XÓA LUÔN CẢ HÀM ĐÓ ĐI
    }
}