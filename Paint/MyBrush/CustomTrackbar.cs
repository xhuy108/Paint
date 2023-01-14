using Paint.MyItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.MyBrush
{
    internal class CustomTrackbar: TrackBar
    {
        MyPanel panel;
         
        CustomTrackbar(MyPanel panel)
        {
            this.panel = panel;
        }


    }
}
