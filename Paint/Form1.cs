using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MenuStripRenderer();
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
                get { return Color.DimGray; }
            }

            public override Color MenuItemSelected
            {
                get { return Color.DimGray; }
            }

            public override Color MenuItemBorder
            {
                get { return Color.DimGray; }
            }

            public override Color MenuBorder
            {
                get { return Color.DimGray; }
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
    }
}
