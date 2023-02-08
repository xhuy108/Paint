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
        public void vehinh(Form1 form, Rectangle rec)
        {
            Rectangle rec1 = new Rectangle(rec.Location.X * 10 / form.hesonhan, rec.Location.Y * 10 / form.hesonhan, rec.Width * 10 / form.hesonhan, rec.Height * 10 / form.hesonhan);
            #region điểm đầu cuối
            if (form.pt_draw.Visible)
            {
                //a.X = form.mousedownptmain.X - form.pt_draw.Location.X;
                //a.Y = form.mousedownptmain.Y - form.pt_draw.Location.Y;
                //b.X = form.mousemuveptmain.X - form.pt_draw.Location.X;
                //b.Y = form.mousemuveptmain.Y - form.pt_draw.Location.Y;
                a = form.Brush_A;
                b = form.Brush_B;
                if (xet == 0)
                {
                    pion[0] = new Point(a.X, a.Y);
                    pion[1] = new Point(a.X, a.Y);
                    pion[2] = new Point(b.X, b.Y);
                    pion[3] = new Point(b.X, b.Y);
                }
            }
            #endregion

            #region vẽ hình chữ nhật
            if (form.tool.isRect == true)
            {
                if (form.tool.isFill == false)
                {
                    if (form.pt_draw.BackgroundImage != null)
                    {
                        Graphics g = Graphics.FromImage(form.pt_draw.BackgroundImage);
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.DrawRectangle(form._p, 5, 5, form.pt_draw.Width - 10, form.pt_draw.Height - 10);
                        if (form.pt_draw.Visible == false)
                        {
                            Graphics f = Graphics.FromImage(this.Image);
                            f.SmoothingMode = SmoothingMode.HighQuality;
                            f.DrawRectangle(form._p, rec);
                            luu.list[luu.n] = new H();
                            luu.list[luu.n].path.AddRectangle(rec1);
                            luu.list[luu.n].vepen = 1;
                            luu.list[luu.n].size = new Size(Width * 10 / form.hesonhan, Height * 10 / form.hesonhan);
                            luu.list[luu.n].p = form._p;
                            luu.n++;
                            n = luu.n;
                        }
                    }
                }
                else
                {
                    if (rec.Width > 4 && rec.Height > 4 && form.pt_draw.Image != null)
                    {
                        Graphics g = Graphics.FromImage(form.pt_draw.Image);
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        if (form.ptbd3.BorderStyle == BorderStyle.Fixed3D)
                            g.FillRectangle(form.co, 5, 5, form.pt_draw.Width - 10, form.pt_draw.Height - 10);
                        else
                        {
                            g.FillRectangle(Brushes.White, 5, 5, form.pt_draw.Width - 10, form.pt_draw.Height - 10);
                            g.DrawRectangle(form._p, 5, 5, form.pt_draw.Width - 10, form.pt_draw.Height - 10);
                        }
                    }
                    if (form.pt_draw.Visible == false)
                    {
                        Graphics f = Graphics.FromImage(this.Image);
                        f.SmoothingMode = SmoothingMode.HighQuality;
                        luu.list[luu.n] = new H();
                        if (form.ptbd3.BorderStyle == BorderStyle.Fixed3D)
                        {
                            f.FillRectangle(form.co, rec);
                            luu.list[luu.n].br = form.co;
                        }
                        else
                        {
                            f.FillRectangle(Brushes.White, rec);
                            luu.list[luu.n].br = Brushes.White;
                            f.DrawRectangle(form._p, rec);
                            luu.list[luu.n].p = form._p;
                        }
                        luu.list[luu.n].path.AddRectangle(rec1);
                        luu.list[luu.n].vepen = 2;
                        luu.list[luu.n].size = new Size(Width * 10 / form.hesonhan, Height * 10 / form.hesonhan);
                        luu.n++;
                        n = luu.n;
                    }
                }
            }
            #endregion

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
        public void velai(Form1 form)
        {
            if (luu.n == 0)
                this.Image = new Bitmap(this.Width, this.Height);
            else
                this.Image = new Bitmap(luu.list[luu.n - 1].size.Width, luu.list[luu.n - 1].size.Height);
            Graphics g = Graphics.FromImage(this.Image);
            g.SmoothingMode = SmoothingMode.HighQuality;
            for (int i = 0; i < luu.n; i++)
            {
                form.pt_draw.Size = new Size(luu.list[i].size.Width, luu.list[i].size.Height);
                this.Width = luu.list[i].size.Width;
                this.Height = luu.list[i].size.Height;
                this.Size = new Size(luu.list[i].size.Width, luu.list[i].size.Height);
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
        public void vehinhtheotoado(Form1 form, Rectangle rec)
        {
            GraphicsPath path2 = new GraphicsPath();
            if (rec.Width > 4 && rec.Height > 4 && form.pt_draw.Image != null)
            {
                Graphics g = Graphics.FromImage(form.pt_draw.Image);
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
                    g.DrawPath(form._p, path);
                    if (form.pt_draw.Visible == false)
                    {
                        Graphics f = Graphics.FromImage(this.Image);
                        Graphics w = CreateGraphics();
                        f.SmoothingMode = SmoothingMode.HighQuality;
                        w.SmoothingMode = SmoothingMode.HighQuality;
                        luu.list[luu.n] = new H();
                        for (int i = 0; i < npoin - 1; i++)
                        {
                            luu.list[luu.n].path.AddLine((poin1[i].X + form.pt_draw.Location.X) * 10 / form.hesonhan, (poin1[i].Y + form.pt_draw.Location.Y) * 10 / form.hesonhan, (poin1[i + 1].X + form.pt_draw.Location.X) * 10 / form.hesonhan, (poin1[i + 1].Y + form.pt_draw.Location.Y) * 10 / form.hesonhan);
                        }
                        for (int i = 0; i < npoin - 1; i++)
                        {
                            path2.AddLine(poin1[i].X + form.pt_draw.Location.X, poin1[i].Y + form.pt_draw.Location.Y, poin1[i + 1].X + form.pt_draw.Location.X, poin1[i + 1].Y + form.pt_draw.Location.Y);
                        }
                        f.DrawPath(form._p, path2);
                        w.DrawPath(form._p, path2);
                        luu.list[luu.n].vepen = 1;
                        luu.list[luu.n].size = new Size(Width * 10 / form.hesonhan, Height * 10 / form.hesonhan);
                        luu.list[luu.n].p = form._p;
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
                        g.DrawPath(form._p, path);
                    }
                    if (form.pt_draw.Visible == false)
                    {
                        Graphics f = Graphics.FromImage(this.Image);
                        Graphics w = CreateGraphics();
                        w.SmoothingMode = SmoothingMode.HighQuality;
                        f.SmoothingMode = SmoothingMode.HighQuality;
                        luu.list[luu.n] = new H();
                        for (int i = 0; i < npoin - 1; i++)
                        {
                            luu.list[luu.n].path.AddLine((poin1[i].X + form.pt_draw.Location.X) * 10 / form.hesonhan, (poin1[i].Y + form.pt_draw.Location.Y) * 10 / form.hesonhan, (poin1[i + 1].X + form.pt_draw.Location.X) * 10 / form.hesonhan, (poin1[i + 1].Y + form.pt_draw.Location.Y) * 10 / form.hesonhan);
                        }
                        for (int i = 0; i < npoin - 1; i++)
                        {
                            path2.AddLine(poin1[i].X + form.pt_draw.Location.X, poin1[i].Y + form.pt_draw.Location.Y, poin1[i + 1].X + form.pt_draw.Location.X, poin1[i + 1].Y + form.pt_draw.Location.Y);
                        }
                        if (form.ptbd3.BorderStyle == BorderStyle.Fixed3D)
                        {
                            f.FillPath(form.co, path2);
                            w.FillPath(form.co, path2);
                            luu.list[luu.n].br = form.co;
                        }
                        else
                        {
                            f.FillPath(Brushes.White, path2);
                            w.FillPath(Brushes.White, path2);
                            luu.list[luu.n].br = Brushes.White;
                            f.DrawPath(form._p, luu.list[luu.n].path);
                            w.DrawPath(form._p, luu.list[luu.n].path);
                            luu.list[luu.n].p = form._p;
                        }
                        luu.list[luu.n].vepen = 2;
                        luu.list[luu.n].size = new Size(Width * 10 / form.hesonhan, Height * 10 / form.hesonhan);
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
            if (form.pt_draw.Width > 0 && form.pt_draw.Height > 0)
            {
                form.pt_draw.BackgroundImage = new Bitmap(form.pt_draw.Width, form.pt_draw.Height);
                Graphics g = Graphics.FromImage(form.pt_draw.BackgroundImage);
                Pen t = new Pen(Color.Black, 2);
                g.DrawImage(this.Image, 0, 0, tam, GraphicsUnit.Pixel);
                g.DrawRectangle(t, new Rectangle(0, 0, form.pt_draw.Width, form.pt_draw.Height));
                g.DrawLine(t, form.pt_draw.Width / 2, form.pt_draw.Height - 3, form.pt_draw.Width / 2, form.pt_draw.Height);
                g.DrawLine(t, form.pt_draw.Width - 3, form.pt_draw.Height / 2, form.pt_draw.Width, form.pt_draw.Height / 2);
                g.DrawLine(t, form.pt_draw.Width - 3, form.pt_draw.Height - 2, form.pt_draw.Width, form.pt_draw.Height - 2);
            }
        }
        #endregion
    }
}
