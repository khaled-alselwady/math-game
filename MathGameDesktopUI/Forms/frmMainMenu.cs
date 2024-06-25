using static Math_Quiz.frmMathQuiz;

namespace Math_Quiz
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private enOperation _GetOperation()
        {
            return cbOperation.Text switch
            {
                "Addition" => enOperation.Addition,
                "Subtraction" => enOperation.Subtraction,
                "Multiplication" => enOperation.Multiplication,
                "Division" => enOperation.Division,
                _ => enOperation.opMixed,
            };
        }

        private enLevel _GetLevel()
        {
            return cbLevel.Text switch
            {
                "Easy" => enLevel.Easy,
                "Medium" => enLevel.Medium,
                "Hard" => enLevel.Hard,
                _ => enLevel.Mixed,
            };
        }

        private byte _GetValueOfTimer()
        {
            return cbTimer.Text switch
            {
                "1:00" => 1,
                "2:00" => 2,
                "5:00" => 5,
                "10:00" => 10,
                "15:00" => 15,
                "30:00" => 30,
                _ => 1,
            };
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            enOperation Operation = _GetOperation();
            enLevel Level = _GetLevel();
            byte Timer = _GetValueOfTimer();

            this.Hide();

            frmMathQuiz MathQuiz = new frmMathQuiz
                                   (Convert.ToByte(numaricNumberOfQuestions.Value),
                                   Operation,
                                   Level,
                                   Timer,
                                   this);

            MathQuiz.ShowDialog();
        }
    }
}
