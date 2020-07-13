using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Assignment_2 {
    public class RoundButton : Button {
        public float Radius { get; set; }

        public RoundButton() {
            Radius = 50;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            RectangleF rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(rect.X + Radius, rect.Y, rect.Width - Radius, rect.Y);
            graphicsPath.AddArc(rect.Width - Radius, rect.Y, Radius, rect.Height, 270, 180);
            graphicsPath.AddLine(rect.Width - Radius, rect.Height, rect.X + Radius, rect.Height);
            graphicsPath.AddArc(rect.X, rect.Y, Radius, rect.Height, 90, 180);
            graphicsPath.CloseFigure();
            Region = new Region(graphicsPath);

            if (FlatAppearance.BorderSize > 0) {
                Pen pen = new Pen(ForeColor, FlatAppearance.BorderSize);
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, graphicsPath);
            }
        }
    }
}
