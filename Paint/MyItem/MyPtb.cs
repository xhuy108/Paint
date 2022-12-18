using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace Paint.MyItem
{
    public partial class MyPtb : PictureBox
    {
        // lay stt ptb
        public int ptb_index { get; set; }
        public bool isPtbSelected { get; set; }
        public MyPtb(MyPanel panel)
        {
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            isPtbSelected = false;
            panel.Controls.Add(this);
        }
        public MyPtb()
        {
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Enabled = true;
        }
        Point move;
        // di chuyen ptb
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            move = e.Location;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            
            if (e.Button == MouseButtons.Left && isPtbSelected == true )
            {
                this.Left += e.X - move.X;
                this.Top += e.Y - move.Y;
            }
            if(e.Button == MouseButtons.Left)
            {

            }
        }

        // phong to, thu nho ptb
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            //this.SizeMode = PictureBoxSizeMode.StretchImage;
            if ((e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract) )
            {
                Size t = new Size(this.Size.Width - 5, this.Size.Height - 5);
                using (Bitmap bm = new Bitmap(this.Image, t))
                {
                    this.Image = bm;
                }
            }
            if ((e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add) && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.Size = new Size(this.Size.Width + 5, this.Size.Height + 5);
            }
        }
        
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            isPtbSelected = true;
        }
    }
}
