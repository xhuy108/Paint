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
        // opacity
        public double _opacity { get; set; }

        // chuot di qua control
        public bool isMouseCrossCtrl { get; set; }
        // xem có redo, undo không
        public bool isRedo { get; set; }
        public bool isUndo { get; set; }
        // redo, undo
        public Stack<Bitmap> UndoStack = new Stack<Bitmap>();
        public Stack<Bitmap> RedoStack = new Stack<Bitmap>();
        public MyData()
        {
            shapeSelected_index = 0;
            _color = Color.Black;
            _size = 10;
            _opacity = 1;
            isMouseCrossCtrl = false;
            isRedo = false;
            isUndo = false;
        }
    }
}
