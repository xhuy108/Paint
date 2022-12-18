using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.MyShape
{
    public class MPen:Shape
    {
        // cho biết phải bút xóa không
        public bool isErase { get; set; }
        public MPen()
        {
            name = "Pen";
        }
        public MPen(Color clor)
        {
            name = "Pen";
            color = clor;
        }
        public MPen(Color clor, int siz)
        {
            name = "Pen";
            color = clor;
            size = siz;
        }
        public override void draw(Graphics g)
        {
            Pen pen = new Pen(color, size);

            
            
        }
        //public DrawLine(Graphics g, )
        
    }
}
