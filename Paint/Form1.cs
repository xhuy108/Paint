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

namespace Paint
{
    public partial class Form1 : Form
    {
        bool draw = false;
        Pen pen = new Pen(Color.Black);
        
        Point lastPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MenuStripRenderer();
            
            
        }

        private static Color MainColor = Color.DimGray;
        private static float Size = 10;

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
            pen = new Pen(MainColor, Size);
            if (draw == true)
            {
                if (lastPoint != null)
                {
                    if (ptb_paint.Image == null)
                    {
                        Bitmap bmp = new Bitmap(ptb_paint.Width, ptb_paint.Height);
                        ptb_paint.Image = bmp;
                    }
                    using (Graphics g = Graphics.FromImage(ptb_paint.Image))
                    {
                        g.DrawLine(pen, lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        lastPoint = e.Location;

                    }
                    ptb_paint.Invalidate();

                }
            }
        }

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
           
            MainColor = Color.DimGray;
        }
    }
}
