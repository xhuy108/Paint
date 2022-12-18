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

using Paint.MyShape;
using Paint.MyAct;


namespace Paint
{
    public partial class Form1 : Form
    {
        private static Color MainColor = Color.Black;
        private static int Size = 10;

        bool draw = false;
        MPen pen = new MPen(Color.Black, Size);

        Image _img;
        
        private Graphics gr;

        Point lastPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menuStrip1.Renderer = new MenuStripRenderer();
            gr = ptb_paint.CreateGraphics();
            
        }

        
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
        private void ptb_paint_MouseMove(object sender, MouseEventArgs e)
        {
            
           
        }
        //private void ptb_paint_MouseMove(object sender, MouseEventArgs e)
        //{
        //    pen = new Pen(MainColor, Size);
        //    if (draw == true)
        //    {
        //        if (lastPoint != null)
        //        {
        //            if (ptb_paint.Image == null)
        //            {
        //                Bitmap bmp = new Bitmap(ptb_paint.Width, ptb_paint.Height);
        //                ptb_paint.Image = bmp;
        //            }
        //            using (Graphics g = Graphics.FromImage(ptb_paint.Image))
        //            {
        //                g.DrawLine(pen, lastPoint, e.Location);
        //                g.SmoothingMode = SmoothingMode.AntiAlias;
        //                lastPoint = e.Location;

        //            }
        //            ptb_paint.Invalidate();

        //        }
        //    }
        //}

        private void ptb_paint_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            lastPoint = e.Location;
            
        }
        //SolidColorBrush: Paints an area with a solid Color.

//LinearGradientBrush: Paints an area with a linear gradient.

//RadialGradientBrush: Paints an area with a radial gradient.

//ImageBrush: Paints an area with an image(represented by an ImageSource object).

//DrawingBrush: Paints an area with a Drawing.The drawing may include vector and bitmap objects.

//VisualBrush: Paints an area with a Visual object. 
        private void ptb_paint_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            lastPoint = Point.Empty;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
           
        }

        // mo file
        public void onClickMouseMove(Point p, Point lastPoint, Shape pen, PictureBox ptb)
        {
            if (draw == true)
            {
                Brush brush = new SolidBrush(pen.color);
                if (lastPoint != null)
                {
                    if (ptb.Image == null)
                    {
                        Bitmap bmp = new Bitmap(ptb.Width, ptb.Height);
                        ptb.Image = bmp;
                    }
                    using (Graphics g = Graphics.FromImage(ptb.Image))
                    {
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        
                        g.FillRectangle(brush, new System.Drawing.Rectangle(p.X, p.Y, pen.size, pen.size));
                        g.FillRectangle(brush, new System.Drawing.Rectangle(p.X, p.Y, pen.size, pen.size));
                        lastPoint = p;
                    }
                    ptb.Invalidate();

                }
            }
        }

        
        public void OpenImage(PictureBox picturebox)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.png;*.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg; *.jpeg; *.gif; *.bmp";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picturebox.Image = new Bitmap(openFile.FileName);
                picturebox.Size = panel_paint.Size;
                
            }
        }
        

        
        private void importfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OpenImage(ptb_paint);
        }

        private void ptb_paint_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        }
    }
}
