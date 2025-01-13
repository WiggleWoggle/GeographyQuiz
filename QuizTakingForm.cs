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

        private List<Question> missedQuestions;
        private List<String> incorrectAnswersTracked;
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
            missedQuestions = new List<Question>();
            incorrectAnswersTracked = new List<String>();

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

            starValueLabel.Text = "+ " + currentQuestion.getStarValue();

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
            redTextPanel.Visible = false;
            yellowTextPanel.Visible = false;
            greenTextPanel.Visible = false;
            blueTextPanel.Visible = false;

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
            additionalBackPanel.Visible = false;
            additionalStarIcon.Visible = false;
            starValueLabel.Visible = false;

            performanceOverlay.Visible = false;
            peformanceUnderlay.Visible = true;

            pictureBox3.Visible = false;
            sessionStarLabel.Visible = false;
            roundedPanel9.Visible = false;
        }

        private void enableSummaryPanel()
        {
            topicLabel.Text = currentQuiz.getTopic();
            performanceOverlay.Visible = true;
            peformanceUnderlay.Visible = true;
            performanceInfoLabel.Visible = true;
            questionsCorrectLabel.Visible = true;

            completionLabel.Visible = true;
            topicLabel.Visible = true;
            performancePanel.Visible = true;
            missedQuestionPanel.Visible = true;
            performanceLabel.Visible = true;
            missedLabel.Visible = true;
            label7.Visible = true;
            pictureBox1.Visible = true;
            roundedPanel7.Visible = true;

            performanceInfoLabel.Text = "You got " + sessionStarCount + " stars!";
            questionsCorrectLabel.Text = "You answered " + amountRight + " out of " + questionCount + " questions correctly!";
            label7.Text = sessionStarCount.ToString();

            //performanceOverlay.Width = (amountRight/questionCount) * 500;

            int currentTrackedQuestion = 0;

            foreach (Question question in missedQuestions)
            {

                Panel missedQuestion = new Panel();
                missedQuestion.Width = 470;
                missedQuestion.Height = 90;
                missedQuestion.BackColor = Color.FromArgb(228, 234, 239);

                Label questionNumber = new Label();
                questionNumber.Font = new Font("Century Gothic", 12);
                questionNumber.Text = "Question " + (currentQuiz.getQuestionPosition(question) + 1);
                questionNumber.Location = new Point(5, 5);
                questionNumber.AutoSize = true;

                missedQuestion.Controls.Add(questionNumber);

                Label remindQuestion = new Label();
                remindQuestion.Text = question.getQuestion();
                remindQuestion.Font = new Font("Century Gothic", 10, FontStyle.Italic);
                remindQuestion.Location = new Point(5, 30);
                remindQuestion.AutoSize = true;

                Label incorrectX = new Label();
                incorrectX.Text = "X";
                incorrectX.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                incorrectX.ForeColor = Color.FromArgb(255, 87, 87);
                incorrectX.Location = new Point(5, 55);
                incorrectX.AutoSize = true;

                Label incorrectChoice = new Label();
                incorrectChoice.Text = "You chose: " + incorrectAnswersTracked[currentTrackedQuestion];
                incorrectChoice.Font = new Font("Century Gothic", 10, FontStyle.Italic);
                incorrectChoice.Location = new Point(20, 55);
                incorrectChoice.AutoSize = true;

                missedQuestion.Controls.Add(remindQuestion);
                missedQuestion.Controls.Add(incorrectChoice);
                missedQuestion.Controls.Add(incorrectX);
                missedQuestion.Margin = new Padding(left: 3, top: 15, right: 3, bottom: 3);

                missedQuestionPanel.Controls.Add(missedQuestion);

                currentTrackedQuestion++;
            }
        }

        private void enableMultipleChoiceButtons()
        {
            redTextPanel.Visible = true;
            yellowTextPanel.Visible = true;
            greenTextPanel.Visible = true;
            blueTextPanel.Visible = true;

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
                    enableSummaryPanel();
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
                } else
                {
                    missedQuestions.Add(clone);

                    incorrectAnswersTracked.Add(multipleChoiceAnswer);
                }
            }
            else if (currentQuestion is TrueFalseQuestion)
            {
                TrueFalseQuestion clone = (TrueFalseQuestion) currentQuestion;

                if (clone.IsTrue() == trueOrFalseAnswer)
                {
                    sessionStarCount += clone.getStarValue();
                    amountRight++;
                } else
                {
                    missedQuestions.Add(clone);

                    String returnValue = "True";

                    if (!trueOrFalseAnswer)
                    {
                        returnValue = "False";
                    }

                    incorrectAnswersTracked.Add(returnValue);
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
                selectedIndicator.Location = new Point(946, 677);
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

        private void missedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
