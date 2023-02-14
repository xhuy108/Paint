using Paint.Manager;
using Paint.MyItem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing.Imaging;

namespace Paint
{
    public partial class Form1 : Form
    {
        #region khai báo
        private static Color MainColor = Color.Black;
        // Data save
        public SelectedTool tool = new SelectedTool();
        public Pen _p = new Pen(Color.Black, Size);
        public MyData dt = new MyData();
        private static int Size = 1;

        //public Point Brush_A = new Point();
        int A_x = -1;
        int A_y = -1;
        int B_x = -1;
        int B_y = -1;

        public Point tmp = new Point();
        private bool isSave = false;
        public bool isPic = false;
        public Image img;
        public Point[] tri_points = new Point[2];
        public Rectangle rec = new Rectangle();
        // vị trí chuột
        public bool isMouseUp = false;
        int x = -1;
        int y = -1;
        // cho phép vẽ
        bool allowDraw;
        // độ phóng to thu nhỏ
        public int hesonhan = 1;
        // danh sach ptb
        public List<Point> l_fillPoint = new List<Point>();

        #endregion
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menuStrip1.Renderer = new MenuStripRenderer();

            _p.EndCap = LineCap.Round;
            _p.DashStyle = DashStyle.Solid;
            _p.DashCap = DashCap.Flat;
            _p.StartCap = LineCap.Round;

        }

        #region pick color
        public class MenuStripRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);

                if (e.Item.Selected)
                {
                    Color color = Color.DarkGray;
                    using (SolidBrush brush = new SolidBrush(color))
                        e.Graphics.FillRectangle(brush, rect);
                }
                else
                {
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(37, 37, 37)))
                        e.Graphics.FillRectangle(brush, rect);
                }
            }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.Item.ForeColor = Color.White;
                base.OnRenderItemText(e);
            }

            protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
            {
                base.OnRenderSeparator(e);
            }

            public MenuStripRenderer() : base(new MenuStripColors()) { }
        }

        public class MenuStripColors : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get { return MainColor; }
            }

            public override Color MenuItemSelected
            {
                get { return MainColor; }
            }

            public override Color MenuItemBorder
            {
                get { return MainColor; }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return MainColor; }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return MainColor; }
            }

            public override Color MenuBorder
            {
                get { return MainColor; }
            }
        }

        private void textBox_RGBvalueChange()
        {
            textBox_Rvalue.Text = pictureBox_Color_Front.BackColor.R.ToString();
            textBox_Gvalue.Text = pictureBox_Color_Front.BackColor.G.ToString();
            textBox_Bvalue.Text = pictureBox_Color_Front.BackColor.B.ToString();
        }

        private void btn_SelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Color_Front.BackColor = colorPicker.Color;
                textBox_RGBvalueChange();
            }
        }

        private void color_Swap(object sender, EventArgs e)
        {
            Color tmp = pictureBox_Color_Front.BackColor;
            pictureBox_Color_Front.BackColor = pictureBox_Color_Back.BackColor;
            pictureBox_Color_Back.BackColor = tmp;
            _p.Color = pictureBox_Color_Front.BackColor;
            textBox_RGBvalueChange();
        }

        private void colorPicker_ColorPicked(object sender, EventArgs e)
        {
            pictureBox_Color_Front.BackColor = colorPicker.SelectedColor;
            _p.Color = pictureBox_Color_Front.BackColor;
            textBox_RGBvalueChange();
        }

        private void colorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_ColorPreview.BackColor = colorPicker._canvas.GetPixel(e.X, e.Y);
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.tool.isBrush = true;


        }

        #region mo file

        public void OpenImage(PictureBox picturebox)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.png;*.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg; *.jpeg; *.gif; *.bmp";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picturebox.Image = new Bitmap(openFile.FileName);
                picturebox.Size = pt_draw.Size;
                picturebox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void openfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox _myptb = new PictureBox();
            OpenImage(_myptb);
            pt_draw.Image = _myptb.Image;
            pt_draw.SizeMode = PictureBoxSizeMode.StretchImage;
            img = _myptb.Image;
            
        }

        #endregion


        #region Undo, Redo
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (dt.luu.n > 0)
                dt.luu.n--;
            dt.velai(this, pt_draw);
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            if (dt.luu.n < dt.n)
                dt.luu.n++;
            dt.velai(this, pt_draw);
        }

        #endregion
        private void pictureBox_Color_Front_BackColorChanged(object sender, EventArgs e)
        {

        }



        #region panel_paint paint
        private void panel_paint_MouseDown(object sender, MouseEventArgs e)
        {
            isSave = false;
            allowDraw = true;
            isMouseUp = false;
            A_x = e.Location.X;
            A_y = e.Location.Y;
            Matrix mx = new Matrix(zoom, 0, 0, zoom, AutoScrollPosition.X, AutoScrollPosition.Y);
            mx.Invert();
            Point[] pa = { new Point(e.X, e.Y) };
            mx.TransformPoints(pa);
            int X, Y;
            X = pa[0].X;
            Y = pa[0].Y;
            Graphics g = pt_draw.CreateGraphics();
            MouseDown(g, sender, e, X, Y);
            B_x = -1;
            B_y = -1;

            if (tool.isBrush)
            {
                x = e.X;
                y = e.Y;

                dt._points.Add(e.Location);
            }

        }

        private void panel_paint_MouseUp(object sender, MouseEventArgs e)
        {
            allowDraw = false;
            isMouseUp = true;
            B_x = e.Location.X;
            B_y = e.Location.Y;
            rec = new Rectangle(
                        Math.Min(A_x, e.X),
                        Math.Min(A_y, e.Y),
                        Math.Abs(A_x - e.X),
                        Math.Abs(A_y - e.Y));
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics _g = pt_draw.CreateGraphics())
                {
                    _g.SmoothingMode = SmoothingMode.AntiAlias;

                    if (tool.isBrush)
                    {
                        x = -1;
                        y = -1;
                        dt._points.Add(e.Location);


                        dt.luu.list[dt.luu.n] = new H();
                        dt.luu.list[dt.luu.n].path.AddLines(dt._points.ToArray());
                        dt.luu.list[dt.luu.n].p.Color = _p.Color;
                        dt.luu.list[dt.luu.n].p.Width = _p.Width;
                        dt.luu.list[dt.luu.n].p.EndCap = _p.EndCap;
                        dt.luu.list[dt.luu.n].p.DashStyle = _p.DashStyle;
                        dt.luu.list[dt.luu.n].p.DashCap = _p.DashCap;
                        dt.luu.list[dt.luu.n].p.StartCap = _p.StartCap;

                        _g.DrawPath(dt.luu.list[dt.luu.n].p, dt.luu.list[dt.luu.n].path);
                        dt.luu.n++;
                        dt.n = dt.luu.n;

                        dt._points.Clear();
                    }
                    else dt.vehinh(this, new Point(A_x, A_y), new Point(B_x, B_y), pt_draw);

                    A_x = -1;
                    A_y = -1;

                    if (tool.isColorPicker)
                    {
                        Bitmap bmps = ConvertToBM(pt_draw);
                        Color c;
                        float _zoom = 1f;
                        c = bmps.GetPixel(e.X, e.Y + Convert.ToInt32(15 / _zoom));
                        _p.Color = c;
                        pictureBox_Color_Front.BackColor = c;
                    }
                }
            }




        }

        private void panel_paint_MouseMove(object sender, MouseEventArgs e)
        {
            lb_x.Text = e.Location.X.ToString();
            lb_y.Text = e.Location.Y.ToString();
            isMouseUp = false;
            tmp = e.Location;
            if (allowDraw)
            {
                rec = new Rectangle(
                        Math.Min(A_x, e.X),
                        Math.Min(A_y, e.Y),
                        Math.Abs(A_x - e.X),
                        Math.Abs(A_y - e.Y));
                if (tool.isBrush && x != -1 && y != -1)
                {
                    dt._points.Add(e.Location);
                    using (Graphics _g = pt_draw.CreateGraphics())
                    {
                        _g.SmoothingMode = SmoothingMode.AntiAlias;
                        _g.DrawLine(_p, new Point(x, y), e.Location);
                    }
                    x = e.X;
                    y = e.Y;
                }
                else
                {
                    if (tool.isLine)
                    {
                        using (Graphics _g = pt_draw.CreateGraphics())
                        {
                            _g.SmoothingMode = SmoothingMode.AntiAlias;
                            _g.DrawLine(_p, new Point(A_x, A_y), e.Location);
                        }

                    }
                    else if (tool.isRect)
                    {
                        using (Graphics _g = pt_draw.CreateGraphics())
                        {
                            _g.SmoothingMode = SmoothingMode.AntiAlias;
                            _g.DrawRectangle(_p, rec);
                            if (tool.isFill)
                            {
                                Brush _br = new SolidBrush(_p.Color);
                                _g.FillRectangle(_br, rec);
                            }
                        }
                    }
                    else if (tool.isCircle)
                    {
                        using (Graphics _g = pt_draw.CreateGraphics())
                        {
                            _g.SmoothingMode = SmoothingMode.AntiAlias;
                            _g.DrawEllipse(_p, rec);
                            if (tool.isFill)
                            {
                                Brush _br = new SolidBrush(_p.Color);
                                _g.FillEllipse(_br, rec);
                            }
                        }
                    }
                    else if (tool.isTriangle)
                    {
                        using (Graphics _g = pt_draw.CreateGraphics())
                        {
                            _g.SmoothingMode = SmoothingMode.AntiAlias;
                            DrawTriagle(rec, _g, _p);
                            if (tool.isFill)
                            {
                                Brush _br = new SolidBrush(_p.Color);
                                FillTriagle(rec, _g, _br);
                            }
                        }
                    }
                    else if (tool.isCrop)
                    {
                        using (Graphics _g = pt_draw.CreateGraphics())
                        {
                            _g.SmoothingMode = SmoothingMode.AntiAlias;
                            Pen p = new Pen(Color.Black, 3);
                            _g.DrawRectangle(p, rec);
                        }
                    }
                    pt_draw.Invalidate();
                }


            }

        }

        private void pt_draw_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            for (int i = 0; i < dt.luu.n; i++)
            {
                //if (dt.luu.list[i].mode == -1)
                //{
                //    pt_draw.Image = dt.luu.list[i].saveim;
                //}
                //else
                //{
                    g.DrawPath(dt.luu.list[i].p, dt.luu.list[i].path);
                    if (dt.luu.list[i].mode == 2)
                    {
                        g.FillPath(dt.luu.list[i].br, dt.luu.list[i].path);

                    }
                

            }

            if (allowDraw)
            {
                if (tool.isLine)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    if (A_x != -1 && B_x != -1) g.DrawLine(_p, new Point(A_x, A_y), new Point(B_x, B_y));
                    else if (isMouseUp == false)
                    {
                        g.DrawLine(_p, new Point(A_x, A_y), tmp);
                    }
                }
                else if (tool.isRect)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    if (A_x != -1 && B_x != -1)
                    {
                        g.DrawRectangle(_p, rec);
                        if (tool.isFill)
                        {
                            Brush _br = new SolidBrush(_p.Color);
                            g.FillRectangle(_br, rec);
                        }
                    }
                    else if (isMouseUp == false)
                    {
                        g.DrawRectangle(_p, rec);
                        if (tool.isFill)
                        {
                            Brush _br = new SolidBrush(_p.Color);
                            g.FillRectangle(_br, rec);
                        }
                    }
                }
                else if (tool.isCircle)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    if (A_x != -1 && B_x != -1)
                    {
                        g.DrawEllipse(_p, rec);
                        if (tool.isFill)
                        {
                            Brush _br = new SolidBrush(_p.Color);
                            g.FillEllipse(_br, rec);
                        }
                    }
                    else if (isMouseUp == false)
                    {
                        g.DrawEllipse(_p, rec);
                        if (tool.isFill)
                        {
                            Brush _br = new SolidBrush(_p.Color);
                            g.FillEllipse(_br, rec);
                        }
                    }
                }
                else if (tool.isTriangle)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    if (A_x != -1 && B_x != -1)
                    {
                        DrawTriagle(rec, g, _p);
                        if (tool.isFill)
                        {
                            Brush _br = new SolidBrush(_p.Color);
                            FillTriagle(rec, g, _br);
                        }
                    }
                    else if (isMouseUp == false)
                    {
                        DrawTriagle(rec, g, _p);
                        if (tool.isFill)
                        {
                            Brush _br = new SolidBrush(_p.Color);
                            FillTriagle(rec, g, _br);
                        }
                    }
                }
            }

            pt_draw = (PictureBox)sender;

        }
        public void DrawTriagle(Rectangle _rect, Graphics _g, Pen _pen)
        {
            Point[] _listPoint =
           {
              new Point(_rect.X + _rect.Width/2, _rect.Y),
              new Point(_rect.X, _rect.Y + _rect.Height),
              new Point (_rect.X + _rect.Width, _rect.Y + _rect.Height)
           };
            _g.DrawPolygon(_pen, _listPoint);
            tri_points = _listPoint;
        }
        public void FillTriagle(Rectangle _rect, Graphics _g, Brush _br)
        {
            Point[] _listPoint =
           {
              new Point(_rect.X + _rect.Width/2, _rect.Y),
              new Point(_rect.X, _rect.Y + _rect.Height),
              new Point (_rect.X + _rect.Width, _rect.Y + _rect.Height)
           };
            _g.FillPolygon(_br, _listPoint);
            tri_points = _listPoint;
        }

        #endregion
        #region đổ màu
        Point ps;
        Point ps_;
        Point pe;
        Point pe_;
        float zoom = 1f;
        private static System.Collections.Stack stack = new System.Collections.Stack();
        private static bool CheckPixel(Point pos, BitmapData bmd)
        {
            return (pos.X > -1) && (pos.Y > -1) && (pos.X < bmd.Width) && (pos.Y < bmd.Height);
        }

        private static void SetPixel(Point pos, BitmapData bmd, Color c)
        {
            if (CheckPixel(pos, bmd))
            {
                //always assumes 32 bit per pixels
                int offset = pos.Y * bmd.Stride + (4 * pos.X);
                Marshal.WriteByte(bmd.Scan0, offset + 2, c.R);
                Marshal.WriteByte(bmd.Scan0, offset + 1, c.G);
                Marshal.WriteByte(bmd.Scan0, offset, c.B);
                Marshal.WriteByte(bmd.Scan0, offset + 3, 255);
            }
        }
        private static Color GetPixel(Point pos, BitmapData bmd)
        {
            if (CheckPixel(pos, bmd))
            {
                //always assumes 32 bit per pixels
                int offset = pos.Y * bmd.Stride + (4 * pos.X);
                return Color.FromArgb(
                Marshal.ReadByte(bmd.Scan0, offset + 2),
                Marshal.ReadByte(bmd.Scan0, offset + 1),
                Marshal.ReadByte(bmd.Scan0, offset));
            }
            else
                return Color.FromArgb(0, 0, 0, 0);
        }
        private void FillPixel(Point pos, BitmapData bmd, Color c, Color org)
        {
            if (c.ToArgb() == org.ToArgb())
                return;
            Point currpos = new Point(0, 0);
            l_fillPoint.Add(pos);
            stack.Push(pos);
            do
            {
                currpos = (Point)stack.Pop();
                SetPixel(currpos, bmd, c);
                if (GetPixel(new Point(currpos.X + 1, currpos.Y), bmd) == org)
                {
                    stack.Push(new Point(currpos.X + 1, currpos.Y));
                    l_fillPoint.Add(new Point(currpos.X + 1, currpos.Y));
                }
                if (GetPixel(new Point(currpos.X, currpos.Y - 1), bmd) == org)
                {
                    stack.Push(new Point(currpos.X, currpos.Y - 1));
                    l_fillPoint.Add(new Point(currpos.X, currpos.Y - 1));
                }
                if (GetPixel(new Point(currpos.X - 1, currpos.Y), bmd) == org)
                {
                    stack.Push(new Point(currpos.X - 1, currpos.Y));
                    l_fillPoint.Add(new Point(currpos.X - 1, currpos.Y));
                }
                if (GetPixel(new Point(currpos.X, currpos.Y + 1), bmd) == org)
                {
                    stack.Push(new Point(currpos.X, currpos.Y + 1));
                    l_fillPoint.Add(new Point(currpos.X, currpos.Y + 1));
                }
            } while (stack.Count > 0);
        }
        public Bitmap Fill(Bitmap bm, Point pos, Color color)
        {
            //Lock the bitmap data
            BitmapData bmd = bm.LockBits(new
            Rectangle(0, 0, bm.Width, bm.Height), ImageLockMode.ReadWrite, bm.PixelFormat);

            //get the color under the point. This is the original.
            Color org = GetPixel(pos, bmd);

            //Fill the first pixel and recursively fill all it's neighbors
            FillPixel(pos, bmd, color, org);

            //unlock the bitmap
            bm.UnlockBits(bmd);

            return bm;
        }

        public void MouseDown(Graphics graphics, object sender, MouseEventArgs e, int X, int Y)
        {
            ps.X = X;
            ps.Y = Y;
            ps_.X = e.X;
            ps_.Y = e.Y;
            PictureBox pb = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (tool.isBucket)
                {
                    Cursor cur;
                    cur = pb.Cursor;
                    Bitmap b;
                    pb.Cursor = Cursors.WaitCursor;
                    pb.Enabled = false;
                    b = Fill(ConvertToBM(pb), new Point(X, Y), pictureBox_Color_Front.BackColor);
                    pb.Enabled = true;
                    pb.Cursor = cur;
                    if (b != null)
                    {
                        graphics.DrawImage(b, 0, 0);
                        if (l_fillPoint.Count > 1)
                        {
                            dt.luu.list[dt.luu.n] = new H();
                            dt.luu.list[dt.luu.n].path.AddLines(l_fillPoint.ToArray());
                            dt.luu.list[dt.luu.n].p.Color = pictureBox_Color_Front.BackColor;
                            dt.luu.list[dt.luu.n].p.Width = 1;
                            dt.luu.n++;
                            dt.n = dt.luu.n;
                            
                            l_fillPoint.Clear();
                        }
                    }
                    pb.Refresh();
                }
                pe = ps;
                pe_ = ps_;
            }
        }


        #endregion
        #region tool check
        private void btn_Shape_Click(object sender, EventArgs e)
        {
            tLP_Shape.Visible = true;
        }
        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            _p.Color = Color.White;
            this.tool.isBrush = true;
            this.tool.isLine = false;
            this.tool.isRect = false;
            this.tool.isCircle = false;
            this.tool.isTriangle = false;
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }
        private void btn_Brush_Click(object sender, EventArgs e)
        {
            _p.Color = pictureBox_Color_Front.BackColor;
            this.tool.isBrush = true;
            this.tool.isLine = false;
            this.tool.isRect = false;
            this.tool.isCircle = false;
            this.tool.isTriangle = false;
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            _p.Color = pictureBox_Color_Front.BackColor;
            this.tool.isBrush = false;
            this.tool.isLine = true;
            this.tool.isRect = false;
            this.tool.isCircle = false;
            this.tool.isTriangle = false;
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }



        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            _p.Color = pictureBox_Color_Front.BackColor;
            this.tool.isBrush = false;
            this.tool.isLine = false;
            this.tool.isRect = true;
            this.tool.isCircle = false;
            this.tool.isTriangle = false;
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            _p.Color = pictureBox_Color_Front.BackColor;
            this.tool.isBrush = false;
            this.tool.isLine = false;
            this.tool.isRect = false;
            this.tool.isCircle = true;
            this.tool.isTriangle = false;
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            _p.Color = pictureBox_Color_Front.BackColor;
            this.tool.isBrush = false;
            this.tool.isLine = false;
            this.tool.isRect = false;
            this.tool.isCircle = false;
            this.tool.isTriangle = true;
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {
            _p.Color = pictureBox_Color_Front.BackColor;
            if (this.tool.isFill == false) tool.isFill = true;
            else tool.isFill = false;

            this.tool.isBrush = false;
            
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }
        private void btn_Bucket_Click(object sender, EventArgs e)
        {
            _p.Color = pictureBox_Color_Front.BackColor;
            this.tool.isBrush = false;
            this.tool.isLine = false;
            this.tool.isRect = false;
            this.tool.isCircle = false;
            this.tool.isTriangle = false;
            this.tool.isBucket = true;
            this.tool.isColorPicker = false;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }

        private void btn_Eyedropper_Click(object sender, EventArgs e)
        {
            this.tool.isBrush = false;
            this.tool.isLine = false;
            this.tool.isRect = false;
            this.tool.isCircle = false;
            this.tool.isTriangle = false;
            this.tool.isBucket = false;
            this.tool.isColorPicker = true;
            this.tool.isText = false;
            this.tool.isCrop = false;
        }

        private void btn_Text_Click(object sender, EventArgs e)
        {
            this.tool.isText = true;
            this.tool.isCrop = false;
            this.tool.isBrush = false;
            this.tool.isLine = false;
            this.tool.isRect = false;
            this.tool.isCircle = false;
            this.tool.isTriangle = false;
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            this.tool.isText = false;
            this.tool.isCrop = true;
            this.tool.isBrush = false;
            this.tool.isLine = false;
            this.tool.isRect = false;
            this.tool.isCircle = false;
            this.tool.isTriangle = false;
            this.tool.isBucket = false;
            this.tool.isColorPicker = false;
        }

        #endregion

        #region Size
        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            _p.Width = trackBar_Size.Value;
            lb_value_size.Text = trackBar_Size.Value.ToString();
        }







        #endregion

        #region Edit
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Bitmap bm = ConvertToBM(pt_draw);
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "*.png|*.jpg";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                bm.Save(sv.FileName, ImageFormat.Png);
            }
            isSave = true;
        }

        private Bitmap ConvertToBM(PictureBox ptb)
        {
            Size sz = ptb.ClientSize;

            Rectangle rect2 = new Rectangle(0, 0, sz.Width, sz.Height);
            Bitmap bmp2 = new Bitmap(rect2.Width, rect2.Height);

            ptb.ClientSize = rect2.Size;

            ptb.DrawToBitmap(bmp2, rect2);

            ptb.ClientSize = sz;

            return bmp2;

        }
        #endregion

        

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                Bitmap bm = ConvertToBM(pt_draw);
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "*.png|*.jpg";
                sv.RestoreDirectory = true;
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    bm.Save(sv.FileName, ImageFormat.Png);
                }
                isSave = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isSave)
            {
                switch (MessageBox.Show("Bạn có muốn lưu file không", "Thông Báo", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        Bitmap bm = ConvertToBM(pt_draw);
                        SaveFileDialog sv = new SaveFileDialog();
                        sv.Filter = "*.png|*.jpg";
                        if (sv.ShowDialog() == DialogResult.OK)
                        {
                            bm.Save(sv.FileName, ImageFormat.Png);
                        }
                        isSave = true;
                        break;
                    case DialogResult.No:
                        
                        break;
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dt = new MyData();
            Graphics g = pt_draw.CreateGraphics();
            g.Clear(Color.White);

        }
    }
}
