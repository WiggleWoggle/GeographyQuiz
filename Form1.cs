﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultwinform
{
    public partial class Form1 : Form
    {

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
            } else
            {
                studentNameDisplay.Text = "MASTER";
            }

            QuizDAO.retrieveQuizzes();

            buildQuizPanels();
        }

        private void buildQuizPanels()
        {
            foreach (Quiz quiz in QuizDAO.getQuizzes())
            {

                Panel panel = new Panel();
                panel.Size = new Size(236, 207);
                panel.BackColor = Color.FromArgb(228, 234, 239);

                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = quiz.getImage();
                pictureBox.Size = new Size(236, 125);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                Label quizName = new Label();
                quizName.Text = "Quiz " + "24";
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
                } else
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

                todoFlowLayout.Controls.Add(panel);

                QuizPanel quizPanel = new QuizPanel(quiz, panel, quizName, questionCount, quizTopic, attemptedStatus, pictureBox);

                QuizDAO.addQuizPanel(quizPanel);

                panel.Click += openQuiz;
                questionCount.Click += openQuiz;
                quizName.Click += openQuiz;
                quizTopic.Click += openQuiz;
                attemptedStatus.Click += openQuiz;
                pictureBox.Click += openQuiz;
            }
        }

        private void profileOverlay_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                profileUnderlay.BackColor = colorPicker.Color;
            }
        }

        private void openQuiz(object sender, EventArgs e)
        {
            QuizTakingForm form = new QuizTakingForm();
            form.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_MouseHover(object sender, EventArgs e)
        {
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
        }

        private void leaderboardButton_MouseHover(object sender, EventArgs e)
        {
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            Shop form = new Shop();
            form.Show();
            this.Close();
        }
    }
}
