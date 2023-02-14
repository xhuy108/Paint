using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Paint.Manager
{

    public class MyData : PictureBox
    {

        #region biến và hàm khởi tạo
        public History luu = new History();
        public bool tam = true;
        public Point a = new Point();
        public Point b = new Point();
        public Point mousedown = new Point();
        public List<Point> _points = new List<Point>();
        public int npoin = 0;
        public Point[] poin1;
        private Image ima, bm;


        public int n = 0, xet = 0;
        public MyData()
        {
            this.Image = new Bitmap(557, 408);
            this.Width = 557;
            this.Height = 408;
            this.Location = new Point();
            this.Visible = true;
            this.BackColor = Color.White;
        }
        #endregion
        #region vẽ
        public void vehinh(Form1 form, Point A, Point B, PictureBox ptb)
        {
         
            Graphics g = ptb.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if (form.tool.isLine)
            {
                g.DrawLine(form._p, A, B);
                luu.list[luu.n] = new H();
                luu.list[luu.n].path.AddLine(A, B);
                luu.list[luu.n].p.Color = form._p.Color;
                luu.list[luu.n].p.Width = form._p.Width;
                luu.list[luu.n].p.EndCap = form._p.EndCap;
                luu.list[luu.n].p.DashStyle = form._p.DashStyle;
                luu.list[luu.n].p.DashCap = form._p.DashCap;
                luu.list[luu.n].p.StartCap = form._p.StartCap;
                luu.n++;
                n = luu.n;
            }
            else if (form.tool.isRect)
            {
                if (form.tool.isFill)
                {
                    Brush _br = new SolidBrush(form._p.Color);
                    g.DrawRectangle(form._p, form.rec);
                    g.FillRectangle(_br, form.rec);

                    luu.list[luu.n] = new H();
                    luu.list[luu.n].p.Color = form._p.Color;
                    luu.list[luu.n].p.Width = form._p.Width;
                    luu.list[luu.n].p.EndCap = form._p.EndCap;
                    luu.list[luu.n].p.DashStyle = form._p.DashStyle;
                    luu.list[luu.n].p.DashCap = form._p.DashCap;
                    luu.list[luu.n].p.StartCap = form._p.StartCap;
                    luu.list[luu.n].path.AddRectangle(form.rec);
                    luu.list[luu.n].br = _br;
                    luu.list[luu.n].mode = 2;
                    luu.n++;
                    n = luu.n;
                }
                else
                {
                    g.DrawRectangle(form._p, form.rec);
                    luu.list[luu.n] = new H();
                    luu.list[luu.n].path.AddRectangle(form.rec);
                    luu.list[luu.n].p.Color = form._p.Color;
                    luu.list[luu.n].p.Width = form._p.Width;
                    luu.list[luu.n].p.EndCap = form._p.EndCap;
                    luu.list[luu.n].p.DashStyle = form._p.DashStyle;
                    luu.list[luu.n].p.DashCap = form._p.DashCap;
                    luu.list[luu.n].p.StartCap = form._p.StartCap;
                    luu.n++;
                    n = luu.n;
                }
            }
            else if (form.tool.isCircle)
            {
                if (form.tool.isFill)
                {
                    Brush _br = new SolidBrush(form._p.Color);
                    g.DrawEllipse(form._p, form.rec);
                    g.FillEllipse(_br, form.rec);

                    luu.list[luu.n] = new H();
                    luu.list[luu.n].p.Color = form._p.Color;
                    luu.list[luu.n].p.Width = form._p.Width;
                    luu.list[luu.n].p.EndCap = form._p.EndCap;
                    luu.list[luu.n].p.DashStyle = form._p.DashStyle;
                    luu.list[luu.n].p.DashCap = form._p.DashCap;
                    luu.list[luu.n].p.StartCap = form._p.StartCap;
                    luu.list[luu.n].path.AddEllipse(form.rec);
                    luu.list[luu.n].br = _br;
                    luu.list[luu.n].mode = 2;
                    luu.n++;
                    n = luu.n;
                }
                else
                {
                    g.DrawEllipse(form._p, form.rec);
                    luu.list[luu.n] = new H();
                    luu.list[luu.n].path.AddEllipse(form.rec);
                    luu.list[luu.n].p.Color = form._p.Color;
                    luu.list[luu.n].p.Width = form._p.Width;
                    luu.list[luu.n].p.EndCap = form._p.EndCap;
                    luu.list[luu.n].p.DashStyle = form._p.DashStyle;
                    luu.list[luu.n].p.DashCap = form._p.DashCap;
                    luu.list[luu.n].p.StartCap = form._p.StartCap;
                    luu.n++;
                    n = luu.n;
                }
            }
            else if (form.tool.isTriangle)
            {

                if (form.tool.isFill)
                {
                    Brush _br = new SolidBrush(form._p.Color);
                    form.DrawTriagle(form.rec, g, form._p);
                    form.FillTriagle(form.rec, g, _br);
                    luu.list[luu.n] = new H();
                    luu.list[luu.n].p.Color = form._p.Color;
                    luu.list[luu.n].p.Width = form._p.Width;
                    luu.list[luu.n].p.EndCap = form._p.EndCap;
                    luu.list[luu.n].p.DashStyle = form._p.DashStyle;
                    luu.list[luu.n].p.DashCap = form._p.DashCap;
                    luu.list[luu.n].p.StartCap = form._p.StartCap;
                    luu.list[luu.n].path.AddPolygon(form.tri_points);
                    luu.list[luu.n].br = _br;
                    luu.list[luu.n].mode = 2;
                    luu.n++;
                    n = luu.n;
                }
                else
                {
                    form.DrawTriagle(form.rec, g, form._p);
                    luu.list[luu.n] = new H();
                    luu.list[luu.n].path.AddPolygon(form.tri_points);
                    luu.list[luu.n].p.Color = form._p.Color;
                    luu.list[luu.n].p.Width = form._p.Width;
                    luu.list[luu.n].p.EndCap = form._p.EndCap;
                    luu.list[luu.n].p.DashStyle = form._p.DashStyle;
                    luu.list[luu.n].p.DashCap = form._p.DashCap;
                    luu.list[luu.n].p.StartCap = form._p.StartCap;
                    luu.n++;
                    n = luu.n;
                }

            }
            else if(form.tool.isCrop)
            {

            }
            
            
        }
        #region phong to thu nho
        public void phongtothunho(Form1 form)
        {
            ima = new Bitmap(this.Image);
            form.pt_draw.Size = new Size(form.hesonhan * this.Width / 10, form.hesonhan * this.Height / 10);
            this.Width = form.pt_draw.Width;
            this.Height = form.pt_draw.Height;
            this.Image = new Bitmap(this.Width, this.Height);
            bm = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(ima, new Rectangle(0, 0, this.Width, this.Height));
            this.Image.Dispose();
            this.Image = new Bitmap(bm);
        }
        #endregion



        #endregion
        public void velai(Form1 form, PictureBox ptb)
        {
            Graphics g = ptb.CreateGraphics();
            g.Clear(Color.White);
            if (form.isPic)
            {
                form.pt_draw.Image = form.img;
                form.isPic = false;
            }

            g.SmoothingMode = SmoothingMode.HighQuality;

            for (int i = 0; i < luu.n; i++)
            {
                
                    g.DrawPath(luu.list[i].p, luu.list[i].path);
                    if (luu.list[i].mode == 2)
                    {
                        g.FillPath(luu.list[i].br, luu.list[i].path);
                        if (luu.list[i].br == Brushes.White)
                            g.DrawPath(luu.list[i].p, luu.list[i].path);
                    }
                

            }
        }


    }
}
