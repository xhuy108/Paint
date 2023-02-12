using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using Paint.MyItem;
using Paint.Manager;



namespace Paint.MyBrush
{
    public class PenSize : TrackBar
    {
        public MyPanel myPanel;
       
        public PenSize()
        {
            myPanel = new MyPanel();
        }

        public PenSize(MyPanel myPanel)
        {
            this.myPanel = myPanel;
        }
      
        protected override void OnValueChanged(EventArgs e)
        {
            
            base.OnValueChanged(e);
            myPanel.Data._size = this.Value;
            myPanel.update(myPanel.Data);
        }
    }
}
