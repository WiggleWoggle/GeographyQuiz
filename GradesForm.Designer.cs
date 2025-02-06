namespace defaultwinform
{
    partial class GradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesForm));
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
            todoLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            topicLabel = new System.Windows.Forms.Label();
            incorrectScoreLabel = new System.Windows.Forms.Label();
            correctCountLabel = new System.Windows.Forms.Label();
            correctScoreLabel = new System.Windows.Forms.Label();
            averageScoreLabel = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            studentNameDisplay = new System.Windows.Forms.Label();
            profilePicture = new System.Windows.Forms.PictureBox();
            quizFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradesButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shopButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leaderboardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.TabIndex = 4;
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
            leaderboardButton.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            leaderboardButton.Image = (System.Drawing.Image)resources.GetObject("leaderboardButton.Image");
            leaderboardButton.Location = new System.Drawing.Point(17, 147);
            leaderboardButton.Name = "leaderboardButton";
            leaderboardButton.Size = new System.Drawing.Size(80, 80);
            leaderboardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            leaderboardButton.TabIndex = 4;
            leaderboardButton.TabStop = false;
            leaderboardButton.Click += leaderboardButton_Click;
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
            homeButton.MouseCaptureChanged += homeButton_MouseCaptureChanged;
            // 
            // todoLabel
            // 
            todoLabel.AutoSize = true;
            todoLabel.BackColor = System.Drawing.Color.Transparent;
            todoLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            todoLabel.Location = new System.Drawing.Point(164, 77);
            todoLabel.Name = "todoLabel";
            todoLabel.Size = new System.Drawing.Size(94, 23);
            todoLabel.TabIndex = 14;
            todoLabel.Text = "Statistics:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(164, 246);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(196, 23);
            label6.TabIndex = 15;
            label6.Text = "Completed Quizzes:";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            panel2.Controls.Add(topicLabel);
            panel2.Controls.Add(incorrectScoreLabel);
            panel2.Controls.Add(correctCountLabel);
            panel2.Controls.Add(correctScoreLabel);
            panel2.Controls.Add(averageScoreLabel);
            panel2.Location = new System.Drawing.Point(164, 103);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(873, 100);
            panel2.TabIndex = 16;
            // 
            // topicLabel
            // 
            topicLabel.AutoSize = true;
            topicLabel.BackColor = System.Drawing.Color.Transparent;
            topicLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            topicLabel.Location = new System.Drawing.Point(331, 55);
            topicLabel.Name = "topicLabel";
            topicLabel.Size = new System.Drawing.Size(249, 22);
            topicLabel.TabIndex = 25;
            topicLabel.Text = "Topic of Concern: xxxxxxxx";
            // 
            // incorrectScoreLabel
            // 
            incorrectScoreLabel.AutoSize = true;
            incorrectScoreLabel.BackColor = System.Drawing.Color.Transparent;
            incorrectScoreLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            incorrectScoreLabel.Location = new System.Drawing.Point(627, 19);
            incorrectScoreLabel.Name = "incorrectScoreLabel";
            incorrectScoreLabel.Size = new System.Drawing.Size(216, 22);
            incorrectScoreLabel.TabIndex = 24;
            incorrectScoreLabel.Text = "Incorrect Questions: xx";
            // 
            // correctCountLabel
            // 
            correctCountLabel.AutoSize = true;
            correctCountLabel.BackColor = System.Drawing.Color.Transparent;
            correctCountLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            correctCountLabel.Location = new System.Drawing.Point(331, 19);
            correctCountLabel.Name = "correctCountLabel";
            correctCountLabel.Size = new System.Drawing.Size(202, 22);
            correctCountLabel.TabIndex = 23;
            correctCountLabel.Text = "Correct Questions: xx";
            // 
            // correctScoreLabel
            // 
            correctScoreLabel.AutoSize = true;
            correctScoreLabel.BackColor = System.Drawing.Color.Transparent;
            correctScoreLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            correctScoreLabel.Location = new System.Drawing.Point(17, 55);
            correctScoreLabel.Name = "correctScoreLabel";
            correctScoreLabel.Size = new System.Drawing.Size(188, 22);
            correctScoreLabel.TabIndex = 22;
            correctScoreLabel.Text = "Correct Score: xxx%";
            // 
            // averageScoreLabel
            // 
            averageScoreLabel.AutoSize = true;
            averageScoreLabel.BackColor = System.Drawing.Color.Transparent;
            averageScoreLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            averageScoreLabel.Location = new System.Drawing.Point(17, 19);
            averageScoreLabel.Name = "averageScoreLabel";
            averageScoreLabel.Size = new System.Drawing.Size(202, 22);
            averageScoreLabel.TabIndex = 21;
            averageScoreLabel.Text = "Average Score: xxx%";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(studentNameDisplay);
            panel3.Location = new System.Drawing.Point(623, 34);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(391, 29);
            panel3.TabIndex = 20;
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
            profilePicture.TabIndex = 19;
            profilePicture.TabStop = false;
            // 
            // quizFlowLayout
            // 
            quizFlowLayout.Location = new System.Drawing.Point(148, 272);
            quizFlowLayout.Name = "quizFlowLayout";
            quizFlowLayout.Size = new System.Drawing.Size(908, 410);
            quizFlowLayout.TabIndex = 21;
            // 
            // GradesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1095, 680);
            Controls.Add(quizFlowLayout);
            Controls.Add(panel3);
            Controls.Add(profilePicture);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(todoLabel);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "GradesForm";
            Text = "GeoMind";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teachersButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradesButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)shopButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)leaderboardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label studentNameDisplay;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label correctScoreLabel;
        private System.Windows.Forms.Label averageScoreLabel;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.Label incorrectScoreLabel;
        private System.Windows.Forms.Label correctCountLabel;
        private System.Windows.Forms.FlowLayoutPanel quizFlowLayout;
    }
}