using Paint.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
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


        private int shapeSelected;
        private Color colorSelected;
        private int sizeSelected;
        private bool isControlCross;
        private List<Tuple<Point, Point>> _lines = new List<Tuple<Point, Point>>();
        private List< Point> _points = new List< Point>();
        public MyPanel(MyData data)
        {
            list_ptb = new List<MyPtb>();
            allowDraw = false;
            shapeSelected = data.shapeSelected_index;
            colorSelected = data._color;
            sizeSelected = data._size;
            isControlCross = data.isMouseCrossCtrl;

            DoubleBuffered = true;
        }
        private void updateData(MyData dt)
        {
            dt.isMouseCrossCtrl = isControlCross;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                allowDraw = true;
                lastPoint = e.Location;
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
                startPoint = e.Location;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (shapeSelected == 0)
            {
                if (allowDraw && !lastPoint.IsEmpty && !startPoint.IsEmpty)
                    _points.Add(new Tuple<Point, Point>(lastPoint, startPoint));
            }
            else if (shapeSelected == 1)
            {
                if (allowDraw && !lastPoint.IsEmpty && !startPoint.IsEmpty)
                    _lines.Add(new Tuple<Point, Point>(lastPoint, startPoint));
            }

            allowDraw = false;
            lastPoint = Point.Empty;
            startPoint = Point.Empty;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Pen p = new Pen(colorSelected, sizeSelected);
            if (shapeSelected == 0)
            {
                foreach (var point in _points)
                    e.Graphics.DrawLine(p);
                if (!lastPoint.IsEmpty && !startPoint.IsEmpty)
                    e.Graphics.DrawLine(p, lastPoint, startPoint);
            }
            else if (shapeSelected == 1)
            {
                foreach (var line in _lines)
                    e.Graphics.DrawLine(p, line.Item1, line.Item2);
                if (!lastPoint.IsEmpty && !startPoint.IsEmpty)
                    e.Graphics.DrawLine(p, lastPoint, startPoint);
            }

        }
    }
}
