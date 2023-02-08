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

    class MyData : PictureBox
    {
        #region biến và hàm khởi tạo
        public History luu = new History() ;
        public bool tam = true;
        public Point a = new Point();
        public Point b = new Point();
        public Point mousedown = new Point();
        public Point[] poin = new Point[100000];
        public int npoin = 0;
        public Point[] poin1;
        private Image ima, bm;
        private GraphicsPath path = new GraphicsPath();
        public Point[] pion = new Point[4];
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
            luu.sd[luu.n] = new H();
            luu.sd[luu.n].saveim = new Bitmap(bm);
            luu.sd[luu.n].rec = new Rectangle(0, 0, Width, Height);
            luu.sd[luu.n].vepen = 3;
            luu.sd[luu.n].size = new Size(Width, Height);
            luu.n++;
            n = luu.n;
        }
        #endregion
        #region vẽ
        public void vehinh(Form1 form, Rectangle rec)
        {
            Rectangle rec1 = new Rectangle(rec.Location.X * 10 / form.hesonhan, rec.Location.Y * 10 / form.hesonhan, rec.Width * 10 / form.hesonhan, rec.Height * 10 / form.hesonhan);
            #region điểm đầu cuối
            if (form.panel_paint.Visible)
            {
                a.X = form.panel_paint.Location.X;
                a.Y = form.panel_paint.Location.Y;
                b.X = form.panel_paint.Location.X;
                b.Y = form.panel_paint.Location.Y;
                if (xet == 0)
                {
                    pion[0] = new Point(a.X, a.Y);
                    pion[1] = new Point(a.X, a.Y);
                    pion[2] = new Point(b.X, b.Y);
                    pion[3] = new Point(b.X, b.Y);
                }
            }
            #endregion
            
            #region vẽ đường thẳng
            if (form.tline.Checked)
            {
                if (form.ptbd1.BorderStyle == BorderStyle.Fixed3D)
                {
                    if (form.ptve.Image != null)
                    {
                        tanghinh(form, rec);
                        Graphics g = Graphics.FromImage(form.ptve.Image);
                        g.SmoothingMode = SmoothingMode.HighQuality;

                        g.DrawLine(form.but, a, b);
                        if (form.ptve.Visible == false)
                        {
                            Graphics w = CreateGraphics();
                            w.SmoothingMode = SmoothingMode.HighQuality;
                            Graphics f = Graphics.FromImage(this.Image);
                            f.SmoothingMode = SmoothingMode.HighQuality;
                            f.DrawLine(form.but, a.X + rec.Location.X - 5, a.Y + rec.Location.Y - 5, b.X + rec.Location.X - 5, b.Y + rec.Location.Y - 5);
                            w.DrawLine(form.but, a.X + rec.Location.X - 5, a.Y + rec.Location.Y - 5, b.X + rec.Location.X - 5, b.Y + rec.Location.Y - 5);
                            luu.sd[luu.n] = new savedr();
                            luu.sd[luu.n].path.AddLine(a.X + rec1.Location.X - 5, a.Y + rec1.Location.Y - 5, b.X + rec1.Location.X - 5, b.Y + rec1.Location.Y - 5);
                            luu.sd[luu.n].vepen = 1;
                            luu.sd[luu.n].size = new Size(Width * 10 / form.hesonhan, Height * 10 / form.hesonhan);
                            luu.sd[luu.n].p = form.but;
                            luu.n++;
                            n = luu.n;
                        }
                    }
                }
            }
            #endregion
           
        }
        #region phong to thu nho
        public void phongtothunho(Form1 form)
        {
            ima = new Bitmap(this.Image);
            form.ptmain.Size = new Size(form.hesonhan * this.Width / 10, form.hesonhan * this.Height / 10);
            this.Width = form.ptmain.Width;
            this.Height = form.ptmain.Height;
            this.Image = new Bitmap(this.Width, this.Height);
            bm = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(ima, new Rectangle(0, 0, this.Width, this.Height));
            this.Image.Dispose();
            this.Image = new Bitmap(bm);
        }
        #endregion
        #endregion
        public void velai(Form1 form)
        {
            if (luu.n == 0)
                this.Image = new Bitmap(this.Width, this.Height);
            else
                this.Image = new Bitmap(luu.sd[luu.n - 1].size.Width, luu.sd[luu.n - 1].size.Height);
            Graphics g = Graphics.FromImage(this.Image);
            g.SmoothingMode = SmoothingMode.HighQuality;
            for (int i = 0; i < luu.n; i++)
            {
                form.panel_paint.Size = new Size(luu.sd[i].size.Width, luu.sd[i].size.Height);
                this.Width = luu.sd[i].size.Width;
                this.Height = luu.sd[i].size.Height;
                this.Size = new Size(luu.sd[i].size.Width, luu.sd[i].size.Height);
                if (luu.sd[i].vepen == 1)
                    g.DrawPath(luu.sd[i].p, luu.sd[i].path);
                if (luu.sd[i].vepen == 2)
                {
                    g.FillPath(luu.sd[i].br, luu.sd[i].path);
                    if (luu.sd[i].br == Brushes.White)
                        g.DrawPath(luu.sd[i].p, luu.sd[i].path);
                }
                if (luu.sd[i].vepen == 3)
                    g.DrawImage(luu.sd[i].saveim, luu.sd[i].rec);
            }
        }
        public void vehinhtheotoado(Form1 form, Rectangle rec)
        {
            GraphicsPath path2 = new GraphicsPath();
            if (rec.Width > 4 && rec.Height > 4 && form.ptve.Image != null)
            {
                Graphics g = Graphics.FromImage(form.ptve.Image);
                g.SmoothingMode = SmoothingMode.HighQuality;
                path = new GraphicsPath();
                for (int i = 0; i < npoin - 1; i++)
                {
                    path.AddLine(poin1[i], poin1[i + 1]);
                    if (i == npoin - 2)
                        path.AddLine(poin1[npoin - 1], poin1[0]);
                }
                if (form.ptbd1.BorderStyle == BorderStyle.Fixed3D)
                {
                    g.DrawPath(form.but, path);
                    if (form.ptve.Visible == false)
                    {
                        Graphics f = Graphics.FromImage(this.Image);
                        Graphics w = CreateGraphics();
                        f.SmoothingMode = SmoothingMode.HighQuality;
                        w.SmoothingMode = SmoothingMode.HighQuality;
                        luu.sd[luu.n] = new savedr();
                        for (int i = 0; i < npoin - 1; i++)
                        {
                            luu.sd[luu.n].path.AddLine((poin1[i].X + form.ptve.Location.X) * 10 / form.hesonhan, (poin1[i].Y + form.ptve.Location.Y) * 10 / form.hesonhan, (poin1[i + 1].X + form.ptve.Location.X) * 10 / form.hesonhan, (poin1[i + 1].Y + form.ptve.Location.Y) * 10 / form.hesonhan);
                        }
                        for (int i = 0; i < npoin - 1; i++)
                        {
                            path2.AddLine(poin1[i].X + form.ptve.Location.X, poin1[i].Y + form.ptve.Location.Y, poin1[i + 1].X + form.ptve.Location.X, poin1[i + 1].Y + form.ptve.Location.Y);
                        }
                        f.DrawPath(form.but, path2);
                        w.DrawPath(form.but, path2);
                        luu.sd[luu.n].vepen = 1;
                        luu.sd[luu.n].size = new Size(Width * 10 / form.hesonhan, Height * 10 / form.hesonhan);
                        luu.sd[luu.n].p = form.but;
                        luu.n++;
                        n = luu.n;
                    }
                }
                else
                {
                    if (form.ptbd3.BorderStyle == BorderStyle.Fixed3D)
                    {
                        g.FillPath(form.co, path);
                    }
                    else
                    {
                        g.FillPath(Brushes.White, path);
                        g.DrawPath(form.but, path);
                    }
                    if (form.ptve.Visible == false)
                    {
                        Graphics f = Graphics.FromImage(this.Image);
                        Graphics w = CreateGraphics();
                        w.SmoothingMode = SmoothingMode.HighQuality;
                        f.SmoothingMode = SmoothingMode.HighQuality;
                        luu.sd[luu.n] = new savedr();
                        for (int i = 0; i < npoin - 1; i++)
                        {
                            luu.sd[luu.n].path.AddLine((poin1[i].X + form.ptve.Location.X) * 10 / form.hesonhan, (poin1[i].Y + form.ptve.Location.Y) * 10 / form.hesonhan, (poin1[i + 1].X + form.ptve.Location.X) * 10 / form.hesonhan, (poin1[i + 1].Y + form.ptve.Location.Y) * 10 / form.hesonhan);
                        }
                        for (int i = 0; i < npoin - 1; i++)
                        {
                            path2.AddLine(poin1[i].X + form.ptve.Location.X, poin1[i].Y + form.ptve.Location.Y, poin1[i + 1].X + form.ptve.Location.X, poin1[i + 1].Y + form.ptve.Location.Y);
                        }
                        if (form.ptbd3.BorderStyle == BorderStyle.Fixed3D)
                        {
                            f.FillPath(form.co, path2);
                            w.FillPath(form.co, path2);
                            luu.sd[luu.n].br = form.co;
                        }
                        else
                        {
                            f.FillPath(Brushes.White, path2);
                            w.FillPath(Brushes.White, path2);
                            luu.sd[luu.n].br = Brushes.White;
                            f.DrawPath(form.but, luu.sd[luu.n].path);
                            w.DrawPath(form.but, luu.sd[luu.n].path);
                            luu.sd[luu.n].p = form.but;
                        }
                        luu.sd[luu.n].vepen = 2;
                        luu.sd[luu.n].size = new Size(Width * 10 / form.hesonhan, Height * 10 / form.hesonhan);
                        luu.n++;
                        n = luu.n;
                    }
                }
            }
        }
        void racmau(Point x, Form1 form)
        {
            try
            {
                Random b = new Random();
                Bitmap a = new Bitmap(this.Image);
                for (int i = -form.ktnetrac; i < form.ktnetrac; i++)
                    for (int j = -form.ktnetrac; j < form.ktnetrac; j++)
                    {
                        if (b.Next() % 4 == 0 && (i * i + j * j) < form.ktnetrac * form.ktnetrac)
                        {
                            a.SetPixel(i + x.X, j + x.Y, form.color.BackColor);
                        }
                    }
                this.Image = new Bitmap(a);
            }
            catch { }
        }
        #region tang hinh picture
        public void tanghinh(Form1 form, Rectangle rec)
        {
            Rectangle tam = new Rectangle();
            Point tam2 = new Point();
            tam2.X = rec.X - 5;
            tam2.Y = rec.Y - 5;
            tam.Location = tam2;
            tam.Width = rec.Width + 10;
            tam.Height = rec.Height + 10;
            if (form.panel_paint.Width > 0 && form.panel_paint.Height > 0)
            {
                form.panel_paint.BackgroundImage = new Bitmap(form.panel_paint.Width, form.panel_paint.Height);
                Graphics g = Graphics.FromImage(form.panel_paint.BackgroundImage);
                Pen t = new Pen(Color.Black, 2);
                g.DrawImage(this.Image, 0, 0, tam, GraphicsUnit.Pixel);
                g.DrawRectangle(t, new Rectangle(0, 0, form.panel_paint.Width, form.panel_paint.Height));
                g.DrawLine(t, form.panel_paint.Width / 2, form.panel_paint.Height - 3, form.panel_paint.Width / 2, form.ptve.Height);
                g.DrawLine(t, form.panel_paint.Width - 3, form.panel_paint.Height / 2, form.panel_paint.Width, form.ptve.Height / 2);
                g.DrawLine(t, form.panel_paint.Width - 3, form.panel_paint.Height - 2, form.panel_paint.Width, form.ptve.Height - 2);
            }
        }
        #endregion
    }
}
