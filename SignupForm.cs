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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Size = new Size(594, 692);
            this.MinimumSize = new Size(594, 692);
            this.MaximumSize = new Size(594, 692);

            incorrectLabel.Text = " ";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();

            String preCheckPassword = passwordField.Text;
            String preCheckUsername = usernameField.Text;
            String preCheckName = nameField.Text;

            if (PasswordHandler.validPassword(preCheckPassword))
            {

                if (PasswordHandler.validUsername(preCheckUsername))
                {
                    if (PasswordHandler.validUsername(preCheckName))
                    {

                        AccountDAO accountDAO = new AccountDAO();

                        //make the other constructor
                        UserAccount newAccount = new UserAccount();
                        newAccount.setName(preCheckName);
                        newAccount.setUserName(preCheckUsername);
                        newAccount.setEncryptedPassword(PasswordHandler.encryptPassword(preCheckPassword));

                        accountDAO.addAccount(newAccount);

                        form.Show();
                        this.Close();
                    }
                }
            } else
            {
                incorrectLabel.Text = PasswordHandler.passwordIssue;
            }
        }
    }
}
