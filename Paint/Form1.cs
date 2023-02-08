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

using Paint.Manager;
using Paint.MyItem;

namespace Paint
{
    public partial class Form1 : Form
    {
        #region khai báo
        private static Color MainColor = Color.Black;
        
        private static int Size = 3;
        private int count_ptb = 0;
        Image _img;
        Graphics _g;
        // vị trí chuột
        public Point mousedownptmain = new Point();
        public Point mousemuveptmain = new Point();
        public Point mouseupptmain = new Point();
        public Point mousedownptve = new Point();
        public Point mousemuveptve = new Point();
        int x = -1;
        int y = -1;
        // cho phép vẽ
        bool allowDraw;
        // độ phóng to thu nhỏ
        public int hesonhan = 1;
        // danh sach ptb
        public List<MyPtb> list_ptb;
        Point lastPoint = Point.Empty;
        #endregion
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menuStrip1.Renderer = new MenuStripRenderer();
            
            _g = panel_paint.CreateGraphics();

            _g.SmoothingMode = SmoothingMode.AntiAlias;
            _g.Clear(BackColor);
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

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            
        }

        // mo file

        public void OpenImage(MyPtb picturebox)
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

        private void openfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPtb _myptb = new MyPtb(panel_paint);
            OpenImage(_myptb);
            _myptb.ptb_index = count_ptb;
            count_ptb++;
            this.list_ptb.Add(_myptb);
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
            textBox_RGBvalueChange();
        }

        private void colorBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorWheelToolStripMenuItem.Checked = false;
        }

        private void colorWheelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorBarToolStripMenuItem.Checked = false;
        }

        private void colorPicker_ColorPicked(object sender, EventArgs e)
        {
            pictureBox_Color_Front.BackColor = colorPicker.SelectedColor;
            textBox_RGBvalueChange();
        }

        private void colorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_ColorPreview.BackColor = colorPicker._canvas.GetPixel(e.X, e.Y);
        }
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox_Color_Front_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Text_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Shape_Click(object sender, EventArgs e)
        {
            tLP_Shape.Visible = true;
        }
        #region panel_paint paint
        private void panel_paint_MouseDown(object sender, MouseEventArgs e)
        {
            allowDraw = true;
            x = e.X;
            y = e.Y;
        }

        private void panel_paint_MouseUp(object sender, MouseEventArgs e)
        {
            allowDraw = false;
            x = -1;
            y = -1;
        }

        private void panel_paint_MouseMove(object sender, MouseEventArgs e)
        {
            int sive = 10;
            Pen p = new Pen(pictureBox_Color_Front.BackColor, sive);
            if (allowDraw && x != -1 && y != -1)
            {
                _g.DrawLine(p, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }
        #endregion
    }
}
