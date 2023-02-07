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
        // co tao text khong
        public bool isText { get; set; }
        // chuot di qua control
        public bool isMouseCrossCtrl { get; set; }
        // xem có redo, undo không
        public bool isRedo { get; set; }
        public bool isUndo { get; set; }
        // redo, undo
        public Stack<Image> UndoStackImage = new Stack<Image>();
        public Stack<Image> RedoStackImage = new Stack<Image>();
        public Stack<Point> UndoStackLocation = new Stack<Point>();
        public Stack<Point> RedoStackLocation = new Stack<Point>();

        // stack để lưu obj mới nhất
        public Stack<string> StackObject = new Stack<string>();
        private string image = "Image";
        private string location = "Location";

        public MyData()
        {
            shapeSelected_index = 1;
            _color = Color.Black;
            _size = 10;
            isMouseCrossCtrl = false;
            isRedo = false;
            isUndo = false;
            isText = false;
        }
        public void UpdateDataStack(MyData dt)
        {
            this.UndoStackImage = dt.UndoStackImage;
            this.RedoStackImage = dt.RedoStackImage;
        }
        public void AddItem(Object obj)
        {
            if(obj.GetType() == typeof(MyItem.MyPtb))
            {
                MyItem.MyPtb myPtb = (MyItem.MyPtb)obj;
                Point point = myPtb.Location;
                UndoStackLocation.Push(point);
                StackObject.Push(location);
            }    
            else if(obj.GetType() == typeof(Image))
            {
                Image img = (Image)obj;
                UndoStackImage.Push(img);
                StackObject.Push(image);
            }    
        }
        public object Undo()
        {
            string obj = StackObject.Pop();
            if(obj == location)
            {
                Point point = UndoStackLocation.Pop();
                RedoStackLocation.Push(point);
                return (object)UndoStackLocation.First();
            }
            else
            {
                Image img = UndoStackImage.Pop();
                RedoStackImage.Push(img);
                return (object)UndoStackImage.First();
            }
        }
        public object Redo()
        {
            string obj = StackObject.Pop();
            if(obj == location)
            {
                if (RedoStackLocation.Count == 0)
                    return UndoStackLocation.First();
                Point point = RedoStackLocation.Pop();
                UndoStackLocation.Push(point);
                return UndoStackLocation.First();
            }
            else 
            {
                if(RedoStackImage.Count == 0)
                    return UndoStackImage.First();
                Image img = RedoStackImage.Pop();
                UndoStackImage.Push(img);
                return UndoStackImage.First();
            }
        }

    }
}
