namespace defaultwinform
{
    partial class LeaderboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardForm));
            panel1 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            teachersButton = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            gradesButton = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            shopButton = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            leaderboardButton = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            homeButton = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            studentNameDisplay = new System.Windows.Forms.Label();
            profilePicture = new System.Windows.Forms.PictureBox();
            userFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            todoLabel = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradesButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shopButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leaderboardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeButton).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(182, 189, 202);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(teachersButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(gradesButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(shopButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(leaderboardButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(homeButton);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(121, 682);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(20, 633);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 19);
            label5.TabIndex = 11;
            label5.Text = "Teachers";
            // 
            // teachersButton
            // 
            teachersButton.Image = (System.Drawing.Image)resources.GetObject("teachersButton.Image");
            teachersButton.Location = new System.Drawing.Point(17, 550);
            teachersButton.Name = "teachersButton";
            teachersButton.Size = new System.Drawing.Size(80, 80);
            teachersButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            teachersButton.TabIndex = 7;
            teachersButton.TabStop = false;
            teachersButton.Click += teachersButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(26, 504);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 19);
            label4.TabIndex = 10;
            label4.Text = "Grades";
            // 
            // gradesButton
            // 
            gradesButton.Image = (System.Drawing.Image)resources.GetObject("gradesButton.Image");
            gradesButton.Location = new System.Drawing.Point(17, 418);
            gradesButton.Name = "gradesButton";
            gradesButton.Size = new System.Drawing.Size(80, 80);
            gradesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            gradesButton.TabIndex = 6;
            gradesButton.TabStop = false;
            gradesButton.Click += gradesButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(34, 373);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 19);
            label3.TabIndex = 9;
            label3.Text = "Shop";
            // 
            // shopButton
            // 
            shopButton.Image = (System.Drawing.Image)resources.GetObject("shopButton.Image");
            shopButton.Location = new System.Drawing.Point(17, 288);
            shopButton.Name = "shopButton";
            shopButton.Size = new System.Drawing.Size(80, 80);
            shopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            shopButton.TabIndex = 5;
            shopButton.TabStop = false;
            shopButton.Click += shopButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(19, 233);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 19);
            label1.TabIndex = 8;
            label1.Text = "Ranking";
            // 
            // leaderboardButton
            // 
            leaderboardButton.Image = (System.Drawing.Image)resources.GetObject("leaderboardButton.Image");
            leaderboardButton.Location = new System.Drawing.Point(17, 147);
            leaderboardButton.Name = "leaderboardButton";
            leaderboardButton.Size = new System.Drawing.Size(80, 80);
            leaderboardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            leaderboardButton.TabIndex = 4;
            leaderboardButton.TabStop = false;
            leaderboardButton.Click += LeaderboardForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(28, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 19);
            label2.TabIndex = 3;
            label2.Text = "Home";
            // 
            // homeButton
            // 
            homeButton.Image = (System.Drawing.Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new System.Drawing.Point(17, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new System.Drawing.Size(80, 80);
            homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            homeButton.TabIndex = 3;
            homeButton.TabStop = false;
            homeButton.Click += homeButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(studentNameDisplay);
            panel2.Location = new System.Drawing.Point(623, 34);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(391, 29);
            panel2.TabIndex = 18;
            // 
            // studentNameDisplay
            // 
            studentNameDisplay.AutoSize = true;
            studentNameDisplay.BackColor = System.Drawing.Color.Transparent;
            studentNameDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            studentNameDisplay.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            studentNameDisplay.Location = new System.Drawing.Point(301, 0);
            studentNameDisplay.Name = "studentNameDisplay";
            studentNameDisplay.Size = new System.Drawing.Size(90, 23);
            studentNameDisplay.TabIndex = 12;
            studentNameDisplay.Text = "Student1";
            studentNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // profilePicture
            // 
            profilePicture.Image = Properties.Resources.defaultProfile;
            profilePicture.Location = new System.Drawing.Point(1013, 12);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new System.Drawing.Size(70, 70);
            profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 17;
            profilePicture.TabStop = false;
            // 
            // userFlowLayout
            // 
            userFlowLayout.AutoScroll = true;
            userFlowLayout.Location = new System.Drawing.Point(164, 120);
            userFlowLayout.Name = "userFlowLayout";
            userFlowLayout.Size = new System.Drawing.Size(931, 548);
            userFlowLayout.TabIndex = 19;
            userFlowLayout.Click += userFlowLayout_Click;
            // 
            // todoLabel
            // 
            todoLabel.AutoSize = true;
            todoLabel.BackColor = System.Drawing.Color.Transparent;
            todoLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            todoLabel.Location = new System.Drawing.Point(164, 77);
            todoLabel.Name = "todoLabel";
            todoLabel.Size = new System.Drawing.Size(131, 23);
            todoLabel.TabIndex = 20;
            todoLabel.Text = "Leaderboard";
            // 
            // LeaderboardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1095, 680);
            Controls.Add(todoLabel);
            Controls.Add(userFlowLayout);
            Controls.Add(panel2);
            Controls.Add(profilePicture);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "LeaderboardForm";
            Text = "GeoMind";
            Click += LeaderboardForm_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teachersButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradesButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)shopButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)leaderboardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox teachersButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox gradesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox shopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox leaderboardButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label studentNameDisplay;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.FlowLayoutPanel userFlowLayout;
        private System.Windows.Forms.Label todoLabel;
    }
}