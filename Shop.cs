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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            this.Size = new Size(1111, 719);
            this.MinimumSize = new Size(1111, 719);
            this.MaximumSize = new Size(1111, 719);
            this.CenterToScreen();

            accountStarLabel.Text = "x " + Program.currentAccount.getStarsCount();

            if (Program.profilePicPath != null)
            {
                profileOverlay.Image = new Bitmap(Program.profilePicPath);
            } else
            {
                profileOverlay.Image = Resources.defaultProfile;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Shop_Click(object sender, EventArgs e)
        {

        }

        private void multiplierPanel_Click(object sender, EventArgs e)
        {
            if (Program.currentAccount.getStarsCount() >= 8)
            {
                Program.currentAccount.setStarsCount(Program.currentAccount.getStarsCount() - 8);
                accountStarLabel.Text = "x " + Program.currentAccount.getStarsCount();
                Program.currentAccount.setMultiplyCount(Program.currentAccount.getMultiplyCount() + 1);
            }
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void immunityPanel_Click(object sender, EventArgs e)
        {
            if (Program.currentAccount.getStarsCount() >= 9)
            {
                Program.currentAccount.setStarsCount(Program.currentAccount.getStarsCount() - 9);
                accountStarLabel.Text = "x " + Program.currentAccount.getStarsCount();
                Program.currentAccount.setImmunityCount(Program.currentAccount.getImmunityCount() + 1);
            }
        }

        private void eliminatePanel_Click(object sender, EventArgs e)
        {
            if (Program.currentAccount.getStarsCount() >= 4)
            {
                Program.currentAccount.setStarsCount(Program.currentAccount.getStarsCount() - 4);
                accountStarLabel.Text = "x " + Program.currentAccount.getStarsCount();
                Program.currentAccount.setEliminateCount(Program.currentAccount.getEliminateCount() + 1);
            }
        }

        private void highStakesPanel_Click(object sender, EventArgs e)
        {
            if (Program.currentAccount.getStarsCount() >= 9)
            {
                Program.currentAccount.setStarsCount(Program.currentAccount.getStarsCount() - 9);
                accountStarLabel.Text = "x " + Program.currentAccount.getStarsCount();
                Program.currentAccount.setStakesCount(Program.currentAccount.getStakesCount() + 1);
            }
        }

        private void doublerPanel_Click(object sender, EventArgs e)
        {
            if (Program.currentAccount.getStarsCount() >= 4)
            {
                Program.currentAccount.setStarsCount(Program.currentAccount.getStarsCount() - 4);
                accountStarLabel.Text = "x " + Program.currentAccount.getStarsCount();
                Program.currentAccount.setDoubleCount(Program.currentAccount.getDoubleCount() + 1);
            }
        }

        private void skipPanel_Click(object sender, EventArgs e)
        {
            if (Program.currentAccount.getStarsCount() >= 6)
            {
                Program.currentAccount.setStarsCount(Program.currentAccount.getStarsCount() - 6);
                accountStarLabel.Text = "x " + Program.currentAccount.getStarsCount();
                Program.currentAccount.setSkipCount(Program.currentAccount.getSkipCount() + 1);
            }
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
