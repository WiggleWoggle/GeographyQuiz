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
                    panel.Size = new Size(236, 140);
                    panel.BackColor = Color.FromArgb(228, 234, 239);

                    Panel header = new Panel();
                    header.Size = new Size(236, 42);
                    header.BackColor = Color.FromArgb(209, 216, 221);

                    Label quizName = new Label();
                    quizName.Text = quiz.getTitle();
                    quizName.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                    quizName.Location = new Point(35, 10);

                    Label average = new Label();
                    average.Text = "Student Average: xx%";
                    average.Font = new Font("Century Gothic", 10);
                    average.Size = new Size(average.Size.Width + 100, average.Size.Height);
                    average.Location = new Point(10, 55);

                    Label attemptedStatus = new Label();
                    attemptedStatus.Text = "Unattempted";
                    attemptedStatus.Font = new Font("Century Gothic", 10);
                    attemptedStatus.TextAlign = ContentAlignment.MiddleLeft;
                    attemptedStatus.Size = new Size(attemptedStatus.Size.Width + 40, attemptedStatus.Size.Height);
                    attemptedStatus.Location = new Point(10, 100);

                    PictureBox deleteIcon = new PictureBox();
                    deleteIcon.Image = Resources.deleteIcon;
                    deleteIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    deleteIcon.Size = new Size(25, 25);
                    deleteIcon.Location = new Point(10, 10);

                    Panel statusBarUnderlay = new Panel();
                    statusBarUnderlay.BackColor = Color.FromArgb(255, 0, 0);
                    statusBarUnderlay.Size = new Size(200, 10);
                    panel.Controls.Add(statusBarUnderlay);
                    statusBarUnderlay.Location = new Point(13, 83);


                    //int newWidth = (int)((amountRight / (double)questionCount) * 316);

                    //performanceOverlay.Width = newWidth;

                    panel.Controls.Add(header);
                    header.Controls.Add(quizName);
                    header.Controls.Add(deleteIcon);
                    panel.Controls.Add(average);
                    panel.Controls.Add(attemptedStatus);

                    assignedFlowLayoutPanel.Controls.Add(panel);

                    QuizPanel quizPanel = new QuizPanel(quiz, panel, deleteIcon);

                    QuizDAO.addQuizPanel(quizPanel);


                    builtQuizzes.Add(quiz);
                }
            }

            foreach (Quiz quiz in QuizDAO.getUnAssignedQuizzes())
            {
                if (!builtQuizzes.Contains(quiz))
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(236, 140);
                    panel.BackColor = Color.FromArgb(228, 234, 239);

                    Panel header = new Panel();
                    header.Size = new Size(236, 42);
                    header.BackColor = Color.FromArgb(209, 216, 221);

                    Label quizName = new Label();
                    quizName.Text = quiz.getTitle();
                    quizName.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                    quizName.Location = new Point(40, 10);

                    Label edit = new Label();
                    edit.Text = "Edit Questions";
                    edit.Font = new Font("Century Gothic", 10);
                    edit.Size = new Size(edit.Size.Width + 100, edit.Size.Height);
                    edit.Location = new Point(35, 55);

                    Label settings = new Label();
                    settings.Text = "Settings";
                    settings.Font = new Font("Century Gothic", 10);
                    settings.TextAlign = ContentAlignment.MiddleLeft;
                    settings.Size = new Size(settings.Size.Width + 40, settings.Size.Height);
                    settings.Location = new Point(35, 75);

                    Label view = new Label();
                    view.Text = "View as Student";
                    view.Font = new Font("Century Gothic", 10);
                    view.TextAlign = ContentAlignment.MiddleLeft;
                    view.Size = new Size(view.Size.Width + 40, view.Size.Height);
                    view.Location = new Point(35, 100);

                    PictureBox deleteIcon = new PictureBox();
                    deleteIcon.Image = Resources.addIcon;
                    deleteIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    deleteIcon.Size = new Size(25, 25);
                    deleteIcon.Location = new Point(10, 10);


                    PictureBox editIcon = new PictureBox();
                    editIcon.Image = Resources.editIcon;
                    editIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    editIcon.Size = new Size(15, 15);
                    editIcon.Location = new Point(15, 57);

                    PictureBox settingsIcon = new PictureBox();
                    settingsIcon.Image = Resources.settingsIcon;
                    settingsIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    settingsIcon.Size = new Size(15, 15);
                    settingsIcon.Location = new Point(15, 80);

                    PictureBox studentIcon = new PictureBox();
                    studentIcon.Image = Resources.studentViewIcon;
                    studentIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    studentIcon.Size = new Size(15, 15);
                    studentIcon.Location = new Point(15, 105);


                    //int newWidth = (int)((amountRight / (double)questionCount) * 316);

                    //performanceOverlay.Width = newWidth;

                    panel.Controls.Add(header);
                    header.Controls.Add(quizName);
                    header.Controls.Add(deleteIcon);
                    panel.Controls.Add(edit);
                    panel.Controls.Add(settings);
                    panel.Controls.Add(view);
                    panel.Controls.Add(editIcon);
                    panel.Controls.Add(settingsIcon);
                    panel.Controls.Add(studentIcon);

                    deleteIcon.Click += assignClick;

                    unassignedFlowLayoutPanel.Controls.Add(panel);

                    QuizPanel quizPanel = new QuizPanel(quiz, panel, deleteIcon);

                    QuizDAO.addQuizPanel(quizPanel);

                    builtQuizzes.Add(quiz);
                }
            }
        }

        private void assignClick(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                foreach (QuizPanel quizPanel in QuizDAO.getQuizPanels().ToList())
                {
                    if (quizPanel.getAddIcon() != null)
                    {
                        if (quizPanel.getAddIcon().Equals(control))
                        {
                            QuizDAO.deleteFromDrive(quizPanel.getQuiz());
                            QuizDAO.addQuiz(quizPanel.getQuiz());
                            QuizDAO.removeUnassignedQuiz(quizPanel.getQuiz());

                            unassignedFlowLayoutPanel.Controls.Clear();
                            assignedFlowLayoutPanel.Controls.Clear();

                            builtQuizzes.Clear();

                            buildQuizPanels();
                        }
                    }
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
