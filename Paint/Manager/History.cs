﻿using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace Paint.Manager
{
    public class H
    {
        public H() { }
        public GraphicsPath path = new GraphicsPath();
        public Pen p = new Pen(Color.Black,10);
        public Brush br = new SolidBrush(Color.Black);
        public Image saveim = new Bitmap(788, 497);
        public int mode = 1;
        public Rectangle rec;
        public Point[] poin = new Point[100000];
        public Size size;
    }
    public class History
    {
        public H[] list = new H[200];
        public int n = 0;
        public History()
        {

        }

    }
}
