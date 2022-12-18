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

namespace Paint.Manager
{
    public partial class MyData
    {
        // shape duoc chon
        public int shapeSelected_index { get; set; }
        // mau duoc chon
        public Color _color { get; set; }
        // size 
        public int _size { get; set; }
        // chuot di qua control
        public bool isMouseCrossCtrl { get; set; }
        public MyData()
        {
            shapeSelected_index = 0;
            _color = Color.Black;
            _size = 10;
            isMouseCrossCtrl = false;
        }
    }
}
