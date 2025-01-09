using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Question currentQuestion;

        private int sessionStarCount;

        private int questionNumber;
        private Boolean currentQuestionAnswered;

        private String multipleChoiceAnswer;
        private Boolean trueOrFalseAnswer;

        private int questionCount;

        private Boolean immunityActivated;
        private Boolean highStakesActivated;
        private Boolean doubleStarsActivated;
        private Boolean multiplierActivated;
        private Boolean skipActivated;
        private Boolean eliminateActivated;

        private int amountRight;

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
            questionNumber = 0;
            sessionStarCount = 0;
            currentQuestionAnswered = false;
            amountRight = 0;

            buildToQuestion();
        }

        private void buildToQuestion()
        {
            currentQuestion = currentQuiz.getQuestion(questionNumber);

            resetQuestionData();
            disableAllButtons();

            if (currentQuiz.getQuestion(currentQuestion) is MultipleChoice) {

                enableMultipleChoiceButtons();
            }

            if (currentQuiz.getQuestion(currentQuestion) is TrueFalseQuestion)
            {

                enableTrueOrFalseButtons();
            }

            questionLabel.Text = currentQuestion.getQuestion();

            questionImage.ImageLocation = currentQuestion.getURLString();

            starValueLabel.Text = "x " + currentQuestion.getStarValue();

            sessionStarLabel.Text = "" + sessionStarCount;

            quizProgressLabel.Text = questionNumber + 1 + "/" + questionCount;
        }

        private void resetQuestionData()
        {
            multipleChoiceAnswer = "";
            trueOrFalseAnswer = false;
            feedbackPane.Text = "";
        }

        private void disableAllButtons()
        {

            selectedIndicator.Visible = false;

            redButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            blueButton.Visible = false;

            truePanel.Visible = false;
            falsePanel.Visible = false;

            redLabel.Visible = false;
            yellowLabel.Visible = false;
            greenLabel.Visible = false;
            blueLabel.Visible = false;

            trueLabel.Visible = false;
            falseLabel.Visible = false;
        }

        private void disableAllPanels()
        {
            questionImage.Visible = false;
            questionImageUnder.Visible = false;
            questionLabel.Visible = false;
            nextLabel.Visible = false;
            nextButton.Visible = false;
            questionBacking.Visible = false;
            quizProgressLabel.Visible = false;
            progressBacking.Visible = false;

            homeButton.Visible = false;
            leaderboardButton.Visible = false;
            shopButton.Visible = false;
            gradesButton.Visible = false;
            skipButton.Visible = false;
            teachersButton.Visible = false;
            panel1.Visible = false;
            progressBacking.Visible = false;
        }

        private void enableMultipleChoiceButtons()
        {
            redButton.Visible = true;
            yellowButton.Visible = true;
            greenButton.Visible = true;
            blueButton.Visible = true;

            truePanel.Visible = false;
            falsePanel.Visible = false;

            redLabel.Visible = true;
            yellowLabel.Visible = true;
            greenLabel.Visible = true;
            blueLabel.Visible = true;

            MultipleChoice question = (MultipleChoice)currentQuestion;

            redLabel.Text = question.getFirstChoice();
            yellowLabel.Text = question.getSecondChoice();
            greenLabel.Text = question.getThirdChoice();
            blueLabel.Text = question.getFourthChoice();
        }

        private void enableTrueOrFalseButtons()
        {
            redButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            blueButton.Visible = false;

            truePanel.Visible = true;
            falsePanel.Visible = true;
            trueLabel.Visible = true;
            falseLabel.Visible = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            progressToNextQuestion();
        }

        private void nextLabel_Click(object sender, EventArgs e)
        {
            progressToNextQuestion();
        }

        private void progressToNextQuestion()
        {
            if (currentQuestionAnswered)
            {

                checkAnswer();

                if ((questionNumber + 1) < questionCount)
                {
                    questionNumber++;

                    buildToQuestion();
                } else
                {
                    disableAllButtons();
                    disableAllPanels();
                }
            }
        }

        private void checkAnswer()
        {

            if (currentQuestion is MultipleChoice)
            {
                MultipleChoice clone = (MultipleChoice) currentQuestion;

                if (clone.getAnswer().Equals(multipleChoiceAnswer))
                {
                    sessionStarCount += clone.getStarValue();
                    amountRight++;
                }
            }
            else if (currentQuestion is TrueFalseQuestion)
            {
                TrueFalseQuestion clone = (TrueFalseQuestion) currentQuestion;

                if (clone.IsTrue() == trueOrFalseAnswer)
                {
                    sessionStarCount += clone.getStarValue();
                    amountRight++;
                }
            }

            sessionStarLabel.Text = "" + sessionStarCount;
        }

        private void selectTrueOrFalseAnswer(Boolean questionTrue)
        {
            TrueFalseQuestion clone = (TrueFalseQuestion) currentQuestion;

            currentQuestionAnswered = true;

            selectedIndicator.Visible = true;

            if (questionTrue)
            {
                selectedIndicator.Location = new Point(371, 677);
                trueOrFalseAnswer = true;
            } else
            {
                selectedIndicator.Location = new Point(825, 677);
                trueOrFalseAnswer = false;
            }
        }

        private void selectMultipleChoiceAnswer(String color)
        {

            MultipleChoice clone = (MultipleChoice) currentQuestion;

            currentQuestionAnswered = true;

            selectedIndicator.Visible = true;

            if (color.Equals("red"))
            {
                selectedIndicator.Location = new Point(256, 677);
                multipleChoiceAnswer = redLabel.Text;
            } else if (color.Equals("yellow"))
            {
                selectedIndicator.Location = new Point(479, 677);
                multipleChoiceAnswer = yellowLabel.Text;
            } else if (color.Equals("green"))
            {
                selectedIndicator.Location = new Point(709, 677);
                multipleChoiceAnswer = greenLabel.Text;
            } else if (color.Equals("blue"))
            {
                selectedIndicator.Location = new Point(929, 677);
                multipleChoiceAnswer = blueLabel.Text;
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            selectMultipleChoiceAnswer("red");
        }

        private void redLabel_Click(object sender, EventArgs e)
        {
            selectMultipleChoiceAnswer("red");
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            selectMultipleChoiceAnswer("yellow");
        }

        private void yellowLabel_Click(object sender, EventArgs e)
        {
            selectMultipleChoiceAnswer("yellow");
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            selectMultipleChoiceAnswer("green");
        }

        private void greenLabel_Click(object sender, EventArgs e)
        {
            selectMultipleChoiceAnswer("green");
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            selectMultipleChoiceAnswer("blue");
        }

        private void blueLabel_Click(object sender, EventArgs e)
        {
            selectMultipleChoiceAnswer("blue");
        }

        private void truePanel_Click(object sender, EventArgs e)
        {
            selectTrueOrFalseAnswer(true);
        }

        private void trueLabel_Click(object sender, EventArgs e)
        {
            selectTrueOrFalseAnswer(true);
        }

        private void falsePanel_Click(object sender, EventArgs e)
        {
            selectTrueOrFalseAnswer(false);
        }

        private void falseLabel_Click(object sender, EventArgs e)
        {
            selectTrueOrFalseAnswer(false);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
