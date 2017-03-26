using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComponentsLibrary
{
    public partial class SevenSegmentPanel : UserControl
    {

        public enum Digits
        {
            One = 1,
            Two = 2,
            Four = 4,
            Eight = 8
        }

        public static char[] AvailableCharacters =
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'a', 'B', 'b',
            'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', '-', ',', '.'
        };

        public Digits CurrentDigits
        {
            get { return _currentDigits; }
            set
            {
                _currentDigits = value; 
                DrawPanel();
            }
        }
        private Digits _currentDigits;

        public ControlFrame.FrameType FrameType
        {
            get { return controlFrame1.Frame; }
            set { controlFrame1.Frame = value; }
        }

        public Color FrameMainColor
        {
            get { return controlFrame1.FillColor; }
            set { controlFrame1.FillColor = value; }
        }
        public Color FrameSecondaryColor
        {
            get { return controlFrame1.SecondaryColor; }
            set { controlFrame1.SecondaryColor = value; }
        }

        private readonly List<SingleDigit> _digitsList;
        private List<SingleDigit> _activeDigits;

        public Color Digit1LightColor
        {
            get { return singleDigit1.LightColor; }
            set
            {
                singleDigit1.LightColor = value;
                Invalidate();
            }
        }
        public Color Digit1DarkColor
        {
            get { return singleDigit1.DarkColor; }
            set
            {
                singleDigit1.DarkColor = value;
                Invalidate();
            }
        }
        public Color Digit2LightColor
        {
            get { return singleDigit2.LightColor; }
            set
            {
                singleDigit2.LightColor = value;
                Invalidate();
            }
        }
        public Color Digit2DarkColor
        {
            get { return singleDigit2.DarkColor; }
            set
            {
                singleDigit2.DarkColor = value;
                Invalidate();
            }
        }
        public Color Digit3LightColor
        {
            get { return singleDigit3.LightColor; }
            set
            {
                singleDigit3.LightColor = value;
                Invalidate();
            }
        }
        public Color Digit3DarkColor
        {
            get { return singleDigit3.DarkColor; }
            set
            {
                singleDigit3.DarkColor = value;
                Invalidate();
            }
        }
        public Color Digit4LightColor
        {
            get { return singleDigit4.LightColor; }
            set
            {
                singleDigit4.LightColor = value;
                Invalidate();
            }
        }
        public Color Digit4DarkColor
        {
            get { return singleDigit4.DarkColor; }
            set
            {
                singleDigit4.DarkColor = value;
                Invalidate();
            }
        }
        public Color Digit5LightColor
        {
            get { return singleDigit5.LightColor; }
            set
            {
                singleDigit5.LightColor = value;
                Invalidate();
            }
        }
        public Color Digit5DarkColor
        {
            get { return singleDigit5.DarkColor; }
            set
            {
                singleDigit5.DarkColor = value;
                Invalidate();
            }
        }
        public Color Digit6LightColor
        {
            get { return singleDigit6.LightColor; }
            set
            {
                singleDigit6.LightColor = value;
                Invalidate();
            }
        }
        public Color Digit6DarkColor
        {
            get { return singleDigit6.DarkColor; }
            set
            {
                singleDigit6.DarkColor = value;
                Invalidate();
            }
        }
        public Color Digit7LightColor
        {
            get { return singleDigit7.LightColor; }
            set
            {
                singleDigit7.LightColor = value;
                Invalidate();
            }
        }
        public Color Digit7DarkColor
        {
            get { return singleDigit7.DarkColor; }
            set
            {
                singleDigit7.DarkColor = value;
                Invalidate();
            }
        }
        public Color Digit8LightColor
        {
            get { return singleDigit8.LightColor; }
            set
            {
                singleDigit8.LightColor = value;
                Invalidate();
            }
        }
        public Color Digit8DarkColor
        {
            get { return singleDigit8.DarkColor; }
            set
            {
                singleDigit8.DarkColor = value;
                Invalidate();
            }
        }

        private bool _blinking;
        public bool Blinking
        {
            get { return _blinking; }
            set
            {
                _blinking = value;
                BlinkAllDigits(_blinking);
            }
        }
        
        public SevenSegmentPanel()
        {
            InitializeComponent();

            _digitsList = new List<SingleDigit>
            {
                singleDigit1,
                singleDigit2,
                singleDigit3,
                singleDigit4,
                singleDigit5,
                singleDigit6,
                singleDigit7,
                singleDigit8
            };
            CurrentDigits = Digits.Four;
            Blinking = false;
        }

        private void DrawPanel()
        {
            switch (_currentDigits)
            {
                case Digits.One:
                    foreach (var digit in _digitsList)
                    {
                        digit.Hide();
                    }
                    _digitsList[0].Show();
                    Size = new Size(130, 160);
                    
                    break;

                case Digits.Two:
                    foreach (var digit in _digitsList)
                    {
                        digit.Hide();
                    }
                    _digitsList[0].Show();
                    _digitsList[1].Show();
                    Size = new Size(255, 160);
                    
                    break;

                case Digits.Four:
                    for (int i = 0; i < _digitsList.Count-1; i++)
                    {
                        if(i<4)
                            _digitsList[i].Show();
                        else
                            _digitsList[i].Hide();
                    }
                    Size = new Size(505, 160);
                    
                    break;

                case Digits.Eight:
                    foreach (var digit in _digitsList)
                    {
                        digit.Show();
                    }
                    Size = new Size(1005, 160);
                    
                    break;
            }
            controlFrame1.Size = Size;
            controlFrame1.Invalidate();
            Invalidate();
        }

        public void BlinkAllDigits(bool isBlinking)
        {
            foreach (var digit in _digitsList)
            {
                digit.Blink = isBlinking;
            }
        }

        public void BlinkDigit(int digitNum, bool isBlinking)
        {
            _digitsList[digitNum].Blink = isBlinking;
        }

        public void TurnLight(int digitNum, bool isOff)
        {
            _digitsList[digitNum].IsOff = isOff;
        }

        public void SetDigits(string numbers)
        {
            char[] characters;
            if (CheckString(numbers, out characters))
            {
                int characterToDisplay = characters.Length-1;
                bool isWithDot = false;
                for (int i = (int)_currentDigits - 1; i >= 0; --i)
                {
                    if (characterToDisplay < 0)
                    {
                        _digitsList[i].IsOff = true;
                    }
                    else
                    {
                        _digitsList[i].SetCharacter((SingleDigit.Characters)characters[characterToDisplay], isWithDot);
                        isWithDot = false;
                        if (characters[characterToDisplay] == '.' || characters[characterToDisplay] == ',')
                        {
                            ++i;
                            isWithDot = true;
                        }
                        --characterToDisplay;
                    }
                }
            }
            else
            {
                DisplayError();
            }
            
        }

        private bool CheckString(string characters, out char[] charArray)
        {
            charArray = new char[] { };

            string checkedString = "";
            var displaysLeft = (int)_currentDigits;
            var lastIndex = characters.Length - 1;
            var commaCounter = 0;

            for (int i = lastIndex; i >= 0 && displaysLeft > 0; --i)
            {
                char c = characters[i];
                if (!AvailableCharacters.Contains(c)) return false;
                checkedString = checkedString.Insert(0, c.ToString());
                if (c == '.' || c == ',')
                {
                    ++commaCounter;
                }
                else
                {
                    commaCounter = 0;
                    --displaysLeft;
                }
                if (commaCounter > 1) return false;
            }
            charArray = checkedString.ToCharArray();

            return true;
        }

        private void DisplayError()
        {
            OffDisplay();
            switch (_currentDigits)
            {
                case Digits.One:
                    _digitsList[0].SetCharacter(SingleDigit.Characters.r, false);
                    break;
                case Digits.Two:
                    _digitsList[0].SetCharacter(SingleDigit.Characters.FourteenCap, false);
                    _digitsList[1].SetCharacter(SingleDigit.Characters.r, false);
                    break;
                case Digits.Four:
                    _digitsList[1].SetCharacter(SingleDigit.Characters.FourteenCap, false);
                    _digitsList[2].SetCharacter(SingleDigit.Characters.r, false);
                    _digitsList[3].SetCharacter(SingleDigit.Characters.r, false);
                    break;
                case Digits.Eight:
                    _digitsList[3].SetCharacter(SingleDigit.Characters.FourteenCap, false);
                    _digitsList[4].SetCharacter(SingleDigit.Characters.r, false);
                    _digitsList[5].SetCharacter(SingleDigit.Characters.r, false);
                    _digitsList[6].SetCharacter(SingleDigit.Characters.o, false);
                    _digitsList[7].SetCharacter(SingleDigit.Characters.r, false);
                    break;
            }
        }

        public void OffDisplay()
        {
            foreach (var digit in _digitsList)
            {
                digit.IsOff = true;
            }
        }
    }
}
