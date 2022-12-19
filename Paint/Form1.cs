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
        public MyData data_paint = new MyData();
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menuStrip1.Renderer = new MenuStripRenderer();
            panel_paint.update(data_paint);
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
        
        private void importfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPtb _myptb = new MyPtb(panel_paint);
            OpenImage(_myptb);
            _myptb.ptb_index = count_ptb;
            count_ptb++;
            panel_paint.list_ptb.Add(_myptb);
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            panel_paint.Undo_Click();
            panel_paint.updateData(data_paint);
        }
    }
}
