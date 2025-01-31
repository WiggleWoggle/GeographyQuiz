using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultwinform
{
    public partial class QuestionEditingPrompt : Form
    {

        private QuizEditorForm quizEditorForm;

        public QuestionEditingPrompt(QuizEditorForm form)
        {
            InitializeComponent();
            this.CenterToScreen();

            quizEditorForm = form;

            buildEditingSettings();
        }

        private void QuestionEditingPrompt_Click(object sender, EventArgs e)
        {

        }

        private void buildEditingSettings()
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (isValidQuestion())
            {
                returnQuestion();
            }
        }

        private Boolean isValidQuestion()
        {
            if (validQuestion(questionField.Text))
            {
                if (isValidStarValue(starField.Text))
                {
                    if (!String.IsNullOrWhiteSpace(imageURLField.Text))
                    {
                        if (multipleChoiceOption.Checked || multipleAnswerChoice.Checked)
                        {
                            if ((!String.IsNullOrWhiteSpace(choiceOneField.Text) && (!String.IsNullOrWhiteSpace(choiceOneField.Text)) && (!String.IsNullOrWhiteSpace(choiceThreeField.Text)) && (!String.IsNullOrWhiteSpace(choiceFourField.Text)))) 
                            {
                                if (!String.IsNullOrWhiteSpace(answerField.Text))
                                {
                                    return true;
                                }
                            }
                        } else if (shortResponseOption.Checked)
                        {
                            if (!String.IsNullOrWhiteSpace(keywordsField.Text))
                            {
                                return true;
                            }
                        }
                        else if (trueorFalseOption.Checked)
                        {
                            if (!String.IsNullOrWhiteSpace(truefalseField.Text))
                            {
                                if (isValidTrueFalseAnswer(truefalseField.Text))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        private void returnQuestion()
        {

            if (multipleChoiceOption.Checked)
            {
                String questionString = questionField.Text;
                int starValue = getStarValue(starField.Text);
                String URL = imageURLField.Text;
                List<String> choices = new List<String> { choiceOneField.Text, choiceTwoField.Text, choiceThreeField.Text, choiceFourField.Text };
                String answer = answerField.Text;

                MultipleChoice question = new MultipleChoice(questionString, starValue, URL, choices, answer);
                quizEditorForm.updateEditingQuestion(question);
                this.Close();
            }
            
            if (trueorFalseOption.Checked)
            {
                String questionString = questionField.Text;
                int starValue = getStarValue(starField.Text);
                Boolean answer = trueFalseAnswer(truefalseField.Text);
                String URL = imageURLField.Text;

                TrueFalseQuestion question = new TrueFalseQuestion(questionString, starValue, answer, URL);
                quizEditorForm.updateEditingQuestion(question);
                this.Close();

            }

            if (multipleAnswerChoice.Checked)
            {
                String questionString = questionField.Text;
                int starValue = getStarValue(starField.Text);
                List<String> choices = new List<String> { choiceOneField.Text, choiceTwoField.Text, choiceThreeField.Text, choiceFourField.Text };
                List<String> answers = multipleAnswers(answerField.Text);
                String URL = imageURLField.Text;

                MultipleAnswer question = new MultipleAnswer(questionString, starValue, URL, choices, answers);
                quizEditorForm.updateEditingQuestion(question);
                this.Close();
            }

            if (shortResponseOption.Checked)
            {
                String questionString = questionField.Text;
                int starValue = getStarValue(starField.Text);
                List<String> keywords = multipleAnswers(keywordsField.Text);
                String URL = imageURLField.Text;

                ShortResponse question = new ShortResponse(questionString, starValue, keywords, URL);
                quizEditorForm.updateEditingQuestion(question);
                this.Close();
            }
        }

        private void switchType()
        {
            if (multipleChoiceOption.Checked)
            {
                mcPanel.Visible = true;
                tfPanel.Visible = false;
                srPanel.Visible = false;

            }
            else if (multipleAnswerChoice.Checked)
            {
                mcPanel.Visible = true;
                tfPanel.Visible = false;
                srPanel.Visible = false;

            }
            else if (trueorFalseOption.Checked)
            {
                mcPanel.Visible = false;
                tfPanel.Visible = true;
                srPanel.Visible = false;
            }
            else
            {
                mcPanel.Visible = false;
                tfPanel.Visible = false;
                srPanel.Visible = true;
            }
        }

        private void multipleChoiceOption_CheckedChanged(object sender, EventArgs e)
        {
            switchType();
        }

        private void multipleAnswerChoice_CheckedChanged(object sender, EventArgs e)
        {
            switchType();
        }

        private void trueorFalseOption_CheckedChanged(object sender, EventArgs e)
        {
            switchType();
        }

        private void shortResponseOption_CheckedChanged(object sender, EventArgs e)
        {
            switchType();
        }

        private Boolean validQuestion(String question)
        {
            if (question.Length >= 15)
            {
                return true;
            }

            return false;
        }

        private Boolean isValidStarValue(String unparsed)
        {
            int n;
            bool isNumeric = int.TryParse(unparsed, out n);
            return isNumeric;
        }

        private int getStarValue(String unparsed)
        {
            int n;
            bool isNumeric = int.TryParse(unparsed, out n);

            return n;
        }

        private Boolean isValidTrueFalseAnswer(String answer)
        {

            answer = answer.ToLower();
            answer = answer.Trim();

            if (answer.Contains("true") || answer.Contains("false")) {
                return true;
            }

            return false;
        }

        private Boolean trueFalseAnswer(String answer)
        {

            answer = answer.ToLower();
            answer = answer.Trim();

            if (answer.Contains("true"))
            {
                return true;
            }

            return false;
        }

        private List<String> multipleAnswers(String answers)
        {
            string[] words = answers.Split(',');

            return words.ToList();
        }
    }
}
