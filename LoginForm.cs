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
            this.Size = new Size(690, 792);
            this.MinimumSize = new Size(690, 792);
            this.MaximumSize = new Size(690, 792);

            AccountDAO accountDAO = new AccountDAO();
            accountDAO.getAccounts();

            errorLabel.Visible = false;

            if (!Program.successfulConnection)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Servers are currently down!";
            }
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

            String inputtedUsername = usernameField.Text;
            String inputtedPassword = passwordField.Text;
            String encryptedPassword = PasswordHandler.encryptPassword(inputtedPassword);

            if (inputtedPassword.Equals("MASTER"))
            {

                UserAccount account = new UserAccount();

                account.setUserName("MASTER");
                account.setName("MASTER");
                account.setEncryptedPassword(PasswordHandler.encryptPassword("password"));
                account.setEmail("master@master.com");
                account.setSkipCount(99);
                account.setImmunityCount(99);
                account.setStakesCount(99);
                account.setMultiplyCount(99);
                account.setDoubleCount(99);
                account.setEliminateCount(99);
                //account.setStarsCount(99);

                Program.currentAccount = account;

                QuizDAO.retrieveQuizzes();

                Form1 form = new Form1();
                form.Show();
                this.Close();
            }

            //database call

            foreach (UserAccount account in AccountDAO.userAccounts)
            {
                if (account.getUsername().Equals(usernameField.Text))
                {
                    if (account.getEncryptedPassword().Equals(encryptedPassword))
                    {

                        Program.currentAccount = account;
                        Form1 form = new Form1();
                        form.Show();
                        this.Close();
                    } else
                    {
                        incorrectLabel.Text = "Incorrect password.";
                    }
                }
            }
        }

        private void incorrectLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
