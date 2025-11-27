using System;

namespace SalesProjectApp.Models
{
    public static class GlobalEvents
    {
        // 1. Định nghĩa sự kiện "Danh mục đã thay đổi"
        public static event EventHandler OnCategoryUpdated;

        // 2. Hàm để kích hoạt sự kiện (Bấm nút phát loa)
        public static void RaiseCategoryUpdated()
        {
            // Kiểm tra xem có ai đang nghe không, nếu có thì báo
            OnCategoryUpdated?.Invoke(null, EventArgs.Empty);
        }
    }
}