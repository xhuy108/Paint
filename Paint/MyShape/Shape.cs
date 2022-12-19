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

namespace Paint
{
    public abstract class Shape : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        // cho biết index
        public int index { get; set; }
        // cho biết ten
        public string name { get; set; }
        // xem có duoc chon
        public bool isSelect { get; set; }
        // cho biết điểm đầu của hình
        public Point pointHead { get; set; }

        // cho biết điểm cuối của hình
        public Point pointTail { get; set; }

        // cho biết hình đang được chọn hay không
        public bool isSelected { get; set; }

        // cho biết độ dày đường viền hình vẽ
        public int contourWidth { get; set; }

        // cho biết hình vẽ có ở chế độ tô màu hay không
        public bool isFill { get; set; }

        // cho biết màu sắc của hình
        public Color color { get; set; }

        // cho biết size
        public int size { get; set; }
        // vẽ shape


    }
}
