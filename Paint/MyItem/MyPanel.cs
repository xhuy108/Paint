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
        private List<Tuple<Point, Point>> _points = new List<Tuple<Point, Point>>();
        private Pen p;
        //Graphics g;
        public MyPanel()
        {
            list_ptb = new List<MyPtb>();          
            p = new Pen(colorSelected, sizeSelected);
            DoubleBuffered = true;
        }
        public MyPanel(MyData data)
        {
            list_ptb = new List<MyPtb>();
            allowDraw = false;
            shapeSelected = data.shapeSelected_index;
            colorSelected = data._color;
            sizeSelected = data._size;
            isControlCross = data.isMouseCrossCtrl;
            //g = this.CreateGraphics();
            p = new Pen(colorSelected, sizeSelected);

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
                if (shapeSelected == 0)
                {
                    lastPoint = e.Location;
                   
                }
                else if (shapeSelected == 1)
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
                if (shapeSelected == 0)
                {
                    startPoint = e.Location;
                    if(allowDraw && !lastPoint.IsEmpty && !startPoint.IsEmpty)
                        _points.Add(new Tuple<Point, Point>(lastPoint, startPoint));
                    lastPoint = startPoint;
                }
                else if (shapeSelected == 1)
                {
                    startPoint = e.Location;
                    
                }
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (shapeSelected == 0)
            {
                lastPoint = Point.Empty;
                startPoint = Point.Empty;
            }
            else if (shapeSelected == 1)
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
            if(shapeSelected ==0)
            {
                _draw_point(e.Graphics, p);
            }
            else if (shapeSelected == 1)
            {
                _draw_line(e.Graphics, p);
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
