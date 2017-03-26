using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentsLibrary
{
    public partial class SingleDigit : UserControl
    {

        public enum Lights
        {
            A = 0,
            B,
            C,
            D,
            E,
            F,
            G,
            H
        }
        public enum Characters
        {
            Zero = '0',
            One = '1',
            Two = '2',
            Three = '3',
            Four = '4',
            Five = '5',
            Six = '6',
            Seven = '7',
            Eight = '8',
            Nine = '9',
            TenCap = 'A',
            ElevenCap = 'B',
            TwelveCap = 'C',
            ThirteenCap = 'D',
            FourteenCap = 'E',
            FifteenCap = 'F',
            Ten = 'a',
            Eleven = 'b',
            Twelve = 'c',
            Thirteen = 'd',
            Fourteen = 'e',
            Fifteen = 'f',
            r = 'r',
            o = 'o',
            Minus = '-',
            Dot = '.',
            Comma = ','
        }

        private bool _blink;
        public bool Blink
        {
            get { return _blink; }
            set
            {
                _blink = value;
                foreach (var light in _activeLights)
                {
                    light.Blink = _blink;
                }
            }
        }

        private readonly List<SingleLight> _lightsList;
        private List<SingleLight> _activeLights;

        private Color _lightColor;
        public Color LightColor
        {
            get { return _lightColor;}
            set
            {
                _lightColor = value;
                foreach (var light in _lightsList)
                {
                    light.LightColor = _lightColor;
                }
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
                foreach (var light in _lightsList)
                {
                    light.DarkColor = _darkColor;
                }
                Invalidate();
            }
        }

        private bool _isOff;
        public bool IsOff
        {
            get { return _isOff; }
            set
            {
                _isOff = value;
                foreach (var light in _activeLights)
                {
                    light.IsOff = _isOff;
                }
                Invalidate();
            }
        }

        public SingleDigit()
        {
            InitializeComponent();
            _lightsList = new List<SingleLight> {lightA, lightB, lightC, lightD, lightE, lightF, lightG, lightH};
            _activeLights = new List<SingleLight> { lightA, lightB, lightC, lightD, lightE, lightF, lightG, lightH };
            Blink = false;
            LightColor = Color.Magenta;
            DarkColor = Color.Thistle;
            Size = new Size(120,150);
        }

        public void SetCharacter(Characters characterToDisplay, bool isDotOn)
        {
            if (IsOff == false) IsOff = !IsOff;
            foreach (var light in _lightsList)
            {
                light.Blink = false;
                light.IsOff = true;
                if (_activeLights.Contains(light)) _activeLights.Remove(light);
            }
            switch (characterToDisplay)
            {
                case Characters.Zero:
                    _activeLights = new List<SingleLight> {lightA, lightB, lightC, lightD, lightE, lightF};
                    break;
                case Characters.One:
                    _activeLights = new List<SingleLight> {lightB, lightC};
                    break;
                case Characters.Two:
                    _activeLights = new List<SingleLight> { lightA, lightB, lightD, lightE, lightG };
                    break;
                case Characters.Three:
                    _activeLights = new List<SingleLight> { lightA, lightB, lightC, lightD, lightG };
                    break;
                case Characters.Four:
                    _activeLights = new List<SingleLight> { lightB, lightC, lightF, lightG };
                    break;
                case Characters.Five:
                    _activeLights = new List<SingleLight> { lightA, lightC, lightD, lightF, lightG };
                    break;
                case Characters.Six:
                    _activeLights = new List<SingleLight> { lightA, lightC, lightD, lightE, lightF, lightG };
                    break;
                case Characters.Seven:
                    _activeLights = new List<SingleLight> { lightA, lightB, lightC };
                    break;
                case Characters.Eight:
                    _activeLights = _lightsList;
                    break;
                case Characters.Nine:
                    _activeLights = new List<SingleLight> { lightA, lightB, lightC, lightD, lightF, lightG };
                    break;
                case Characters.TenCap:
                case Characters.Ten:
                    _activeLights = new List<SingleLight> { lightA, lightB, lightC, lightE, lightF, lightG };
                    break;
                case Characters.ElevenCap:
                case Characters.Eleven:
                    _activeLights = new List<SingleLight> { lightC, lightD, lightE, lightF, lightG };
                    break;
                case Characters.TwelveCap:
                case Characters.Twelve:
                    _activeLights = new List<SingleLight> { lightD, lightE, lightG };
                    break;
                case Characters.ThirteenCap:
                case Characters.Thirteen:
                    _activeLights = new List<SingleLight> { lightB, lightC, lightD, lightE, lightG };
                    break;
                case Characters.FourteenCap:
                case Characters.Fourteen:
                    _activeLights = new List<SingleLight> { lightA, lightD, lightE, lightF, lightG };
                    break;
                case Characters.FifteenCap:
                case Characters.Fifteen:
                    _activeLights = new List<SingleLight> { lightA, lightE, lightF, lightG };
                    break;
                case Characters.r:
                    _activeLights = new List<SingleLight> { lightE, lightG };
                    break;
                case Characters.o:
                    _activeLights = new List<SingleLight> { lightC, lightD, lightE, lightG };
                    break;
                case Characters.Minus:
                    _activeLights = new List<SingleLight> { lightG };
                    break;
                case Characters.Comma:
                case Characters.Dot:
                    _activeLights = new List<SingleLight> { lightH };
                    isDotOn = false;
                    break;
                default:
                    _activeLights = new List<SingleLight> { lightC, lightD, lightE, lightG };
                    break;
            }
            if (isDotOn) _activeLights.Add(lightH);

            foreach (var light in _activeLights)
            {
                light.IsOff = false;
            }

        }

    }
}
