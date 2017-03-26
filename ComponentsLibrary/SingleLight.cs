using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentsLibrary
{
    public partial class SingleLight : UserControl
    {
        public Timer LightTimer;
        public int BlinkInterval;

        public bool Blink
        {   
            get { return _blink; }
            set
            {
                _blink = value;
                if (LightTimer == null)
                {
                    LightTimer = new Timer();
                    LightTimer.Interval = BlinkInterval;
                    LightTimer.Tick += LightTimerOnTick;
                }
                if (_blink)
                {
                    LightTimer.Start();
                }
                else
                {
                    LightTimer.Stop();
                }
            }
        }
        private bool _blink;

        public bool IsOff
        {
            get { return _isOff; }
            set
            {
                _isOff = value;
                _currentColor = _isOff ? DarkColor : LightColor;
                Invalidate();
            }
        }
        private bool _isOff;

        private Color _lightColor;
        public Color LightColor
        {
            get { return _lightColor; }
            set
            {
                _lightColor = value;
                if (!_isOff) _currentColor = _lightColor;
                Invalidate();
            }
        }

        private Color _darkColor;
        public Color DarkColor
        {
            get { return _darkColor; }
            set
            {
                _darkColor = value;
                if (_isOff) _currentColor = _darkColor;
                Invalidate();
            }
        }

        private Color _currentColor;
        private PointF[] _points;

        public SingleLight()
        {
            InitializeComponent();
            LightColor = Color.Magenta;
            DarkColor  = Color.Thistle;
            _currentColor = LightColor;
            Size = new Size(95, 30);
            _blink = false;
            BlinkInterval = 1000;
            IsOff = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(_currentColor);
            e.Graphics.FillRectangle(brush, new RectangleF(0, 0, Size.Width, Size.Height));
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, Size.Width, Size.Height));
        }

        private void LightTimerOnTick(object sender, EventArgs eventArgs)
        {
            IsOff = !IsOff;
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }

    }
}
