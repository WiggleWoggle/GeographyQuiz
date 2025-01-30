using defaultwinform.Properties;
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
    public partial class QuizEditorForm : Form
    {

        private List<Question> quizBuilderQuestions = new List<Question>();

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

            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(228, 234, 239);
            panel.Size = new Size(114, 101);
            Label questionNumber = new Label();
            questionNumber.Text = "Question " + (questionLayoutPane.Controls.Count);
            questionNumber.Font = new System.Drawing.Font("Century Gothic", 12F, FontStyle.Bold);
            panel.Controls.Add(questionNumber);
            questionNumber.Location = new Point(15, 30);

            Panel header = new Panel();
            header.BackColor = Color.FromArgb(209, 216, 221);

            panel.Controls.Add(header);
            header.Size = new Size(114, 20);

            PictureBox indicator = new PictureBox();
            indicator.Image = (System.Drawing.Image) Resources.blueButton;
            panel.Controls.Add(indicator);
            indicator.Size = new Size(114, 30);
            indicator.Location = new Point(0, 70);


            Control addQuestionButton = null;

            foreach (Control control in questionLayoutPane.Controls)
            {
                if (control.Name.Equals("addQuestionPanel"))
                {
                    addQuestionButton = control;
                    break;
                }
            }

            MultipleChoice question = new MultipleChoice("Question", 1, "", new List<String> { "Answer 1", "Answer 2", "Answer 3", "Answer 4" }, "Answer 1");

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
