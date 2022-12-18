using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using Paint.MyShape;

namespace Paint.MyAct
{
    public class painter_event
    {
        public void onClickMouseMove(Point p, Point lastPoint, Shape pen, PictureBox ptb)
        {
            
                Brush brush = new SolidBrush(pen.color);
                if (lastPoint != null)
                {
                    if (ptb.Image == null)
                    {
                        Bitmap bmp = new Bitmap(ptb.Width, ptb.Height);
                        ptb.Image = bmp;
                    }
                    using (Graphics g = Graphics.FromImage(ptb.Image))
                    {
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                        g.FillRectangle(brush, new System.Drawing.Rectangle(p.X, p.Y, pen.size, pen.size));
                        g.FillRectangle(brush, new System.Drawing.Rectangle(p.X, p.Y, pen.size, pen.size));
                        lastPoint = p;
                    }
                    ptb.Invalidate();

                }
            
        }


    }
}
