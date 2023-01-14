using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paint.MyItem;

namespace Paint.MyBrush
{
    internal class PenOpacity : TrackBar
    {
        public MyPanel myPanel;
        public PenOpacity()
        {
            myPanel = new MyPanel();
        }

        public PenOpacity(MyPanel myPanel)
        {
            this.myPanel = myPanel;
        }

        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);
            //myPanel.Data. = this.Value;
            myPanel.update(myPanel.Data);
        }

    }
}
