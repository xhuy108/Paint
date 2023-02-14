using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.MyShape
{
    public class MyPen : Shape
    {
        // cho biết phải bút xóa không
        public bool isErase { get; set; }
        public MyPen()
        {
            name = "Pen";
            index = 0;
        }
        public MyPen(Color clor)
        {
            name = "Pen";
            color = clor;
            index = 0;
        }

        public MyPen(int _size)
        {
            size = _size;
            index = 0;
        }
        public MyPen(Color clor, int siz)
        {
            name = "Pen";
            color = clor;
            size = siz;
            index = 0;
        }

        //public DrawLine(Graphics g, )

    }
}
