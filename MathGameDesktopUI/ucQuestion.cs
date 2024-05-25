using MathGameDesktopUI.Properties;
using static Math_Quiz.frmMathQuiz;

namespace Math_Quiz
{
    public partial class ucQuestion : UserControl
    {
        private struct _stQuestionInfo
        {
            public byte QuestionNumber;
            public enOperation Operation;
            public enLevel Level;
            public double Number1;
            public double Number2;
            public double RightAnswer;
        }
        private _stQuestionInfo _QuestionInfo;

        private static Random _Random = new Random();

        public byte QuestionNumber
        {
            get => _QuestionInfo.QuestionNumber;
            set
            {
                _QuestionInfo.QuestionNumber = value;
                lblQuestionNumber.Text = "Q" + value;
            }
        }

        public bool IsAnswerCorrect => _IsSelectedOptionEqualsRightAnswer();

        public bool DisableTabStop
        {
            get => this.TabStop;
            set => this.TabStop = value;
        }

        public ucQuestion()
        {
            InitializeComponent();

            _QuestionInfo = new _stQuestionInfo();
        }

        private void _FillOptionsByRange(int From, int To)
        {
            if (To < From)
                return;

            List<double> options = _GenerateOptions(From, To);

            if (options.Count >= 4)
            {
                rbOption1.Text = options[0].ToString();
                rbOption2.Text = options[1].ToString();
                rbOption3.Text = options[2].ToString();
                rbOption4.Text = options[3].ToString();
            }
        }

        private List<double> _GenerateOptions(int From, int To)
        {
            HashSet<double> Options = new HashSet<double>();

            // Add the right answer first
            Options.Add(_QuestionInfo.RightAnswer);

            // Generate random options until we have at least 3 distinct ones
            while (Options.Count < 4)
            {
                double RandomNumber = _Random.Next(From, To);
                Options.Add(RandomNumber);
            }

            // Shuffle the options and return as a list
            return Options.OrderBy(x => _Random.Next()).ToList();
        }

        private void _CreateOptions()
        {
            enLevel CurrentLevel = _QuestionInfo.Level;

            if (CurrentLevel == enLevel.Mixed)
                CurrentLevel = (enLevel)_Random.Next(1, 4);

            switch (CurrentLevel)
            {
                case enLevel.Easy:
                    _FillOptionsByRange(0, 10);
                    break;

                case enLevel.Medium:
                    _FillOptionsByRange(10, 100);
                    break;

                case enLevel.Hard:
                    _FillOptionsByRange(100, 999);
                    break;
            }
        }

        private double _Calculate()
        {
            switch (_QuestionInfo.Operation)
            {
                case enOperation.Addition:
                    return (_QuestionInfo.Number1 + _QuestionInfo.Number2);

                case enOperation.Subtraction:
                    return (_QuestionInfo.Number1 - _QuestionInfo.Number2);

                case enOperation.Multiplication:
                    return (_QuestionInfo.Number1 * _QuestionInfo.Number2);

                case enOperation.Division:
                    if (_QuestionInfo.Number2 == 0)
                        _QuestionInfo.Number2 = 1;
                    return Math.Round(_QuestionInfo.Number1 / _QuestionInfo.Number2, 2);
            }

            return 0;
        }

        private double _GetRightAnswer()
        {
            return _Calculate();
        }

        private void _CreateQuestionText()
        {
            switch (_QuestionInfo.Operation)
            {
                case enOperation.Addition:
                    lblQuestion.Text = $"{_QuestionInfo.Number1} + {_QuestionInfo.Number2} =";
                    break;

                case enOperation.Subtraction:
                    lblQuestion.Text = $"{_QuestionInfo.Number1} - {_QuestionInfo.Number2} =";
                    break;

                case enOperation.Multiplication:
                    lblQuestion.Text = $"{_QuestionInfo.Number1} * {_QuestionInfo.Number2} =";
                    break;

                case enOperation.Division:
                    if (_QuestionInfo.Number2 == 0)
                        _QuestionInfo.Number2 = 1;
                    lblQuestion.Text = $"{_QuestionInfo.Number1} / {_QuestionInfo.Number2} =";
                    break;
            }
        }

        private bool _IsSelectedOptionEqualsRightAnswer()
        {
            return new[] { rbOption1, rbOption2, rbOption3, rbOption4 }
                   .Any(rb => rb.Checked && rb.Text == _QuestionInfo.RightAnswer.ToString());
        }

        private bool _IsThereSelectedOption(out RadioButton SelectedRadioButton)
        {
            SelectedRadioButton = new[] { rbOption1, rbOption2, rbOption3, rbOption4 }
                            .FirstOrDefault(rb => rb.Checked);

            return (SelectedRadioButton != null);
        }

        private bool _DoesOptionMatchRightAnswer(RadioButton rbOption)
        {
            return (rbOption != null) && (rbOption.Checked && rbOption.Text == _QuestionInfo.RightAnswer.ToString());
        }

        private byte _GetPositionOfCorrectAnswer()
        {
            var CorrectOption = new[] { rbOption1, rbOption2, rbOption3, rbOption4 }
                         .FirstOrDefault(rb => rb.Text == _QuestionInfo.RightAnswer.ToString());

            return (CorrectOption != null) ? Convert.ToByte(CorrectOption.Tag) : (byte)0;
        }

        private void _ShowAffectOfRightAnswer(byte PositionOfRadioButtonOfRightAnswer, bool WithBackColor = true)
        {
            switch (PositionOfRadioButtonOfRightAnswer)
            {
                case 1:
                    pOpetion1.Visible = true;
                    if (WithBackColor)
                    {
                        pOpetion1.FillColor = Color.DarkSeaGreen;
                        rbOption1.BackColor = Color.DarkSeaGreen;
                    }
                    pbOption1.Image = Resources.correct;
                    break;

                case 2:
                    pOpetion2.Visible = true;
                    if (WithBackColor)
                    {
                        pOpetion2.FillColor = Color.DarkSeaGreen;
                        rbOption2.BackColor = Color.DarkSeaGreen;
                    }
                    pbOption2.Image = Resources.correct;
                    break;

                case 3:
                    pOpetion3.Visible = true;
                    if (WithBackColor)
                    {
                        pOpetion3.FillColor = Color.DarkSeaGreen;
                        rbOption3.BackColor = Color.DarkSeaGreen;
                    }
                    pbOption3.Image = Resources.correct;
                    break;

                case 4:
                    pOpetion4.Visible = true;
                    if (WithBackColor)
                    {
                        pOpetion4.FillColor = Color.DarkSeaGreen;
                        rbOption4.BackColor = Color.DarkSeaGreen;
                    }
                    pbOption4.Image = Resources.correct;
                    break;
            }
        }

        private void _ShowAffectOfWrongAnswer(byte PositionOfRadioButtonOfWrongAnswer)
        {
            switch (PositionOfRadioButtonOfWrongAnswer)
            {
                case 1:
                    pOpetion1.Visible = true;
                    pOpetion1.FillColor = Color.FromArgb(255, 183, 180);
                    rbOption1.BackColor = Color.FromArgb(255, 183, 180);
                    pbOption1.Image = Resources.wrong;
                    break;

                case 2:
                    pOpetion2.Visible = true;
                    pOpetion2.FillColor = Color.FromArgb(255, 183, 180);
                    rbOption2.BackColor = Color.FromArgb(255, 183, 180);
                    pbOption2.Image = Resources.wrong;
                    break;

                case 3:
                    pOpetion3.Visible = true;
                    pOpetion3.FillColor = Color.FromArgb(255, 183, 180);
                    rbOption3.BackColor = Color.FromArgb(255, 183, 180);
                    pbOption3.Image = Resources.wrong;
                    break;

                case 4:
                    pOpetion4.Visible = true;
                    pOpetion4.FillColor = Color.FromArgb(255, 183, 180);
                    rbOption4.BackColor = Color.FromArgb(255, 183, 180);
                    pbOption4.Image = Resources.wrong;
                    break;
            }

            _ShowAffectOfRightAnswer(_GetPositionOfCorrectAnswer(), false);
        }

        public void MakeQuestion(double Number1, double Number2, enOperation Operation, enLevel Level)
        {
            _QuestionInfo.Number1 = Number1;
            _QuestionInfo.Number2 = Number2;
            _QuestionInfo.Operation = Operation;
            _QuestionInfo.Level = Level;
            _QuestionInfo.RightAnswer = _GetRightAnswer();

            _CreateQuestionText();

            _CreateOptions();
        }

        public void ShowEffectOfOptions()
        {
            // No option selected
            if (!_IsThereSelectedOption(out RadioButton SelectedRB))
            {
                _ShowAffectOfRightAnswer(_GetPositionOfCorrectAnswer(), false);
                return;
            }

            if (SelectedRB == null)
            {
                return;
            }

            if (_DoesOptionMatchRightAnswer(SelectedRB))
            {
                // Tag contains the position of the option
                _ShowAffectOfRightAnswer(Convert.ToByte(SelectedRB.Tag));
            }
            else
            {
                _ShowAffectOfWrongAnswer(Convert.ToByte(SelectedRB.Tag));
            }
        }

        private void _PerformDisableUnselectedOptions(byte PositionOfSelectedOption)
        {
            foreach (RadioButton radioButton in new[] { rbOption1, rbOption2, rbOption3, rbOption4 })
            {
                if (Convert.ToByte(radioButton.Tag) != PositionOfSelectedOption)
                {
                    radioButton.Enabled = false;
                }
            }
        }

        private void _DisableAllOptions()
        {
            rbOption1.Enabled = false;
            rbOption2.Enabled = false;
            rbOption3.Enabled = false;
            rbOption4.Enabled = false;
        }

        private void _DisableUnselectedOptions(byte PositionOfSelectedOption)
        {
            _PerformDisableUnselectedOptions(PositionOfSelectedOption);
        }

        public void DisableUnselectedOptions()
        {
            if (_IsThereSelectedOption(out RadioButton rbSelected))
            {
                if (rbSelected != null)
                {
                    _DisableUnselectedOptions(Convert.ToByte(rbSelected.Tag));
                }
            }
            else
            {
                _DisableAllOptions();
            }
        }
    }
}
