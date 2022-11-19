namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

        Graphics g;
        Pen p = new Pen(Color.Black, 5);
        Pen erase = new Pen(Color.White, 30);
        bool allow = false;
        int idx = 0;
        
        Point start, move;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_marker_Click(object sender, EventArgs e)
        {
            idx = 1;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            allow = true;
            start = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            allow = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            idx = 2;
        }

        private void Clear_ptb_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            pictureBox1.Image = bm;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (allow)
            {
                if (idx == 1)
                {
                    move = e.Location;
                    g.DrawLine(p, start, move);
                    start = move;
                }
                if ( idx == 2)
                {
                    move = e.Location;
                    g.DrawLine(erase, start, move);
                    start = move;
                }
            }
            pictureBox1.Refresh();
        }
    }
}