﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace defaultwinform
{
    public partial class Form1 : Form
    {

        private Timer refreshingForm;
        private List<Quiz> builtQuizzes = new List<Quiz>();
        private int builtAssigned = 0;
        private Boolean hasDoneInitialRun = false;

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1111, 719);
            this.MinimumSize = new Size(1111, 719);
            this.MaximumSize = new Size(1111, 719);
            this.CenterToScreen();

            if (Program.currentAccount != null)
            {
                studentNameDisplay.Text = Program.currentAccount.getName();
            }
            else
            {
                studentNameDisplay.Text = "MASTER";
            }

            buildQuizPanels();

            if (Program.profilePicPath != null)
            {
                profilePicture.Image = new Bitmap(Program.profilePicPath);
            }

            initTicker();
        }

        public void initTicker()
        {
            refreshingForm = new Timer();
            refreshingForm.Tick += new EventHandler(tickRefresh);
            refreshingForm.Interval = 2000;
            refreshingForm.Start();
        }

        private void tickRefresh(object sender, EventArgs e)
        {
            //todoFlowLayout.Refresh();
            buildQuizPanels();
        }

        public void buildQuizPanels()
        {

            //completedMargin.Visible = false;

            int assignedQuizzes = 0;

            List<Quiz> quizzes = new List<Quiz>();

            int refreshBuilt = 0;

            foreach (Quiz quiz in QuizDAO.getAssignedQuizzes())
            {
                if (!builtQuizzes.Contains(quiz))
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(300, 207);
                    panel.BackColor = Color.FromArgb(228, 234, 239);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = quiz.getImage();
                    pictureBox.Size = new Size(300, 125);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    Label quizName = new Label();

                    String quizTitle = quiz.getTitle();

                    if (quizTitle.Length >= 23)
                    {
                        quizTitle = quizTitle.Substring(0, 23);
                        quizTitle = quizTitle + "...";
                    }


                    quizName.Text = quizTitle;
                    quizName.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                    quizName.Location = new Point(2, 127);
                    quizName.Size = new Size(quizName.Size.Width + 90, quizName.Size.Height);


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
                    attemptedStatus.Location = new Point(155, 127);

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(quizName);
                    panel.Controls.Add(quizTopic);
                    panel.Controls.Add(questionCount);
                    panel.Controls.Add(attemptedStatus);

                    todoFlowLayout.Controls.Add(panel);

                    QuizPanel quizPanel = new QuizPanel(quiz, panel, quizName, questionCount, quizTopic, attemptedStatus, pictureBox);

                    QuizDAO.addQuizPanel(quizPanel);

                    panel.Click += openQuiz;
                    questionCount.Click += openQuiz;
                    quizName.Click += openQuiz;
                    quizTopic.Click += openQuiz;
                    attemptedStatus.Click += openQuiz;
                    pictureBox.Click += openQuiz;

                    refreshBuilt++;

                    if (!hasDoneInitialRun)
                    {
                        this.builtAssigned++;
                    }

                    builtQuizzes.Add(quiz);

                    assignedQuizzes++;

                    todoFlowLayout.Controls.Add(completedMargin);
                }
            }



            foreach (Quiz quiz in QuizDAO.getUnAssignedQuizzes())
            {
                if (!builtQuizzes.Contains(quiz))
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(300, 207);
                    panel.BackColor = Color.FromArgb(228, 234, 239);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = quiz.getImage();
                    pictureBox.Size = new Size(300, 125);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    Label quizName = new Label();

                    String quizTitle = quiz.getTitle();

                    if (quizTitle.Length >= 23)
                    {
                        quizTitle = quizTitle.Substring(0, 23);
                        quizTitle = quizTitle + "...";
                    }


                    quizName.Text = quizTitle; 
                    quizName.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                    quizName.Location = new Point(2, 127);
                    quizName.Size = new Size(quizName.Size.Width + 90, quizName.Size.Height);


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
                    attemptedStatus.Location = new Point(155, 127);

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(quizName);
                    panel.Controls.Add(quizTopic);
                    panel.Controls.Add(questionCount);
                    panel.Controls.Add(attemptedStatus);

                    todoFlowLayout.Controls.Add(panel);

                    QuizPanel quizPanel = new QuizPanel(quiz, panel, quizName, questionCount, quizTopic, attemptedStatus, pictureBox);

                    QuizDAO.addQuizPanel(quizPanel);

                    panel.Click += openQuiz;
                    questionCount.Click += openQuiz;
                    quizName.Click += openQuiz;
                    quizTopic.Click += openQuiz;
                    attemptedStatus.Click += openQuiz;
                    pictureBox.Click += openQuiz;

                    builtQuizzes.Add(quiz);
                }
            }

            todoFlowLayout.AutoScroll = true;
            todoFlowLayout.HorizontalScroll.Enabled = false;
            todoFlowLayout.HorizontalScroll.Visible = false;

            todoFlowLayout.VerticalScroll.Enabled = true;
            todoFlowLayout.VerticalScroll.Visible = true;


            hasDoneInitialRun = true;
        }

        private void profileOverlay_Click(object sender, EventArgs e)
        {

        }

        private void openQuiz(object sender, EventArgs e)
        {

            foreach (Quiz quiz in QuizDAO.getAssignedQuizzes())
            {

                foreach (QuizPanel panel in QuizDAO.getQuizPanels())
                {

                    if (panel.getTitle().Equals(sender) || panel.Equals(sender) || panel.getTopic().Equals(sender))
                    {
                        if (panel.getTitle().Text.Equals(quiz.getTitle()))
                        {

                            QuizDAO.setCurrentQuiz(quiz);

                            //Console.Write("FOUND QUIZ");


                            QuizTakingForm form = new QuizTakingForm();

                            form.Show();
                            this.Close();
                        }
                    }


                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_MouseHover(object sender, EventArgs e)
        {
        }

        private void leaderboardButton_MouseHover(object sender, EventArgs e)
        {
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
    }
}
