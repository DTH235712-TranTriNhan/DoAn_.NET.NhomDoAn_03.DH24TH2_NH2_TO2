using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SalesProjectApp.Forms
{
    public partial class UCBanner : UserControl
    {
        public UCBanner()
        {
            InitializeComponent();
        }

        // Vẽ nền Gradient cho đẹp (Giống hình mẫu nền xám khói)
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.White, Color.FromArgb(240, 240, 240), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}