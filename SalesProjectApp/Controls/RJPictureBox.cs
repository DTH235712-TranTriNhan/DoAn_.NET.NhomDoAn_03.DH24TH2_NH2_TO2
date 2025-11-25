using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SalesProjectApp.Controls
{
    // 1. THÊM TỪ KHÓA 'partial' ĐỂ KHỚP VỚI FILE DESIGNER
    public partial class RJPictureBox : PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        public RJPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public Color BorderColor2 { get => borderColor2; set { borderColor2 = value; this.Invalidate(); } }
        public DashStyle BorderLineStyle { get => borderLineStyle; set { borderLineStyle = value; this.Invalidate(); } }
        public DashCap BorderCapStyle { get => borderCapStyle; set { borderCapStyle = value; this.Invalidate(); } }
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width); // Giữ khung luôn vuông để thành hình tròn
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var graph = pe.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);

            using (var pathRegion = new GraphicsPath())
            {
                pathRegion.AddEllipse(rectContourSmooth);
                this.Region = new Region(pathRegion); // Cắt ảnh thành hình tròn

                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (borderSize > 0)
                {
                    // 2. SỬA LOGIC VẼ VIỀN GRADIENT (Màu chuyển sắc)
                    using (var brush = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
                    using (var penBorder = new Pen(brush, borderSize))
                    {
                        penBorder.DashStyle = borderLineStyle;
                        penBorder.DashCap = borderCapStyle;
                        pathRegion.AddEllipse(rectBorder);
                        graph.DrawPath(penBorder, pathRegion);
                    }
                }
            }
        }
    }
}