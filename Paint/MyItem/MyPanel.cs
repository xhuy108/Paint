using Paint.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

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

        private Bitmap bm;
        //private Pen p;
        //Graphics g;
        public MyPanel()
        {
            list_ptb = new List<MyPtb>();
            //p = new Pen(Data._color, Data._size);
            DoubleBuffered = true;
            bm = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));
        }
        public void Undo_Click()
        {
            if (Data.UndoStack.Count > 0)
            {
                Data.RedoStack.Push((Bitmap)bm.Clone());
                bm = Data.UndoStack.Pop();
                Graphics g = Graphics.FromImage(bm);
                Invalidate();
            }
        }
        public void update(MyData data)
        {
            Data.UndoStack = data.UndoStack;
            Data.RedoStack = data.RedoStack;
            Data.shapeSelected_index = data.shapeSelected_index;
            Data._color = data._color;
            Data._size = data._size;
            Data._opacity= data._opacity;
            Data.isMouseCrossCtrl = data.isMouseCrossCtrl;
            Data.isRedo = data.isRedo;
            Data.isUndo = data.isUndo;
        }
        public void updateData(MyData data)
        {
            data.UndoStack = Data.UndoStack;
            data.RedoStack = Data.RedoStack;
            data._color = Data._color;
            data._size = Data._size;
            data._opacity = Data._opacity;
        }

        #region Vẽ
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);  // bắt sự kiện
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
        #endregion


        protected override void OnPaint(PaintEventArgs e)
        {
            Pen p = new Pen(Data._color, Data._size);
            if (Data.shapeSelected_index == 0)
            {

                Data.UndoStack.Push((Bitmap)bm.Clone());
                _draw_point(e.Graphics, p);
                Data.RedoStack.Clear();
            }
            else if (Data.shapeSelected_index == 1)
            {
                Data.UndoStack.Push((Bitmap)bm.Clone());
                _draw_line(e.Graphics, p);
                Data.RedoStack.Clear();
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
        
    }
}
