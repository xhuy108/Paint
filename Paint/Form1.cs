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
using Paint.Manager;
using Paint.MyItem;

namespace Paint
{
    public partial class Form1 : Form
    {

        private static Color MainColor = Color.Black;
        private static int Size = 10;
        private int count_ptb = 0;
        // chỗ lưu tất cả data
        public MyData data_paint = new MyData();

        bool draw = false;
        MyPen pen = new MyPen(Color.Black, Size);
        Image _img;
        private Graphics gr;

        Point lastPoint = Point.Empty;
        
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menuStrip1.Renderer = new MenuStripRenderer();
            panel_paint.update(data_paint);
        }

        #region Menu color
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

            public override Color MenuBorder
            {
                get { return MainColor; }
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            data_paint._color = Color.Pink;
            panel_paint.update(data_paint);
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
            panel_paint.list_ptb.Add(_myptb);
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
            //panel_paint.Undo_Click();
            panel_paint.updateData(data_paint);
        }

        private void btn_Shape_Click(object sender, EventArgs e)
        {
            tLP_Shape.Visible = true;
        }
    }
}
