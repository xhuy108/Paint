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
        public bool isRect { get; set; }
        public bool isCircle { get; set; }
        public bool isTriangle { get; set; }
        public bool isFill { get; set; }
        public bool isBucket { get; set; }
        public bool isColorPicker { get; set; }

        public bool isCrop { get; set; }
        public bool isText { get; set; }
        public SelectedTool()
        {
            isBrush = false;
            isLine = false;
            isRect = false;
            isCircle = false;
            isTriangle = false;
            isFill = false;
            isBucket = false;
            isColorPicker = false;
            isText = false;
            isCrop = false;
        }
    }
}
