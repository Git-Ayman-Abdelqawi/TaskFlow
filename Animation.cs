using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace TaskFlow
{
    class  clsAnimation
    {

        public static void DrawBackground(PaintEventArgs e, Rectangle clientRect)
        {
            using (var brush = new LinearGradientBrush(
             clientRect,
             Color.MidnightBlue,   
             Color.Black,          
             LinearGradientMode.Vertical)) 
            {
                e.Graphics.FillRectangle(brush, clientRect);
            }

           
            Random rnd = new Random();
            for (int i = 0; i < 50; i++) 
            {
                int x = rnd.Next(clientRect.Width);
                int y = rnd.Next(clientRect.Height);
                e.Graphics.FillEllipse(Brushes.White, x, y, 3, 3);
            }
        

        }

        public static string GetClockText()
        {
            return DateTime.Now.ToString("hh:mm:ss tt",
                new System.Globalization.CultureInfo("ar-EG"));
        }

        public static void DrawBackground(Graphics g, Rectangle rect)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,                  // استخدم rect بدل this.ClientRectangle
 Color.DarkBlue,        // أبيض
        Color.White,    LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, rect); // استخدم g بدل e.Graphics
            }
        }


        public static void DrawRoundedRectangle(PaintEventArgs e, Rectangle clientRect)
        {
            Color Balk = Color.Black;
            Rectangle rect = new Rectangle(100, 100, 500, 500);
            int radius = 30;

            using (GraphicsPath path = new GraphicsPath())
            {

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (Brush brush = new SolidBrush(Balk))
                {
                    e.Graphics.FillPath(brush, path);
                }

                Color Witsh = Color.White;
                Pen Rec = new Pen(Witsh);
                Rec.Width = 3;

                e.Graphics.DrawLine(Rec, 100, 260, 600, 260);

            }
        }


    }
}
