namespace defaultwinform
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new System.Windows.Forms.Panel();
            passwordField = new System.Windows.Forms.TextBox();
            usernameField = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            loginButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            loginLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            incorrectLabel = new System.Windows.Forms.Label();
            errorLabel = new System.Windows.Forms.Label();
            loadingSpinner = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadingSpinner).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(usernameField);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(125, 247);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(430, 285);
            panel1.TabIndex = 1;
            // 
            // passwordField
            // 
            passwordField.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            passwordField.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            passwordField.Location = new System.Drawing.Point(164, 127);
            passwordField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordField.Name = "passwordField";
            passwordField.Size = new System.Drawing.Size(212, 24);
            passwordField.TabIndex = 4;
            // 
            // usernameField
            // 
            usernameField.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            usernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            usernameField.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            usernameField.Location = new System.Drawing.Point(164, 72);
            usernameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            usernameField.Name = "usernameField";
            usernameField.Size = new System.Drawing.Size(212, 24);
            usernameField.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline);
            label4.ForeColor = System.Drawing.Color.FromArgb(134, 132, 217);
            label4.Location = new System.Drawing.Point(261, 241);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 17);
            label4.TabIndex = 7;
            label4.Text = "Sign Up";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            label3.Location = new System.Drawing.Point(110, 241);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 17);
            label3.TabIndex = 6;
            label3.Text = "Don't have an account?";
            // 
            // loginButton
            // 
            loginButton.BackColor = System.Drawing.Color.FromArgb(134, 132, 217);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            loginButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            loginButton.Location = new System.Drawing.Point(43, 187);
            loginButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(341, 39);
            loginButton.TabIndex = 5;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(55, 126);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 23);
            label2.TabIndex = 3;
            label2.Text = "Password: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(49, 70);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 23);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            panel2.Controls.Add(loginLabel);
            panel2.Location = new System.Drawing.Point(125, 247);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(430, 43);
            panel2.TabIndex = 2;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            loginLabel.Location = new System.Drawing.Point(181, 10);
            loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(64, 23);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Log In";
            loginLabel.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(317, 117);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 38);
            label5.TabIndex = 2;
            label5.Text = "GeoMind";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            label6.Location = new System.Drawing.Point(324, 160);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(219, 19);
            label6.TabIndex = 3;
            label6.Text = "Learn geography the fun way.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(139, 67);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(175, 173);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // incorrectLabel
            // 
            incorrectLabel.AutoSize = true;
            incorrectLabel.Enabled = false;
            incorrectLabel.Font = new System.Drawing.Font("Century Gothic", 9F);
            incorrectLabel.ForeColor = System.Drawing.Color.IndianRed;
            incorrectLabel.Location = new System.Drawing.Point(245, 535);
            incorrectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            incorrectLabel.Name = "incorrectLabel";
            incorrectLabel.Size = new System.Drawing.Size(0, 17);
            incorrectLabel.TabIndex = 8;
            incorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            incorrectLabel.Click += incorrectLabel_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new System.Drawing.Font("Century Gothic", 9F);
            errorLabel.ForeColor = System.Drawing.Color.Red;
            errorLabel.Location = new System.Drawing.Point(121, 535);
            errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new System.Drawing.Size(71, 17);
            errorLabel.TabIndex = 12;
            errorLabel.Text = "VisibleText";
            // 
            // loadingSpinner
            // 
            loadingSpinner.Image = (System.Drawing.Image)resources.GetObject("loadingSpinner.Image");
            loadingSpinner.Location = new System.Drawing.Point(109, 329);
            loadingSpinner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            loadingSpinner.Name = "loadingSpinner";
            loadingSpinner.Size = new System.Drawing.Size(460, 111);
            loadingSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            loadingSpinner.TabIndex = 13;
            loadingSpinner.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(674, 753);
            Controls.Add(errorLabel);
            Controls.Add(incorrectLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(loadingSpinner);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "GeoMind";
            FormClosed += LoginForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadingSpinner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox loadingSpinner;
    }
}