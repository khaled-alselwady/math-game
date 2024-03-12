using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Math_Quiz.frmMathQuiz;

namespace Math_Quiz
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            enOperation Operation = _GetOperation();
            enLevel Level = _GetLevel();
            byte Timer = _GetValueOfTimer();

            this.Hide();
            frmMathQuiz MathQuiz = new frmMathQuiz
                    (Convert.ToByte(numaricNumberOfQuestions.Value),
                    Operation, Level, Timer, this);
            MathQuiz.ShowDialog();
        }

        private enOperation _GetOperation()
        {
            switch (cbOperation.Text)
            {
                case "Addition":
                    return enOperation.Addition;

                case "Subtraction":
                    return enOperation.Subtraction;

                case "Multiplication":
                    return enOperation.Multiplication;

                case "Division":
                    return enOperation.Division;

                default:
                    return enOperation.opMixed;
            }
        }

        private enLevel _GetLevel()
        {
            switch (cbLevel.Text)
            {
                case "Easy":
                    return enLevel.Easy;

                case "Medium":
                    return enLevel.Medium;

                case "Hard":
                    return enLevel.Hard;

                default:
                    return enLevel.Mixed;
            }
        }

        private byte _GetValueOfTimer()
        {
            switch (cbTimer.Text)
            {
                case "1:00":
                    return 1;

                case "2:00":
                    return 2;

                case "5:00":
                    return 5;

                case "10:00":
                    return 10;

                case "15:00":
                    return 15;

                case "30:00":
                    return 30;

                default:
                    return 1;
            }
        }

    }
}
