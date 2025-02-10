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
    public partial class TeacherPortal : Form
    {

        private List<Quiz> builtQuizzes = new List<Quiz>();

        public TeacherPortal()
        {
            InitializeComponent();
            this.Size = new Size(1111, 719);
            this.MinimumSize = new Size(1111, 719);
            this.MaximumSize = new Size(1111, 719);
            this.CenterToScreen();

            buildQuizPanels();
        }

        private void TeacherPortal_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        public void buildQuizPanels()
        {
            foreach (Quiz quiz in QuizDAO.getAssignedQuizzes())
            {
                if (!builtQuizzes.Contains(quiz))
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(236, 207);
                    panel.BackColor = Color.FromArgb(228, 234, 239);

                    Panel header = new Panel();
                    header.Size = new Size(236, 50);
                    header.BackColor = Color.FromArgb(209, 216, 221);

                    Label quizName = new Label();
                    quizName.Text = quiz.getTitle();
                    quizName.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                    quizName.Location = new Point(30, 10);

                    Label average = new Label();
                    average.Text = "Student Average: xx%" ;
                    average.Font = new Font("Century Gothic", 10);
                    average.Size = new Size(average.Size.Width + 100, average.Size.Height);
                    average.Location = new Point(10, 60);

                    Label attemptedStatus = new Label();
                    attemptedStatus.Text = "Unattempted";
                    attemptedStatus.Font = new Font("Century Gothic", 10);
                    attemptedStatus.TextAlign = ContentAlignment.MiddleRight;
                    attemptedStatus.Size = new Size(attemptedStatus.Size.Width + 40, attemptedStatus.Size.Height);
                    attemptedStatus.Location = new Point(90, 127);

                    panel.Controls.Add(header);
                    header.Controls.Add(quizName);
                    panel.Controls.Add(average);
                    panel.Controls.Add(attemptedStatus);

                    assignedFlowLayoutPanel.Controls.Add(panel);

                    //QuizPanel quizPanel = new QuizPanel(quiz, panel, quizName, questionCount, quizTopic, attemptedStatus, header);

                    //QuizDAO.addQuizPanel(quizPanel);


                    builtQuizzes.Add(quiz);
                }
            }

            foreach (Quiz quiz in QuizDAO.getUnAssignedQuizzes())
            {
                if (!builtQuizzes.Contains(quiz))
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(236, 207);
                    panel.BackColor = Color.FromArgb(228, 234, 239);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = quiz.getImage();
                    pictureBox.Size = new Size(236, 125);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    Label quizName = new Label();
                    quizName.Text = quiz.getTitle();
                    quizName.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                    quizName.Location = new Point(2, 127);

                    Label quizTopic = new Label();
                    quizTopic.Text = "Topic: " + quiz.getTopic();
                    quizTopic.Font = new Font("Century Gothic", 10);
                    quizTopic.Size = new Size(quizTopic.Size.Width + 100, quizTopic.Size.Height);
                    quizTopic.Location = new Point(2, 155);

                    Label questionCount = new Label();
                    questionCount.Text = quiz.getQuestions().Count + "";

                    if (quiz.getQuestions().Count != 1)
                    {
                        questionCount.Text += " Questions";
                    }
                    else
                    {
                        questionCount.Text += " Question";
                    }

                    questionCount.Font = new Font("Century Gothic", 10);
                    questionCount.Location = new Point(2, 178);

                    Label attemptedStatus = new Label();
                    attemptedStatus.Text = "Unattempted";
                    attemptedStatus.Font = new Font("Century Gothic", 10);
                    attemptedStatus.TextAlign = ContentAlignment.MiddleRight;
                    attemptedStatus.Size = new Size(attemptedStatus.Size.Width + 40, attemptedStatus.Size.Height);
                    attemptedStatus.Location = new Point(90, 127);

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(quizName);
                    panel.Controls.Add(quizTopic);
                    panel.Controls.Add(questionCount);
                    panel.Controls.Add(attemptedStatus);

                    unassignedFlowLayoutPanel.Controls.Add(panel);

                    QuizPanel quizPanel = new QuizPanel(quiz, panel, quizName, questionCount, quizTopic, attemptedStatus, pictureBox);

                    QuizDAO.addQuizPanel(quizPanel);


                    builtQuizzes.Add(quiz);
                }
            }
        }

        private void createQuizPanel_Click(object sender, EventArgs e)
        {
            QuizEditorForm form = new QuizEditorForm();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QuizEditorForm form = new QuizEditorForm();
            form.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            QuizEditorForm form = new QuizEditorForm();
            form.Show();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            LeaderboardForm form = new LeaderboardForm();
            form.Show();
            this.Close();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            Shop form = new Shop();
            form.Show();
            this.Close();
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            ProfileEditingForm form = new ProfileEditingForm();
            form.Show();
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            TeacherPortal form = new TeacherPortal();
            form.Show();
            this.Close();
        }

        private void gradesButton_Click(object sender, EventArgs e)
        {
            GradesForm form = new GradesForm();
            form.Show();
            this.Close();
        }

        private void TeacherPortal_Click(object sender, EventArgs e)
        {

        }
    }
}
