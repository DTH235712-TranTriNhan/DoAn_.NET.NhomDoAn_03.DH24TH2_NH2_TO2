using System;
using System.Threading.Tasks;

namespace SalesProjectApp.Models
{
    public static class LogHelper
    {
        // Hàm ghi log (Chạy bất đồng bộ để không làm đơ ứng dụng)
        public static void Write(string actionType, string description)
        {
            Task.Run(() =>
            {
                try
                {
                    using (var db = new SalesProjectNetDBEntities())
                    {
                        var log = new system_logs();

                        // Lấy ID người đang đăng nhập (Nếu chưa đăng nhập thì để null)
                        if (Session.CurrentUser != null)
                        {
                            log.user_id = Session.CurrentUser.id;
                        }

                        log.action_type = actionType;
                        log.description = description;
                        log.created_at = DateTime.Now;

                        db.system_logs.Add(log);
                        db.SaveChanges();
                    }
                }
                catch
                {
                    // Lỗi ghi log thì bỏ qua, không làm crash app
                }
            });
        }
    }
}