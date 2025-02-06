namespace defaultwinform
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            loginLabel = new System.Windows.Forms.Label();
            nameField = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            emailField = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            passwordField = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            login = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            signupButton = new System.Windows.Forms.Button();
            usernameField = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            incorrectLabel = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            loginLabel.Location = new System.Drawing.Point(122, 6);
            loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(154, 23);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Student Sign Up";
            // 
            // nameField
            // 
            nameField.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            nameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            nameField.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nameField.Location = new System.Drawing.Point(172, 72);
            nameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nameField.Name = "nameField";
            nameField.Size = new System.Drawing.Size(212, 24);
            nameField.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            panel2.Controls.Add(loginLabel);
            panel2.Location = new System.Drawing.Point(127, 247);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(430, 43);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            panel1.Controls.Add(emailField);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(signupButton);
            panel1.Controls.Add(usernameField);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nameField);
            panel1.Location = new System.Drawing.Point(127, 247);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(430, 373);
            panel1.TabIndex = 5;
            // 
            // emailField
            // 
            emailField.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            emailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            emailField.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            emailField.Location = new System.Drawing.Point(172, 179);
            emailField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            emailField.Name = "emailField";
            emailField.Size = new System.Drawing.Size(212, 24);
            emailField.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(41, 178);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 23);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // passwordField
            // 
            passwordField.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            passwordField.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            passwordField.Location = new System.Drawing.Point(172, 228);
            passwordField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordField.Name = "passwordField";
            passwordField.Size = new System.Drawing.Size(212, 24);
            passwordField.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(38, 230);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(106, 23);
            label7.TabIndex = 8;
            label7.Text = "Password: ";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline);
            login.ForeColor = System.Drawing.Color.FromArgb(134, 132, 217);
            login.Location = new System.Drawing.Point(269, 332);
            login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            login.Name = "login";
            login.Size = new System.Drawing.Size(43, 17);
            login.TabIndex = 7;
            login.Text = "Log In";
            login.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            label3.Location = new System.Drawing.Point(102, 332);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(167, 17);
            label3.TabIndex = 6;
            label3.Text = "Already have an account?";
            // 
            // signupButton
            // 
            signupButton.BackColor = System.Drawing.Color.FromArgb(134, 132, 217);
            signupButton.FlatAppearance.BorderSize = 0;
            signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            signupButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            signupButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            signupButton.Location = new System.Drawing.Point(43, 278);
            signupButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            signupButton.Name = "signupButton";
            signupButton.Size = new System.Drawing.Size(341, 39);
            signupButton.TabIndex = 5;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // usernameField
            // 
            usernameField.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            usernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            usernameField.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            usernameField.Location = new System.Drawing.Point(172, 127);
            usernameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            usernameField.Name = "usernameField";
            usernameField.Size = new System.Drawing.Size(212, 24);
            usernameField.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(38, 126);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 23);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(38, 70);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 23);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            label6.Location = new System.Drawing.Point(324, 160);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(219, 19);
            label6.TabIndex = 8;
            label6.Text = "Learn geography the fun way.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(317, 117);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 38);
            label5.TabIndex = 6;
            label5.Text = "GeoMind";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(139, 67);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(175, 173);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // incorrectLabel
            // 
            incorrectLabel.AutoSize = true;
            incorrectLabel.Font = new System.Drawing.Font("Century Gothic", 9F);
            incorrectLabel.ForeColor = System.Drawing.Color.Red;
            incorrectLabel.Location = new System.Drawing.Point(124, 623);
            incorrectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            incorrectLabel.Name = "incorrectLabel";
            incorrectLabel.Size = new System.Drawing.Size(71, 17);
            incorrectLabel.TabIndex = 13;
            incorrectLabel.Text = "VisibleText";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(674, 753);
            Controls.Add(incorrectLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SignupForm";
            Text = "GeoMind";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label incorrectLabel;
    }
}