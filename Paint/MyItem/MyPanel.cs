using Paint.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Drawing2D;

namespace Paint.MyItem
{
    public partial class MyPanel : Panel
    {
        // cho phep ve
        public bool allowDraw { get; set; }
        // list cac danh sach
        public List<MyPtb> list_ptb;
        // diem lan cuoi nhan chuot
        public Point lastPoint { get; set; }
        // diem ve
        public Point startPoint { get; set; }
        // cho biết shape cần vẽ
        public MyData Data = new MyData(); 

        Graphics _g;
        public MyPanel()
        {
            list_ptb = new List<MyPtb>();
            
            DoubleBuffered = true;
        }
        
        public void update(MyData data)
        {
            Data.UndoStackImage = data.UndoStackImage;
            Data.RedoStackImage = data.RedoStackImage;
            Data.shapeSelected_index = data.shapeSelected_index;
            Data._color = data._color;
            Data._size = data._size;
            Data.isMouseCrossCtrl = data.isMouseCrossCtrl;
            Data.isRedo = data.isRedo;
            Data.isUndo = data.isUndo;
        }
        public void updateData(MyData data)
        {
            data.UndoStackImage = Data.UndoStackImage;
            data.RedoStackImage = Data.RedoStackImage;
        }
       

    }
}
