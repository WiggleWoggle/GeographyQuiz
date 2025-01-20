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
    public partial class ProfileEditingForm : Form
    {

        public Boolean editing = false;

        public ProfileEditingForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            try
            {
                profileIcon.Image = new Bitmap(Program.profilePicPath);
            }
            catch (Exception ex)
            {
                profileIcon.Image = Resources.defaultProfile;
            }

            usernameDisplay.Text = Program.currentAccount.getUsername();
            studentNameDisplay.Text = Program.currentAccount.getName();
            emailField.Text = Program.currentAccount.getEmail();

            usernameInput.Visible = false;
            passwordInput.Visible = false;
            nameInput.Visible = false;
            emailInput.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a PNG File";
                
                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    try
                    {
                        String selectedFilePath = openFileDialog.FileName;
                        profileIcon.Image = new Bitmap(selectedFilePath);

                        Program.profilePicPath = selectedFilePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            usernameInput.Visible = true;
            passwordInput.Visible = true;
            nameInput.Visible = true;
            emailInput.Visible = true;

            editButton.Visible = false;

            usernameDisplay.Visible = false;
            studentNameDisplay.Visible = false;
            emailField.Visible = false;

            editing = true;
            profileIcon.Image = Resources.profileEdit;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (PasswordHandler.validUsername(usernameInput.Text))
            {
                if (PasswordHandler.validPassword(passwordInput.Text))
                {
                    if (PasswordHandler.validEmail(emailInput.Text))
                    {
                        if (PasswordHandler.validName(nameInput.Text))
                        {
                            Program.currentAccount.setUserName(usernameInput.Text);
                            Program.currentAccount.setName(nameInput.Text);
                            Program.currentAccount.setEmail(emailInput.Text);

                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
