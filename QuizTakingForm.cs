using defaultwinform.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace defaultwinform
{
    public partial class QuizTakingForm : Form
    {

        private Quiz currentQuiz;
        private Question currentQuestion;

        private int sessionStarCount;

        private int questionNumber;
        private Boolean currentQuestionAnswered;
        private int currentQuestionValue = 0;
        private Boolean usedPowerUpOnQuestion;

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

        private Boolean redSelected;
        private Boolean yellowSelected;
        private Boolean greenSelected;
        private Boolean blueSelected;

        public QuizTakingForm()
        {
            InitializeComponent();
            this.Size = new Size(1294, 869);
            this.MinimumSize = new Size(1294, 869);
            this.MaximumSize = new Size(1294, 869);
            nextButton.Location = new Point(1084, 453);
            nextLabel.Location = new Point(1120, 475);
            this.CenterToScreen();

            immunityCount.Text = Program.currentAccount.getImmunityCount() + "";
            highStakesCount.Text = Program.currentAccount.getStakesCount() + "";
            doubleStarsCount.Text = Program.currentAccount.getDoubleCount() + "";
            multiplierCount.Text = Program.currentAccount.getMultiplyCount() + "";
            skipCount.Text = Program.currentAccount.getSkipCount() + "";
            eliminateCount.Text = Program.currentAccount.getEliminateCount() + "";


            currentQuiz = QuizDAO.getCurrentQuiz();

            if (currentQuiz.shouldShuffle())
            {
                currentQuiz.setQuestions(currentQuiz.shuffleQuestions());
            }

            questionCount = currentQuiz.getQuestions().Count;
            questionNumber = 0;
            sessionStarCount = 0;
            currentQuestionAnswered = false;
            amountRight = 0;
            missedQuestions = new List<Question>();
            incorrectAnswersTracked = new List<String>();

            buildToQuestion();

            blueSelected = false;
            redSelected = false;
            yellowSelected = false;
            greenSelected = false;

            shortAnswerBox.ScrollBars = ScrollBars.Vertical;
        }

        private void buildToQuestion()
        {
            falsePanel.Image = Resources.redButton;
            falseLabel.Text = "False";
            falseLabel.BackColor = Color.FromArgb(255, 87, 87);

            truePanel.Image = Resources.blueButton;
            trueLabel.Text = "True";
            trueLabel.BackColor = Color.FromArgb(12, 192, 223);

            shortAnswerBox.Text = "";

            highStakesActivated = false;

            immunityActivated = false;
            usedPowerUpOnQuestion = false;
            currentQuestion = currentQuiz.getQuestion(questionNumber);

            questionImage.ImageLocation = currentQuestion.getURLString();

            resetQuestionData();
            disableAllButtons();

            questionImageUnder.Location = new Point(496, 150);

            shortResponseUnder.Location = new Point(670, 173);
            nextButton.Location = new Point(1084, 453);
            nextLabel.Location = new Point(1120, 475);

            redSelector.Image = Resources.emptyRed;
            redSelector.Refresh();
            redSelected = false;

            yellowSelector.Image = Resources.emptyYellow;
            yellowSelector.Refresh();
            yellowSelected = false;

            greenSelector.Image = Resources.emptyGreen;
            greenSelector.Refresh();
            greenSelected = false;

            blueSelector.Image = Resources.emptyBlue;
            blueSelector.Refresh();
            blueSelected = false;

            redLabel.BackColor = Color.FromArgb(255, 87, 87);
            redButton.Image = Resources.redButton;

            yellowLabel.BackColor = Color.FromArgb(255, 177, 85);
            yellowButton.Image = Resources.yellowButton;

            greenLabel.BackColor = Color.FromArgb(97, 182, 97);
            greenButton.Image = Resources.greenButton;

            blueLabel.BackColor = Color.FromArgb(12, 192, 223);
            blueButton.Image = Resources.blueButton;

            disableNextButton();

            if (currentQuiz.getQuestion(currentQuestion) is MultipleChoice)
            {

                enableMultipleChoiceButtons();
            }

            if (currentQuiz.getQuestion(currentQuestion) is TrueFalseQuestion)
            {

                enableTrueOrFalseButtons();
            }

            if (currentQuiz.getQuestion(currentQuestion) is MultipleAnswer)
            {

                enableMultipleAnswerButtons();
            }

            if (currentQuiz.getQuestion(currentQuestion) is ShortResponse)
            {
                enableShortAnswerButtons();
            }

            longQuestionTip.SetToolTip(questionLabel, currentQuestion.getQuestion());
            longQuestionTip.SetToolTip(secondaryQuestionLabel, currentQuestion.getQuestion());
            longQuestionTip.SetToolTip(questionBacking, currentQuestion.getQuestion());

            questionLabel.Text = currentQuestion.getQuestion();

            questionBacking.Size = new Size(755, 82);

            String question = questionLabel.Text;

            secondaryQuestionLabel.Visible = false;
            questionLabel.Location = new Point(4, 0);

            //
            if (question.Length > 60)
            {
                questionLabel.Text = splitQuestion(question, true);
                secondaryQuestionLabel.Visible = true;
                questionLabel.Location = new Point(4, 20);
                secondaryQuestionLabel.Text = splitQuestion(question, false);
            }

            //questionLabel.Text = splitQuestion(question, true);
            //secondaryQuestionLabel.Text = splitQuestion(question, false);
            currentQuestionValue = currentQuestion.getStarValue();

            starValueLabel.Text = "+ " + currentQuestionValue;

            sessionStarLabel.Text = "" + sessionStarCount;

            quizProgressLabel.Text = questionNumber + 1 + "/" + questionCount;


        }

        private void disableNextButton()
        {
            nextButton.Image = Resources.unavailableNext;
            nextLabel.BackColor = Color.FromArgb(146, 147, 148);
            nextLabel.ForeColor = Color.FromArgb(205, 205, 205);
        }

        private void enableNextButton()
        {
            nextButton.Image = Resources.next;
            nextLabel.BackColor = Color.FromArgb(182, 189, 202);
            nextLabel.ForeColor = Color.White;
        }

        private String splitQuestion(String question, Boolean getFirstHalf)
        {
            int middleIndex = question.Length / 2;

            // find the nearest space to the left or right of the middle index
            int splitIndex = middleIndex;

            while (splitIndex > 0 && question[splitIndex] != ' ')
            {
                splitIndex--;
            }

            // if no space was found to the left try finding one to the right
            if (splitIndex == 0)
            {
                splitIndex = middleIndex;
                while (splitIndex < question.Length && question[splitIndex] != ' ')
                {
                    splitIndex++;
                }
            }

            // split the string at the identified index
            string firstHalf = question.Substring(0, splitIndex).Trim();
            string secondHalf = question.Substring(splitIndex).Trim();

            if (question.Length > 60)
            {

                if (secondHalf.Length > 60)
                {
                    secondHalf = secondHalf.Substring(0, 60);
                }

                if (secondHalf.Length > 3)
                {
                    secondHalf = secondHalf.Substring(0, secondHalf.Length - 3);
                }

                secondHalf += "...";
            }

            if (getFirstHalf)
            {
                return firstHalf;
            }

            return secondHalf;
        }

        private void resetQuestionData()
        {
            multipleChoiceAnswer = "";
            trueOrFalseAnswer = false;
            feedbackPane.Text = "";
        }

        private void disableAllButtons()
        {

            shortResponseUnder.Visible = false;
            shortAnswerBox.Visible = false;

            redSelector.Visible = false;
            yellowSelector.Visible = false;
            greenSelector.Visible = false;
            blueSelector.Visible = false;

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

            immunityPowerup.Visible = false;
            highStakesPowerup.Visible = false;
            doubleStarsPowerup.Visible = false;
            multiplierPowerup.Visible = false;
            skipPowerup.Visible = false;
            eliminatePowerup.Visible = false;
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

        private void enableShortAnswerButtons()
        {
            questionImageUnder.Location = new Point(197, 173);
            shortResponseUnder.Location = new Point(670, 173);

            nextButton.Location = new Point(1084, 593);
            nextLabel.Location = new Point(1120, 615);

            shortResponseUnder.Visible = true;
            shortAnswerBox.Visible = true;
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

            this.AutoScroll = true;

            performanceInfoLabel.Text = "You got " + sessionStarCount + " stars!";
            questionsCorrectLabel.Text = "You answered " + amountRight + " out of " + questionCount + " questions correctly!";
            label7.Text = sessionStarCount.ToString();
            returnHomeButton.Visible = true;
            returnHomeButton.Location = new Point(returnHomeButton.Location.X, returnHomeButton.Location.Y + (missedQuestions.Count * 110));

            Program.currentAccount.setStarsCount(Program.currentAccount.getStarsCount() + sessionStarCount);

            int newWidth = (int)((amountRight / (double)questionCount) * 316);

            performanceOverlay.Width = newWidth;

            int currentTrackedQuestion = 0;

            foreach (Question question in missedQuestions)
            {

                Panel missedQuestion = new Panel();
                missedQuestion.Width = 552;
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

            redLabel.BackColor = Color.FromArgb(255, 87, 87);
            yellowLabel.BackColor = Color.FromArgb(255, 177, 85);
            greenLabel.BackColor = Color.FromArgb(97, 182, 97);
            blueLabel.BackColor = Color.FromArgb(12, 192, 223);

            redButton.Image = Resources.redButton;
            yellowButton.Image = Resources.yellowButton;
            greenButton.Image = Resources.greenButton;
            blueButton.Image = Resources.blueButton;
        }

        private void enableMultipleAnswerButtons()
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

            redSelector.Visible = true;
            yellowSelector.Visible = true;
            greenSelector.Visible = true;
            blueSelector.Visible = true;

            redButton.Image = Resources.redButton;
            yellowButton.Image = Resources.yellowButton;
            greenButton.Image = Resources.greenButton;
            blueButton.Image = Resources.blueButton;


            MultipleAnswer question = (MultipleAnswer)currentQuestion;

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

                    currentQuestionAnswered = false;
                }
                else
                {
                    disableAllButtons();
                    disableAllPanels();
                    enableSummaryPanel();
                }
            }
        }

        private void checkAnswer()
        {

            if (immunityActivated)
            {
                sessionStarCount += currentQuestionValue;
                amountRight++;
            }
            else
            {
                if (currentQuestion is MultipleChoice)
                {
                    MultipleChoice clone = (MultipleChoice)currentQuestion;

                    if (clone.getAnswer().Equals(multipleChoiceAnswer))
                    {
                        sessionStarCount += currentQuestionValue;
                        amountRight++;
                    }
                    else
                    {
                        missedQuestions.Add(clone);

                        if (highStakesActivated)
                        {
                            sessionStarCount = 0;
                        }

                        incorrectAnswersTracked.Add(multipleChoiceAnswer);
                    }
                }
                else if (currentQuestion is TrueFalseQuestion)
                {
                    TrueFalseQuestion clone = (TrueFalseQuestion)currentQuestion;

                    if (clone.IsTrue() == trueOrFalseAnswer)
                    {
                        sessionStarCount += currentQuestionValue;
                        amountRight++;
                    }
                    else
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
                else if (currentQuestion is MultipleAnswer)
                {
                    MultipleAnswer clone = (MultipleAnswer)currentQuestion;

                    if (multipleAnswerCorrect(clone))
                    {
                        sessionStarCount += currentQuestionValue;
                        amountRight++;
                    }
                    else
                    {

                        missedQuestions.Add(clone);

                        String compiled = "";

                        if (redSelected)
                        {
                            compiled = compiled + redLabel.Text + " ";
                        }

                        if (yellowSelected)
                        {
                            compiled = compiled + yellowLabel.Text + " ";
                        }

                        if (greenSelected)
                        {
                            compiled = compiled + greenLabel.Text + " ";
                        }

                        if (blueSelected)
                        {
                            compiled = compiled + blueLabel.Text + " ";
                        }

                        if (compiled.Equals(""))
                        {
                            compiled = "Nothing. ";
                        }

                        compiled = compiled.Substring(0, compiled.Length - 1);
                        compiled = string.Join(", ", compiled.Split(' '));

                        incorrectAnswersTracked.Add(compiled);
                    }
                }
                else if (currentQuestion is ShortResponse)
                {
                    ShortResponse clone = (ShortResponse)currentQuestion;

                    if (shortResponseCorrect(clone))
                    {
                        sessionStarCount += currentQuestionValue;
                        amountRight++;
                    }
                    else
                    {

                        missedQuestions.Add(clone);

                        incorrectAnswersTracked.Add("Your response was incorrect.");
                    }
                }
            }


            sessionStarLabel.Text = "" + sessionStarCount;
        }

        private Boolean shortResponseCorrect(ShortResponse question)
        {
            foreach (String phrase in question.getPhrases())
            {

                phrase.ToLower().Trim();

                String shortAnswer = shortAnswerBox.Text;
                shortAnswer.ToLower().Trim();

                if (shortAnswer.Contains(phrase))
                {

                    return true;


                }
                else if (shortAnswer.Contains(phrase.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }

        private Boolean multipleAnswerCorrect(MultipleAnswer question)
        {

            if (redSelected)
            {
                if (!question.getAnswers().Contains(redLabel.Text))
                {
                    return false;
                }
            }
            else
            {
                if (question.getAnswers().Contains(redLabel.Text))
                {
                    return false;
                }
            }

            if (yellowSelected)
            {
                if (!question.getAnswers().Contains(yellowLabel.Text))
                {
                    return false;
                }
            }
            else
            {
                if (question.getAnswers().Contains(yellowLabel.Text))
                {
                    return false;
                }
            }

            if (greenSelected)
            {
                if (!question.getAnswers().Contains(greenLabel.Text))
                {
                    return false;
                }
            }
            else
            {
                if (question.getAnswers().Contains(greenLabel.Text))
                {
                    return false;
                }
            }

            if (blueSelected)
            {
                if (!question.getAnswers().Contains(blueLabel.Text))
                {
                    return false;
                }
            }
            else
            {
                if (question.getAnswers().Contains(blueLabel.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private void selectTrueOrFalseAnswer(Boolean questionTrue)
        {
            TrueFalseQuestion clone = (TrueFalseQuestion)currentQuestion;

            currentQuestionAnswered = true;
            enableNextButton();
            selectedIndicator.Visible = true;

            if (questionTrue)
            {
                selectedIndicator.Location = new Point(432, 805);
                trueOrFalseAnswer = true;
            }
            else
            {
                selectedIndicator.Location = new Point(964, 805);
                trueOrFalseAnswer = false;
            }
        }

        private void selectMultipleAnswer(String color)
        {

            if (color.Equals("red"))
            {
                if (redSelected)
                {
                    redSelector.Image = Resources.emptyRed;
                    redSelector.Refresh();
                    redSelected = false;
                }
                else
                {
                    redSelector.Image = Resources.selectedRed;
                    redSelector.Refresh();
                    redSelected = true;
                }
            }
            else if (color.Equals("yellow"))
            {
                if (yellowSelected)
                {
                    yellowSelector.Image = Resources.emptyYellow;
                    yellowSelector.Refresh();
                    yellowSelected = false;
                }
                else
                {
                    yellowSelector.Image = Resources.selectedYellow;
                    yellowSelector.Refresh();
                    yellowSelected = true;
                }
            }
            else if (color.Equals("green"))
            {
                if (greenSelected)
                {
                    greenSelector.Image = Resources.emptyGreen;
                    greenSelector.Refresh();
                    greenSelected = false;
                }
                else
                {
                    greenSelector.Image = Resources.selectedGreen;
                    greenSelector.Refresh();
                    greenSelected = true;
                }
            }
            else if (color.Equals("blue"))
            {
                if (blueSelected)
                {
                    blueSelector.Image = Resources.emptyBlue;
                    blueSelector.Refresh();
                    blueSelected = false;
                }
                else
                {
                    blueSelector.Image = Resources.selectedBlue;
                    blueSelector.Refresh();
                    blueSelected = true;
                }
            }

            if (atLeastOneSelected())
            {
                currentQuestionAnswered = true;

                enableNextButton();
            }
            else
            {
                currentQuestionAnswered = false;

                disableNextButton();
            }
        }

        private Boolean atLeastOneSelected()
        {
            if (redSelected || yellowSelected || greenSelected || blueSelected)
            {
                return true;
            }

            return false;
        }

        private void selectMultipleChoiceAnswer(String color)
        {

            MultipleChoice clone = (MultipleChoice)currentQuestion;

            currentQuestionAnswered = true;

            enableNextButton();

            selectedIndicator.Visible = true;

            if (color.Equals("red"))
            {
                selectedIndicator.Location = new Point(297, 805);
                multipleChoiceAnswer = redLabel.Text;
            }
            else if (color.Equals("yellow"))
            {
                selectedIndicator.Location = new Point(566, 805);
                multipleChoiceAnswer = yellowLabel.Text;
            }
            else if (color.Equals("green"))
            {
                selectedIndicator.Location = new Point(830, 805);
                multipleChoiceAnswer = greenLabel.Text;
            }
            else if (color.Equals("blue"))
            {
                selectedIndicator.Location = new Point(1095, 805);
                multipleChoiceAnswer = blueLabel.Text;
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {

            if (currentQuestion is MultipleChoice)
            {
                selectMultipleChoiceAnswer("red");
            }
            else
            {
                selectMultipleAnswer("red");
            }
        }

        private void redLabel_Click(object sender, EventArgs e)
        {
            if (currentQuestion is MultipleChoice)
            {
                selectMultipleChoiceAnswer("red");
            }
            else
            {
                selectMultipleAnswer("red");
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion is MultipleChoice)
            {
                selectMultipleChoiceAnswer("yellow");
            }
            else
            {
                selectMultipleAnswer("yellow");
            }
        }

        private void yellowLabel_Click(object sender, EventArgs e)
        {
            if (currentQuestion is MultipleChoice)
            {
                selectMultipleChoiceAnswer("yellow");
            }
            else
            {
                selectMultipleAnswer("yellow");
            }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion is MultipleChoice)
            {
                selectMultipleChoiceAnswer("green");
            }
            else
            {
                selectMultipleAnswer("green");
            }
        }

        private void greenLabel_Click(object sender, EventArgs e)
        {
            if (currentQuestion is MultipleChoice)
            {
                selectMultipleChoiceAnswer("green");
            }
            else
            {
                selectMultipleAnswer("green");
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion is MultipleChoice)
            {
                selectMultipleChoiceAnswer("blue");
            }
            else
            {
                selectMultipleAnswer("blue");
            }
        }

        private void blueLabel_Click(object sender, EventArgs e)
        {
            if (currentQuestion is MultipleChoice)
            {
                selectMultipleChoiceAnswer("blue");
            }
            else
            {
                selectMultipleAnswer("blue");
            }
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

        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.Show();
            this.Close();
        }

        private void shortAnswerBox_TextChanged(object sender, EventArgs e)
        {

            currentQuestionAnswered = false;

            disableNextButton();

            if (shortAnswerBox.Text != null)
            {
                if (shortAnswerBox.Text.Length > 0)
                {
                    if (!shortAnswerBox.Text.Equals(""))
                    {
                        currentQuestionAnswered = true;

                        enableNextButton();
                    }
                }
            }
        }

        private void questionLabel_MouseHover(object sender, EventArgs e)
        {
        }

        private void longQuestionHelp_MouseLeave(object sender, EventArgs e)
        {

        }

        private void questionLabel_MouseLeave(object sender, EventArgs e)
        {
        }

        private void secondaryQuestionLabel_MouseHover(object sender, EventArgs e)
        {
        }

        private void secondaryQuestionLabel_MouseLeave(object sender, EventArgs e)
        {
        }

        private void skipCount_Click(object sender, EventArgs e)
        {

        }

        private void doubleStarsPowerup_Click(object sender, EventArgs e)
        {
            if (!usedPowerUpOnQuestion)
            {
                if (Program.currentAccount.getDoubleCount() > 0)
                {

                    usedPowerUpOnQuestion = true;

                    Program.currentAccount.setDoubleCount(Program.currentAccount.getDoubleCount() - 1);
                    doubleStarsCount.Text = "" + Program.currentAccount.getDoubleCount();

                    currentQuestionValue = currentQuestion.getStarValue() * 2;

                    starValueLabel.Text = "+ " + currentQuestionValue;

                    powerupDisplay.Visible = true;
                    powerupDisplayLabel.Visible = true;

                    powerupDisplay.Image = Resources.doubler;
                    powerupDisplayLabel.Text = "Doubler used!";

                    powerupDisplay.Visible = true;
                    powerupDisplayLabel.Visible = true;

                    hidePowerupDisplay();
                }
            }
        }

        private void eliminatePowerup_Click(object sender, EventArgs e)
        {
            if (!usedPowerUpOnQuestion)
            {
                if (Program.currentAccount.getEliminateCount() > 0)
                {

                    if (!(currentQuestion is ShortResponse))
                    {

                        usedPowerUpOnQuestion = true;

                        Program.currentAccount.setEliminateCount(Program.currentAccount.getEliminateCount() - 1);
                        eliminateCount.Text = "" + Program.currentAccount.getEliminateCount();

                        if (currentQuestion is MultipleChoice clone)
                        {

                            int correct = 4;

                            if (clone.getFirstChoice().Equals(clone.getAnswer()))
                            {
                                correct = 1;
                            }

                            if (clone.getSecondChoice().Equals(clone.getAnswer()))
                            {
                                correct = 2;
                            }

                            if (clone.getThirdChoice().Equals(clone.getAnswer()))
                            {
                                correct = 3;
                            }

                            Console.WriteLine("Correct: " + correct);

                            int eliminate = randomizeEliminateChoice(correct);

                            if (eliminate == 1)
                            {
                                redLabel.BackColor = Color.FromArgb(84, 84, 84);
                                redButton.Image = Resources.eliminatedButton;
                                redLabel.Text = "";
                            }
                            else if (eliminate == 2)
                            {
                                yellowLabel.BackColor = Color.FromArgb(84, 84, 84);
                                yellowButton.Image = Resources.eliminatedButton;
                                yellowLabel.Text = "";
                            }
                            else if (eliminate == 3)
                            {
                                greenLabel.BackColor = Color.FromArgb(84, 84, 84);
                                greenButton.Image = Resources.eliminatedButton;
                                greenLabel.Text = "";
                            }
                            else
                            {
                                blueLabel.BackColor = Color.FromArgb(84, 84, 84);
                                blueButton.Image = Resources.eliminatedButton;
                                blueLabel.Text = "";
                            }
                        }
                        else if (currentQuestion is TrueFalseQuestion trueFalse)
                        {
                            if (trueFalse.IsTrue())
                            {
                                falsePanel.Image = Resources.eliminatedPane;
                                falseLabel.Text = "";
                            }
                            else
                            {
                                truePanel.Image = Resources.eliminatedPane;
                                trueLabel.Text = "";
                            }
                        }
                        else if (currentQuestion is MultipleAnswer multipleAnswer)
                        {
                            if (!multipleAnswer.getAnswers().Contains(multipleAnswer.getFirstChoice()))
                            {
                                redSelector.Visible = false;
                                redLabel.BackColor = Color.FromArgb(84, 84, 84);
                                redButton.Image = Resources.eliminatedButton;
                                redLabel.Text = "";
                            }
                            else if (!multipleAnswer.getAnswers().Contains(multipleAnswer.getSecondChoice()))
                            {
                                yellowSelector.Visible = false;
                                yellowLabel.BackColor = Color.FromArgb(84, 84, 84);
                                yellowButton.Image = Resources.eliminatedButton;
                                yellowLabel.Text = "";
                            }
                            else if (!multipleAnswer.getAnswers().Contains(multipleAnswer.getThirdChoice()))
                            {
                                greenSelector.Visible = false;
                                greenLabel.BackColor = Color.FromArgb(84, 84, 84);
                                greenButton.Image = Resources.eliminatedButton;
                                greenLabel.Text = "";
                            }
                            else
                            {
                                blueSelector.Visible = false;
                                blueLabel.BackColor = Color.FromArgb(84, 84, 84);
                                blueButton.Image = Resources.eliminatedButton;
                                blueLabel.Text = "";
                            }
                        }

                        powerupDisplay.Visible = true;
                        powerupDisplayLabel.Visible = true;

                        powerupDisplay.Image = Resources.eliminate;
                        powerupDisplayLabel.Text = "Eliminate used!";

                        hidePowerupDisplay();
                    }
                }
            }
        }

        private int randomizeEliminateChoice(int correct)
        {

            Random random = new Random();

            int result;
            do
            {
                result = random.Next(4) + 1;
            } while (result == correct);

            return result;
        }

        public async void hidePowerupDisplay()
        {
            await Task.Delay(1000);

            powerupDisplay.Visible = false;
            powerupDisplayLabel.Visible = false;
        }

        private void immunityPowerup_Click(object sender, EventArgs e)
        {
            if (!usedPowerUpOnQuestion)
            {
                if (Program.currentAccount.getImmunityCount() > 0)
                {

                    usedPowerUpOnQuestion = true;

                    immunityActivated = true;

                    Program.currentAccount.setImmunityCount(Program.currentAccount.getImmunityCount() - 1);
                    immunityCount.Text = "" + Program.currentAccount.getImmunityCount();

                    powerupDisplay.Visible = true;
                    powerupDisplayLabel.Visible = true;

                    powerupDisplay.Image = Resources.immunity;
                    powerupDisplayLabel.Text = "Immunity used!";

                    hidePowerupDisplay();
                }
            }
        }

        private void highStakesPowerup_Click(object sender, EventArgs e)
        {
            if (!usedPowerUpOnQuestion)
            {
                if (Program.currentAccount.getStakesCount() > 0)
                {
                    usedPowerUpOnQuestion = true;

                    highStakesActivated = true;

                    Program.currentAccount.setStakesCount(Program.currentAccount.getStakesCount() - 1);
                    highStakesCount.Text = "" + Program.currentAccount.getStakesCount();

                    powerupDisplay.Visible = true;
                    powerupDisplayLabel.Visible = true;

                    powerupDisplay.Image = Resources.highstakes;
                    powerupDisplayLabel.Text = "High Stakes used!";

                    currentQuestionValue = currentQuestionValue * 4;

                    starValueLabel.Text = "x " + currentQuestionValue;

                    hidePowerupDisplay();
                }
            }
        }

        private void multiplierPowerup_Click(object sender, EventArgs e)
        {
            if (!usedPowerUpOnQuestion)
            {
                if (Program.currentAccount.getMultiplyCount() > 0)
                {

                    usedPowerUpOnQuestion = true;

                    Program.currentAccount.setMultiplyCount(Program.currentAccount.getMultiplyCount() - 1);
                    multiplierCount.Text = "" + Program.currentAccount.getMultiplyCount();

                    currentQuestionValue = currentQuestion.getStarValue() * 3;

                    starValueLabel.Text = "+ " + currentQuestionValue;

                    powerupDisplay.Visible = true;
                    powerupDisplayLabel.Visible = true;

                    powerupDisplay.Image = Resources.multiplier;
                    powerupDisplayLabel.Text = "Multiplier used!";

                    powerupDisplay.Visible = true;
                    powerupDisplayLabel.Visible = true;

                    hidePowerupDisplay();
                }
            }
        }

        private void skipPowerup_Click(object sender, EventArgs e)
        {
            if (!usedPowerUpOnQuestion)
            {
                if (Program.currentAccount.getSkipCount() > 0)
                {

                    usedPowerUpOnQuestion = true;

                    Program.currentAccount.setSkipCount(Program.currentAccount.getSkipCount() - 1);
                    skipCount.Text = "" + Program.currentAccount.getSkipCount();

                    sessionStarCount++;

                    if ((questionNumber + 1) < questionCount)
                    {
                        questionNumber++;

                        buildToQuestion();

                        currentQuestionAnswered = false;
                    }
                    else
                    {
                        disableAllButtons();
                        disableAllPanels();
                        enableSummaryPanel();
                    }

                    powerupDisplay.Visible = true;
                    powerupDisplayLabel.Visible = true;

                    powerupDisplay.Image = Resources.skip;
                    powerupDisplayLabel.Text = "Skip used!";

                    powerupDisplay.Visible = true;
                    powerupDisplayLabel.Visible = true;

                    hidePowerupDisplay();
                }
            }
        }

        private void QuizTakingForm_SizeChanged(object sender, EventArgs e)
        {

        }

        private void selectedIndicator_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel9_Click(object sender, EventArgs e)
        {

        }

        private void QuizTakingForm_Click(object sender, EventArgs e)
        {

        }
    }
}
