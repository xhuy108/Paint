using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Paint.MyItem;

namespace AboControls.ExtendedControls
{
    [DefaultEvent("ColorPicked")]
    public class ColorPickerControl : Control
    {
        public MyPanel panel;
        public Bitmap _canvas;
        private Graphics _graphicsBuffer;
        private LinearGradientBrush _spectrumGradient, _blackBottomGradient, _whiteTopGradient;
        private float _boxSizeRatio = 0.15f; // In percent
        private float _paddingPercentage = 0.05f;
        private Color _selectedColor;
        public Color SelectedColor 
        {
            get
            {
                return _selectedColor;
            }
            set 
            { 
                panel.Data._color = value;
                panel.update(panel.Data);
            }
        }
        public event EventHandler ColorPicked;


        public ColorPickerControl()
        {
            base.Cursor = Cursors.Hand;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);

            this.Size = new Size(200, 100);
            UpdateLinearGradientBrushes();
            UpdateGraphicsBuffer();
            panel = new MyPanel();
        }

        protected virtual void OnColorPicked()
        {
            if (ColorPicked != null) 
                ColorPicked(this, EventArgs.Empty);
        }

        private void UpdateLinearGradientBrushes()
        {
            // Update spectrum gradient
            _spectrumGradient = new LinearGradientBrush (Point.Empty, new Point(this.Width, 0), Color.White, Color.White);
            ColorBlend blend = new ColorBlend();
            blend.Positions = new[] { 0, 1 / 7f, 2 / 7f, 3 / 7f, 4 / 7f, 5 / 7f, 6 / 7f, 1 };
            blend.Colors = new[] { Color.Gray, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
            _spectrumGradient.InterpolationColors = blend;
            // Update greyscale gradient
            RectangleF rect = new RectangleF(0, this.Height * 0.7f, this.Width, this.Height * 0.3F);
            _blackBottomGradient = new LinearGradientBrush(rect, Color.Transparent, Color.Black, 90f);
            rect = new RectangleF(Point.Empty, new SizeF(this.Width, this.Height * 0.3F));
            _whiteTopGradient = new LinearGradientBrush(rect, Color.White, Color.Transparent, 90f);
        }

        private void UpdateGraphicsBuffer()
        {
            if (this.Width > 0)
            {
                _canvas = new Bitmap(this.Width, this.Height);
                _graphicsBuffer = Graphics.FromImage(_canvas);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateLinearGradientBrushes();
            UpdateGraphicsBuffer();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            SelectedColor = _canvas.GetPixel(e.X, e.Y);
            OnColorPicked();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            _graphicsBuffer.FillRectangle(_spectrumGradient, this.ClientRectangle);
            _graphicsBuffer.FillRectangle(_blackBottomGradient, 0, this.Height * 0.7f + 1, this.Width, this.Height * 0.3f);
            _graphicsBuffer.FillRectangle(_whiteTopGradient, 0, 0, this.Width, this.Height * 0.3f);
            e.Graphics.DrawImageUnscaled(_canvas, Point.Empty);
        }     

        [DefaultValue(0.15f)]
        [Description("The size of the color boxes in relation to the parent control")]
        [Category("Layout")]
        public float ColorBoxSizeRatio
        {
            get { return _boxSizeRatio; }
            set
            {
                _boxSizeRatio = value;
            }
        }

        [DefaultValue(0.05f)]
        [Description("The size of the color boxes in relation to the parent control")]
        [Category("Layout")]

        
        public float ColorBoxPaddingRatio
        {
            get { return _paddingPercentage; }
            set
            {
                _paddingPercentage = value;
            }
        }

        private bool _fullColorSpectrum = true;
        [DefaultValue(true)]
        [Description(@"Determines whether or not to use a full color spectrum for color picking.
                If set to false, a RGB spectrum will be used")]
        [Category("Appearance")]
        public bool FullColorSpectrum
        {
            get { return _fullColorSpectrum; }
            set
            {
                _fullColorSpectrum = value;
                UpdateLinearGradientBrushes();
                this.Invalidate(false);
            }
        }
    }
}
