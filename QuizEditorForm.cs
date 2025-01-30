using defaultwinform.Properties;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace defaultwinform
{
    public partial class QuizEditorForm : Form
    {

        public Question editingQuestion;

        private List<Question> quizBuilderQuestions = new List<Question>();

        private Dictionary<Question, PictureBox> editLinked = new Dictionary<Question, PictureBox>();

        public QuizEditorForm()
        {
            InitializeComponent();
            this.Size = new Size(882, 724);
            this.MinimumSize = new Size(882, 724);
            this.MaximumSize = new Size(882, 724);
            this.CenterToScreen();
        }

        private void addQuestion()
        {

            

            MultipleChoice question = new MultipleChoice("Question", 1, "", new List<String> { "Answer 1", "Answer 2", "Answer 3", "Answer 4" }, "Answer 1");

            QuestionEditingPrompt questionEditingPrompt = new QuestionEditingPrompt(this);
            questionEditingPrompt.Show();
        }

        private void addQuestion(Question question)
        {

            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(228, 234, 239);
            panel.Size = new Size(114, 101);
            Label questionNumber = new Label();
            questionNumber.Text = "Question " + (questionLayoutPane.Controls.Count);
            questionNumber.Font = new System.Drawing.Font("Century Gothic", 12F, FontStyle.Bold);
            panel.Controls.Add(questionNumber);
            questionNumber.Location = new Point(15, 35);

            Panel header = new Panel();
            header.BackColor = Color.FromArgb(209, 216, 221);

            panel.Controls.Add(header);
            header.Size = new Size(114, 20);

            PictureBox indicator = new PictureBox();
            indicator.SizeMode = PictureBoxSizeMode.StretchImage;
            indicator.Image = (System.Drawing.Image)Resources.indicatorMC;
            panel.Controls.Add(indicator);
            indicator.Size = new Size(114, 30);
            indicator.Location = new Point(0, 70);

            PictureBox editIcon = new PictureBox();
            editIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            editIcon.Image = (System.Drawing.Image)Resources.editIcon;
            editIcon.Size = new Size(20, 20);
            editIcon.Location = new Point(70, 0);

            editIcon.Click += openQuestionEditor;

            header.Controls.Add(editIcon);

            PictureBox trashIcon = new PictureBox();
            trashIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            trashIcon.Image = (System.Drawing.Image)Resources.trashIcon;
            trashIcon.Size = new Size(20, 20);
            trashIcon.Location = new Point(90, 0);

            header.Controls.Add(trashIcon);

            Control addQuestionButton = null;

            foreach (Control control in questionLayoutPane.Controls)
            {
                if (control.Name.Equals("addQuestionPanel"))
                {
                    addQuestionButton = control;
                    break;
                }
            }

            editLinked.Add(question, editIcon);

            quizBuilderQuestions.Add(question);

            questionLayoutPane.Controls.Remove(addQuestionButton);

            questionLayoutPane.Controls.Add(panel);

            questionLayoutPane.Controls.Add(addQuestionButton);
        }

        private void buildQuiz()
        {
            if (!String.IsNullOrWhiteSpace(quizTitleField.Text)) {
                if (!String.IsNullOrWhiteSpace(quizTopicField.Text))
                {
                    Quiz quiz = new Quiz();

                    quiz.setQuestions(quizBuilderQuestions);
                    quiz.setTitle(quizTitleField.Text);
                    quiz.setTopic(quizTopicField.Text);
                    quiz.setImage(imageURLField.Text);

                    QuizDAO.addQuiz(quiz);

                    Form1 form = new Form1();
                    form.Show();
                    this.Close();
                }
            }
        }

        private void openQuestionEditor(object sender, EventArgs e) {

            if (editLinked.ContainsValue((PictureBox) sender))
            {
                foreach (Question key in editLinked.Keys)
                {
                    if (editLinked[key].Equals((PictureBox)sender))
                    {

                        int i = 1;
                        foreach (Question question in quizBuilderQuestions)
                        {
                            if (key.Equals(question))
                            {
                                break;
                            }

                            i++;
                        }
                    }
                        
                }
            }
        }

        public void updateEditingQuestion(Question updated)
        {
            addQuestion(updated);
        }

        private void QuizEditorForm_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addQuestionPanel_Click(object sender, EventArgs e)
        {
            addQuestion();
        }

        private void addQuestionLabel_Click(object sender, EventArgs e)
        {
            addQuestion();
        }

        private void addQuestionIcon_Click(object sender, EventArgs e)
        {
            addQuestion();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            buildQuiz();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            buildQuiz();
        }

        private void panel4_Click(object sender, EventArgs e)
        {

            buildQuiz();
        }
    }
}
