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
        #region keo
        public void vekeo()
        {
            ima = new Bitmap(this.Image);
            bm = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(ima, 0, 0, new Rectangle(0, 0, this.Width, this.Height), GraphicsUnit.Pixel);
            this.Image.Dispose();
            this.Image = new Bitmap(bm);
            luu.list[luu.n] = new H();
            luu.list[luu.n].saveim = new Bitmap(bm);
            luu.list[luu.n].rec = new Rectangle(0, 0, Width, Height);
            luu.list[luu.n].vepen = 3;
            luu.list[luu.n].size = new Size(Width, Height);
            luu.n++;
            n = luu.n;
        }
        #endregion
        #region vẽ
        public void vehinh(Form1 form, Rectangle rec, Graphics g)
        {
            
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
            g.SmoothingMode = SmoothingMode.HighQuality;
            
            
            for (int i = 0; i < luu.n; i++)
            {
                if (luu.list[i].vepen == 1)
                    g.DrawPath(luu.list[i].p, luu.list[i].path);
                if (luu.list[i].vepen == 2)
                {
                    g.FillPath(luu.list[i].br, luu.list[i].path);
                    if (luu.list[i].br == Brushes.White)
                    g.DrawPath(luu.list[i].p, luu.list[i].path);
                }
                if (luu.list[i].vepen == 3)
                    g.DrawImage(luu.list[i].saveim, luu.list[i].rec);
            }
        }
     
        
    }
}
