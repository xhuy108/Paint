using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Manager
{
    public class SelectedTool
    {
        public bool isBrush { get; set; }
        public bool isLine { get; set; }
        public bool isCurve { get; set; }
        public bool isRect { get; set; }
        public bool isCircle { get; set; }
        public bool isTriangle { get; set; }
        public bool isHexagon { get; set; }
        public bool isFill { get; set; }
        public SelectedTool()
        {
            isBrush = false;
            isLine = false;
            isCurve = false;
            isRect = false;
            isCircle = false;
            isTriangle = false;
            isHexagon = false;
            isFill = false;
        }
    }
}
