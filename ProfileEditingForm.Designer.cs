namespace defaultwinform
{
    partial class ProfileEditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileEditingForm));
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.studentNameDisplay = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.usernameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.usernameDisplay.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.usernameDisplay.Location = new System.Drawing.Point(85, 21);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(90, 23);
            this.usernameDisplay.TabIndex = 13;
            this.usernameDisplay.Text = "Student1";
            // 
            // studentNameDisplay
            // 
            this.studentNameDisplay.AutoSize = true;
            this.studentNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.studentNameDisplay.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.studentNameDisplay.Location = new System.Drawing.Point(85, 49);
            this.studentNameDisplay.Name = "studentNameDisplay";
            this.studentNameDisplay.Size = new System.Drawing.Size(109, 19);
            this.studentNameDisplay.TabIndex = 15;
            this.studentNameDisplay.Text = "Student Name";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(132)))), ((int)(((byte)(217)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.editButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editButton.Location = new System.Drawing.Point(249, 26);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(47, 30);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password:";
            // 
            // emailField
            // 
            this.emailField.AutoSize = true;
            this.emailField.BackColor = System.Drawing.Color.Transparent;
            this.emailField.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.emailField.Location = new System.Drawing.Point(82, 100);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(50, 19);
            this.emailField.TabIndex = 19;
            this.emailField.Text = "Email:";
            this.emailField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordField
            // 
            this.passwordField.AutoSize = true;
            this.passwordField.BackColor = System.Drawing.Color.Transparent;
            this.passwordField.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.passwordField.Location = new System.Drawing.Point(117, 131);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(57, 19);
            this.passwordField.TabIndex = 20;
            this.passwordField.Text = "********";
            this.passwordField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(132)))), ((int)(((byte)(217)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(86, 173);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 36);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(202)))));
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.passwordInput.Location = new System.Drawing.Point(119, 130);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(148, 24);
            this.passwordInput.TabIndex = 22;
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(202)))));
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInput.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.emailInput.Location = new System.Drawing.Point(84, 97);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(148, 24);
            this.emailInput.TabIndex = 23;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(202)))));
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.nameInput.Location = new System.Drawing.Point(89, 49);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(148, 24);
            this.nameInput.TabIndex = 24;
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(202)))));
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.usernameInput.Location = new System.Drawing.Point(89, 19);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(148, 24);
            this.usernameInput.TabIndex = 25;
            // 
            // profileIcon
            // 
            this.profileIcon.Image = global::defaultwinform.Properties.Resources.defaultProfile;
            this.profileIcon.Location = new System.Drawing.Point(12, 12);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(70, 70);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileIcon.TabIndex = 14;
            this.profileIcon.TabStop = false;
            this.profileIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ProfileEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 234);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.studentNameDisplay);
            this.Controls.Add(this.profileIcon);
            this.Controls.Add(this.usernameDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileEditingForm";
            this.Text = "GeoMind";
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.Label studentNameDisplay;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emailField;
        private System.Windows.Forms.Label passwordField;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox usernameInput;
    }
}