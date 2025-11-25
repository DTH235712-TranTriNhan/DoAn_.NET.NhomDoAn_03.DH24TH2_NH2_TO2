using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SalesProjectApp.Controls
{
    public class RJButton : Button
    {
        // Các thông số có thể chỉnh trong bảng Properties
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        [Category("RJ Code Advance")]
        public int BorderSize { get => borderSize; set { borderSize = value; Invalidate(); } }

        [Category("RJ Code Advance")]
        public int BorderRadius { get => borderRadius; set { borderRadius = value; Invalidate(); } }

        [Category("RJ Code Advance")]
        public Color BorderColor { get => borderColor; set { borderColor = value; Invalidate(); } }

        [Category("RJ Code Advance")]
        public Color BackgroundColor { get => this.BackColor; set { this.BackColor = value; } }

        [Category("RJ Code Advance")]
        public Color TextColor { get => this.ForeColor; set { this.ForeColor = value; } }

        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand; // Di chuột vào hiện bàn tay
        }

        // Code vẽ hình dáng nút bo tròn
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            if (borderRadius > 2) // Nút bo tròn
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1f))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    // Vẽ viền bề mặt để khử răng cưa với màu nền cha
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Vẽ viền nút nếu có
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Nút vuông bình thường
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) this.Invalidate();
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}