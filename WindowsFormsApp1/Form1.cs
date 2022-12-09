using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }
        
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.DarkGray; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DarkGray; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.DarkGray; }
            }
        }

        
    }
}
