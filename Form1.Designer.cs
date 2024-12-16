namespace defaultwinform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.teachersButton = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gradesButton = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shopButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leaderboardButton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.todoFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.studentNameDisplay = new System.Windows.Forms.Label();
            this.todoLabel = new System.Windows.Forms.Label();
            this.profileUnderlay = new defaultwinform.RoundedPanel();
            this.profileOverlay = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.completedFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.profileUnderlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileOverlay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(189)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.teachersButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gradesButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.shopButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.leaderboardButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 682);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teachers";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // teachersButton
            // 
            this.teachersButton.Image = ((System.Drawing.Image)(resources.GetObject("teachersButton.Image")));
            this.teachersButton.Location = new System.Drawing.Point(17, 550);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(80, 80);
            this.teachersButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teachersButton.TabIndex = 7;
            this.teachersButton.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grades";
            // 
            // gradesButton
            // 
            this.gradesButton.Image = ((System.Drawing.Image)(resources.GetObject("gradesButton.Image")));
            this.gradesButton.Location = new System.Drawing.Point(17, 418);
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.Size = new System.Drawing.Size(80, 80);
            this.gradesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gradesButton.TabIndex = 6;
            this.gradesButton.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Shop";
            // 
            // shopButton
            // 
            this.shopButton.Image = ((System.Drawing.Image)(resources.GetObject("shopButton.Image")));
            this.shopButton.Location = new System.Drawing.Point(17, 288);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(80, 80);
            this.shopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shopButton.TabIndex = 5;
            this.shopButton.TabStop = false;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ranking";
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.Image = ((System.Drawing.Image)(resources.GetObject("leaderboardButton.Image")));
            this.leaderboardButton.Location = new System.Drawing.Point(17, 147);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(80, 80);
            this.leaderboardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leaderboardButton.TabIndex = 4;
            this.leaderboardButton.TabStop = false;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            this.leaderboardButton.MouseHover += new System.EventHandler(this.leaderboardButton_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Home";
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(17, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 80);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeButton.TabIndex = 3;
            this.homeButton.TabStop = false;
            this.homeButton.MouseHover += new System.EventHandler(this.homeButton_MouseHover);
            // 
            // todoFlowLayout
            // 
            this.todoFlowLayout.AutoScroll = true;
            this.todoFlowLayout.Location = new System.Drawing.Point(143, 111);
            this.todoFlowLayout.Name = "todoFlowLayout";
            this.todoFlowLayout.Size = new System.Drawing.Size(940, 220);
            this.todoFlowLayout.TabIndex = 3;
            // 
            // studentNameDisplay
            // 
            this.studentNameDisplay.AutoSize = true;
            this.studentNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.studentNameDisplay.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.studentNameDisplay.Location = new System.Drawing.Point(871, 29);
            this.studentNameDisplay.Name = "studentNameDisplay";
            this.studentNameDisplay.Size = new System.Drawing.Size(90, 23);
            this.studentNameDisplay.TabIndex = 12;
            this.studentNameDisplay.Text = "Student1";
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.BackColor = System.Drawing.Color.Transparent;
            this.todoLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.todoLabel.Location = new System.Drawing.Point(141, 85);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(65, 23);
            this.todoLabel.TabIndex = 13;
            this.todoLabel.Text = "To Do:";
            // 
            // profileUnderlay
            // 
            this.profileUnderlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.profileUnderlay.BorderRadius = 60;
            this.profileUnderlay.Controls.Add(this.profileOverlay);
            this.profileUnderlay.ForeColor = System.Drawing.Color.Black;
            this.profileUnderlay.Location = new System.Drawing.Point(967, 12);
            this.profileUnderlay.Name = "profileUnderlay";
            this.profileUnderlay.Size = new System.Drawing.Size(60, 60);
            this.profileUnderlay.TabIndex = 1;
            // 
            // profileOverlay
            // 
            this.profileOverlay.BackColor = System.Drawing.Color.Transparent;
            this.profileOverlay.Image = global::defaultwinform.Properties.Resources.profileOverlay;
            this.profileOverlay.Location = new System.Drawing.Point(1, 4);
            this.profileOverlay.Name = "profileOverlay";
            this.profileOverlay.Size = new System.Drawing.Size(60, 60);
            this.profileOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileOverlay.TabIndex = 0;
            this.profileOverlay.TabStop = false;
            this.profileOverlay.Click += new System.EventHandler(this.profileOverlay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(139, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Completed:";
            // 
            // completedFlowLayout
            // 
            this.completedFlowLayout.AutoScroll = true;
            this.completedFlowLayout.Location = new System.Drawing.Point(143, 373);
            this.completedFlowLayout.Name = "completedFlowLayout";
            this.completedFlowLayout.Size = new System.Drawing.Size(940, 220);
            this.completedFlowLayout.TabIndex = 4;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 680);
            this.Controls.Add(this.completedFlowLayout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.todoLabel);
            this.Controls.Add(this.studentNameDisplay);
            this.Controls.Add(this.todoFlowLayout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profileUnderlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " GeoMind";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.profileUnderlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileOverlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox profileOverlay;
        private RoundedPanel profileUnderlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox teachersButton;
        private System.Windows.Forms.PictureBox gradesButton;
        private System.Windows.Forms.PictureBox shopButton;
        private System.Windows.Forms.PictureBox leaderboardButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel todoFlowLayout;
        private System.Windows.Forms.Label studentNameDisplay;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel completedFlowLayout;
    }
}

