using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Paint.MyShape;
using Paint.Manager;
using Paint.MyItem;

namespace Paint
{
    public partial class Form_shape_selected : Form
    {
        MyData F2;
        public Form_shape_selected(MyData F1)
        {
            F2 = F1;
            InitializeComponent();
        }
        protected override void OnClosed(EventArgs e)
        {

            base.OnClosed(e);
        }

    }
}
