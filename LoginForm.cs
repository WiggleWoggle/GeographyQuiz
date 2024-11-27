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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Size = new Size(594, 692);
            this.MinimumSize = new Size(594, 692);
            this.MaximumSize = new Size(594, 692);

            AccountDAO accountDAO = new AccountDAO();
            accountDAO.getAccounts();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignupForm form = new SignupForm();
            form.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            String inputtedUsername = usernameField.Text;
            String inputtedPassword = passwordField.Text;
            String encryptedPassword = PasswordHandler.encryptPassword(inputtedPassword);

            //database call

            foreach (UserAccount account in AccountDAO.userAccounts)
            {

                if (account.getUsername().Equals(usernameField.Text))
                {
                    if (account.getEncryptedPassword().Equals(encryptedPassword))
                    {
                        form.Show();
                        this.Close();
                    } else
                    {

                        incorrectLabel.Text = "THIS PASSWORD IS WRONG!";
                    }
                }
            }
        }

        private void incorrectLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
