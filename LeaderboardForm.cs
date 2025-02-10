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
    public partial class LeaderboardForm : Form
    {

        public LeaderboardForm()
        {
            InitializeComponent();
            this.Size = new Size(1111, 719);
            this.MinimumSize = new Size(1111, 719);
            this.MaximumSize = new Size(1111, 719);
            this.CenterToScreen();
            populateLeaderboard();
        }

        private void LeaderboardForm_Click(object sender, EventArgs e)
        {

        }


        private void populateLeaderboard()
        {

            AccountDAO.userAccounts = AccountDAO.userAccounts.OrderByDescending(account => account.getStarsCount()).ToList();

            foreach (UserAccount account in AccountDAO.userAccounts)
            {

                Panel panel = new Panel();
                panel.BackColor = Color.FromArgb(228, 234, 239);
                panel.Size = new Size(837, 101);

                Panel whiteBG = new Panel();
                whiteBG.BackColor = Color.FromArgb(255, 255, 255);
                whiteBG.Size = new Size(80, 101);

                Panel whiteBG2 = new Panel();
                whiteBG2.BackColor = Color.FromArgb(255, 255, 255);
                whiteBG2.Size = new Size(100, 101);

                panel.Controls.Add(whiteBG);
                panel.Controls.Add(whiteBG2);

                whiteBG2.Location = new Point(737, 0);

                RoundedPanel ranking = new RoundedPanel();
                ranking.Size = new Size(50, 50);
                ranking.BorderRadius = 30;
                ranking.Location = new Point(15, 25);
                ranking.BackColor = Color.FromArgb(228, 234, 239);

                Label username = new Label();
                username.Text = account.getUsername();
                username.Font = new System.Drawing.Font("Century Gothic", 14F, FontStyle.Bold);
                panel.Controls.Add(username);
                username.AutoSize = true;
                username.Location = new Point(90, 10);

                whiteBG.Controls.Add(ranking);

                PictureBox profilePic = new PictureBox();
                profilePic.Size = new Size(50, 50);
                profilePic.Image = Resources.defaultProfile;
                profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                panel.Controls.Add(profilePic);
                profilePic.Location = new Point(90, 40);

                RoundedPanel starBG = new RoundedPanel();
                panel.Controls.Add(starBG);
                starBG.Size = new Size(100, 40);
                starBG.BorderRadius = 30;
                starBG.Location = new Point(150, 45);
                starBG.BackColor = Color.FromArgb(182, 189, 202);

                PictureBox starPic = new PictureBox();
                starPic.Size = new Size(30, 30);
                starPic.Image = Resources.star;
                starPic.SizeMode = PictureBoxSizeMode.StretchImage;
                starBG.Controls.Add(starPic);
                starPic.Location = new Point(10, 5);

                Label starCount = new Label();
                starCount.Text = "x " + account.getStarsCount();
                starCount.ForeColor = Color.White;
                starCount.Font = new System.Drawing.Font("Century Gothic", 14F, FontStyle.Bold);
                starBG.Controls.Add(starCount);
                starCount.AutoSize = true;
                starCount.TextAlign = ContentAlignment.MiddleLeft;
                starCount.Location = new Point(42, 7);         

                Label rankingText = new Label();
                rankingText.Text = "" + (AccountDAO.userAccounts.IndexOf(account) + 1);
                rankingText.Font = new System.Drawing.Font("Century Gothic", 14F, FontStyle.Bold);
                ranking.Controls.Add(rankingText);
                //rankingText.AutoSize = true;
                rankingText.Dock = DockStyle.Fill;
                rankingText.TextAlign = ContentAlignment.MiddleCenter;
                rankingText.Location = new Point(10, 10);

                Label bestTopic = new Label();
                bestTopic.Text = "Best Topic: TEST";
                bestTopic.Font = new System.Drawing.Font("Century Gothic", 14F);
                panel.Controls.Add(bestTopic);
                bestTopic.TextAlign = ContentAlignment.MiddleLeft;
                bestTopic.Location = new Point(260, 40);
                bestTopic.AutoSize = true;

                PictureBox viewIcon = new PictureBox();
                viewIcon.Size = new Size(50, 50);
                viewIcon.Image = Resources.viewIcon;
                viewIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                whiteBG2.Controls.Add(viewIcon);
                viewIcon.Location = new Point(10, 25);

                userFlowLayout.Controls.Add(panel);

                int rankingNum = (AccountDAO.userAccounts.IndexOf(account) + 1);

                if (rankingNum == 1)
                {
                    ranking.BackColor = Color.FromArgb(255, 199, 0);
                    rankingText.ForeColor = Color.White;
                } else if (rankingNum == 2)
                {
                    ranking.BackColor = Color.FromArgb(198, 222, 241);
                    rankingText.ForeColor = Color.White;
                }
                else if (rankingNum == 3)
                {
                    ranking.BackColor = Color.FromArgb(180, 95, 6);
                    rankingText.ForeColor = Color.White;
                }
            }
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

        private void userFlowLayout_Click(object sender, EventArgs e)
        {

        }
    }
}
