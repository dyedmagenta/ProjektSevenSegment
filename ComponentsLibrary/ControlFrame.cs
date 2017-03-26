using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ComponentsLibrary
{
    public partial class ControlFrame : UserControl
    {
        
        public enum FrameType
        {
            None, 
            Solid,
            Striped,
            Dotted
        }

        private FrameType _frame;
        public FrameType Frame
        {
            get { return _frame; }
            set
            {
                _frame = value;
                Invalidate();
            }
        }

        

        public int _thickness;
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }
        public Color FillColor
        {
            get { return _fillColor; }
            set
            {
                _fillColor = value;
                Invalidate();
            }
        }
        public Color SecondaryColor
        {
            get { return _secondaryColor; }
            set
            {
                _secondaryColor = value;
                Invalidate();
            }
        }

        public int Thickness
        {
            get { return _thickness; }
            set
            {
                _thickness = value;
                Invalidate();
            }
        }

        public Color _borderColor;
        public Color _fillColor;
        public Color _secondaryColor;

        public ControlFrame()
        {
            InitializeComponent();
            Frame = FrameType.None;
            BorderColor = Color.Black;
            FillColor = Color.SlateGray;
            SecondaryColor = Color.Crimson;
            Thickness = 5;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush;

            switch (Frame)
            {
                    case FrameType.Solid:
                        brush = new SolidBrush(FillColor);
                    break;
                    case FrameType.Striped:
                        brush = new HatchBrush(HatchStyle.DashedUpwardDiagonal, SecondaryColor, FillColor);
                    break;
                    case FrameType.Dotted:
                        brush = new HatchBrush(HatchStyle.DottedGrid, SecondaryColor, FillColor);
                    break;
                    default:
                        brush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
                    break;
            }
            e.Graphics.FillRectangles(brush, new Rectangle[]
            {
                new Rectangle(0, 0, Width, Thickness),
                new Rectangle(0, Height - Thickness, Width, Thickness),
                new Rectangle(0, 0, Thickness, Height),
                new Rectangle(Width - Thickness, 0, Thickness, Height)
            });
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        
    }
}
