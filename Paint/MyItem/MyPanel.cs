using Paint.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Paint.MyItem
{
    public partial class MyPanel : Panel
    {
        // cho phep ve
        public bool allowDraw { get; set; }
        // list cac danh sach
        public List<MyPtb> list_ptb;
        // diem lan cuoi nhan chuot
        public Point lastPoint { get; set; }
        // diem ve
        public Point startPoint { get; set; }
        // cho biết shape cần vẽ
        public MyData Data = new MyData();

        private List<Tuple<Point, Point>> _lines = new List<Tuple<Point, Point>>();
        private List<Tuple<Point, Point>> _points = new List<Tuple<Point, Point>>();
        private readonly object UndoRedoLock = new object();

        private Bitmap bm;
        
        //Graphics g;
        public MyPanel()
        {
            list_ptb = new List<MyPtb>();
            
            DoubleBuffered = true;
            bm = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));
        }
        


        public void update(MyData data)
        {
            Data.UndoStackImage = data.UndoStackImage;
            Data.RedoStackImage = data.RedoStackImage;
            Data.shapeSelected_index = data.shapeSelected_index;
            Data._color = data._color;
            Data._size = data._size;
            Data.isMouseCrossCtrl = data.isMouseCrossCtrl;
            Data.isRedo = data.isRedo;
            Data.isUndo = data.isUndo;
        }
        public void updateData(MyData data)
        {
            data.UndoStackImage = Data.UndoStackImage;
            data.RedoStackImage = Data.RedoStackImage;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                allowDraw = true;
                if (Data.shapeSelected_index == 0)
                {
                    lastPoint = e.Location;

                }
                else if (Data.shapeSelected_index == 1)
                {
                    lastPoint = e.Location;

                }
            }
            else
            {
                allowDraw = false;
                lastPoint = Point.Empty;
            }
            startPoint = Point.Empty;
            Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                if (Data.shapeSelected_index == 0)
                {
                    startPoint = e.Location;
                    if (allowDraw && !lastPoint.IsEmpty && !startPoint.IsEmpty)
                        _points.Add(new Tuple<Point, Point>(lastPoint, startPoint));
                    lastPoint = startPoint;
                }
                else if (Data.shapeSelected_index == 1)
                {
                    startPoint = e.Location;

                }
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (Data.shapeSelected_index == 0)
            {
                lastPoint = Point.Empty;
                startPoint = Point.Empty;
            }
            else if (Data.shapeSelected_index == 1)
            {
                if (allowDraw && !lastPoint.IsEmpty && !startPoint.IsEmpty)
                    _lines.Add(new Tuple<Point, Point>(lastPoint, startPoint));
                lastPoint = Point.Empty;
                startPoint = Point.Empty;

            }
            Invalidate();
            allowDraw = false;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Pen p = new Pen(Data._color, Data._size);
            if (Data.shapeSelected_index == 0)
            {

                Data.UndoStackImage.Push((Bitmap)bm.Clone());
                _draw_point(e.Graphics, p);
                Data.RedoStackImage.Clear();
            }
            else if (Data.shapeSelected_index == 1)
            {
                Data.UndoStackImage.Push((Bitmap)bm.Clone());
                _draw_line(e.Graphics, p);
                Data.RedoStackImage.Clear();
            }
        }
        private void _draw_line(Graphics g, Pen p)
        {
            foreach (var line in _lines)
                g.DrawLine(p, line.Item1, line.Item2);
            if (!lastPoint.IsEmpty && !startPoint.IsEmpty)
                g.DrawLine(p, lastPoint, startPoint);
        }
        private void _draw_point(Graphics g, Pen p)
        {
            foreach (var point in _points)
            {
                g.DrawLine(p, point.Item1, point.Item2);
            }
        }

        private void updateImage(Action update)
        {
            lock(UndoRedoLock)
            {
                Data.UndoStackImage.Push(bm);
                try
                {
                    update();
                }
                catch
                {
                    Data.UndoStackImage.Pop();
                }
            }
        }

        private Bitmap DrawToBitmap(Control container)
        {
            // Get child controls based on z-order.
            var childControls = container.Controls.Cast<Control>().ToArray();

            // Reverse order so frontmost control is last.
            Array.Reverse(childControls);

            var maxBottom = childControls.Max(ctrl => ctrl.Bottom);
            var maxRight = childControls.Max(ctrl => ctrl.Right);

            // Create Bitmap with 10 pixels clearance in each direction.
            var bmp = new Bitmap(maxRight + 10, maxBottom + 10);

            foreach (var childControl in childControls)
            {
                childControl.DrawToBitmap(bmp, childControl.Bounds);
            }

            return bmp;
        }

    }
}
