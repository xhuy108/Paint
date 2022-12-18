using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.MyShape
{
    public partial class MyLine : Shape
    {
        public MyLine()
        {
            name = "Line";
            index = 1;
        }
        public MyLine(int siz)
        {
            name = "Line";
            index = 1;
            size = siz;
        }
        public MyLine(int siz, Color clor)
        {
            name = "Line";
            index = 1;
            size = siz;
            color = clor;
        }
    }
}
