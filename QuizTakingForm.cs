using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultwinform
{
    public partial class QuizTakingForm : Form
    {

        private Quiz currentQuiz;

        private int currentQuestion;

        private int questionCount;

        public QuizTakingForm()
        {
            InitializeComponent();
            this.Size = new Size(1111, 758);
            this.MinimumSize = new Size(1111, 758);
            this.MaximumSize = new Size(1111, 758);
            this.CenterToScreen();

            immunityCount.Text = Program.currentAccount.getImmunityCount() + "";
            highStakesCount.Text = Program.currentAccount.getStakesCount() + "";
            doubleStarsCount.Text = Program.currentAccount.getDoubleCount() + "";
            multiplierCount.Text = Program.currentAccount.getMultiplyCount() + "";
            skipCount.Text = Program.currentAccount.getSkipCount() + "";
            eliminateCount.Text = Program.currentAccount.getEliminateCount() + "";

            currentQuiz = QuizDAO.getCurrentQuiz();

            questionCount = currentQuiz.getQuestions().Count;
            currentQuestion = 0;

            buildToQuestion();
        }

        private void buildToQuestion()
        {

            disableAllButtons();

            if (currentQuiz.getQuestion(currentQuestion) is MultipleChoice) {

                enableMultipleChoiceButtons();
            }

            if (currentQuiz.getQuestion(currentQuestion) is TrueFalseQuestion)
            {

                enableTrueOrFalseButtons();
            }
        }

        private void disableAllButtons()
        {
            redButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            blueButton.Visible = false;

            truePanel.Visible = false;
            falsePanel.Visible = false;
        }

        private void enableMultipleChoiceButtons()
        {
            redButton.Visible = true;
            yellowButton.Visible = true;
            greenButton.Visible = true;
            blueButton.Visible = true;

            truePanel.Visible = false;
            falsePanel.Visible = false;
        }

        private void enableTrueOrFalseButtons()
        {
            redButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            blueButton.Visible = false;

            truePanel.Visible = true;
            falsePanel.Visible = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if ((currentQuestion + 1) < questionCount)
            {
                currentQuestion++;

                buildToQuestion();
            }
        }
    }
}
