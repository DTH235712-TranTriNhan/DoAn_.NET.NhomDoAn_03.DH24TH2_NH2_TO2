using System.Drawing;

namespace SalesProjectApp.Models
{
    public static class AppTheme
    {
        // 1. MÀU CHỦ ĐẠO (Primary Color) - Hồng San Hô hiện đại
        public static Color PrimaryColor = ColorTranslator.FromHtml("#F50057");

        // Màu khi rê chuột vào (Đậm hơn chút)
        public static Color PrimaryHover = ColorTranslator.FromHtml("#C51162");

        // 2. MÀU NỀN & CHỮ
        public static Color BackgroundColor = Color.WhiteSmoke;
        public static Color TextColor = Color.FromArgb(64, 64, 64); // Màu xám đen dịu mắt
        public static Color PlaceholderColor = Color.Gray;

        // 3. FONT CHỮ CHUNG (Nếu muốn đồng bộ font)
        public static Font StandardFont = new Font("Segoe UI", 11, FontStyle.Regular);
    }
}