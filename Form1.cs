using System;
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

            String hashed = PasswordHandler.encryptPassword("testpassword");

            Console.WriteLine(hashed);

            if (PasswordHandler.decryptPassword("testpassword", hashed))
            {

                Console.WriteLine("Successful match!");
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
