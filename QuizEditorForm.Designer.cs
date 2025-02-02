namespace defaultwinform
{
    partial class QuizEditorForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizEditorForm));
            quizTitle = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            questionLayoutPane = new System.Windows.Forms.FlowLayoutPanel();
            addQuestionPanel = new System.Windows.Forms.Panel();
            addQuestionIcon = new System.Windows.Forms.PictureBox();
            settingsLabel = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            quizTopicField = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            radioButton5 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            randomizeField = new System.Windows.Forms.RadioButton();
            imageURLField = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            quizTitleField = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            panel3 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            questionLayoutPane.SuspendLayout();
            addQuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addQuestionIcon).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // quizTitle
            // 
            quizTitle.AutoSize = true;
            quizTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            quizTitle.Location = new System.Drawing.Point(31, 29);
            quizTitle.Name = "quizTitle";
            quizTitle.Size = new System.Drawing.Size(127, 32);
            quizTitle.TabIndex = 0;
            quizTitle.Text = "Quiz Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(36, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 23);
            label1.TabIndex = 1;
            label1.Text = "Questions:";
            // 
            // questionLayoutPane
            // 
            questionLayoutPane.AutoScroll = true;
            questionLayoutPane.Controls.Add(addQuestionPanel);
            questionLayoutPane.Location = new System.Drawing.Point(40, 109);
            questionLayoutPane.Name = "questionLayoutPane";
            questionLayoutPane.Size = new System.Drawing.Size(790, 211);
            questionLayoutPane.TabIndex = 2;
            // 
            // addQuestionPanel
            // 
            addQuestionPanel.Controls.Add(addQuestionIcon);
            addQuestionPanel.Location = new System.Drawing.Point(3, 3);
            addQuestionPanel.Name = "addQuestionPanel";
            addQuestionPanel.Size = new System.Drawing.Size(40, 81);
            addQuestionPanel.TabIndex = 0;
            addQuestionPanel.Click += addQuestionPanel_Click;
            // 
            // addQuestionIcon
            // 
            addQuestionIcon.Image = (System.Drawing.Image)resources.GetObject("addQuestionIcon.Image");
            addQuestionIcon.Location = new System.Drawing.Point(0, 26);
            addQuestionIcon.Name = "addQuestionIcon";
            addQuestionIcon.Size = new System.Drawing.Size(37, 37);
            addQuestionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            addQuestionIcon.TabIndex = 7;
            addQuestionIcon.TabStop = false;
            addQuestionIcon.Click += addQuestionIcon_Click;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            settingsLabel.Location = new System.Drawing.Point(37, 341);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new System.Drawing.Size(86, 23);
            settingsLabel.TabIndex = 3;
            settingsLabel.Text = "Settings:";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            panel1.Controls.Add(quizTopicField);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(randomizeField);
            panel1.Controls.Add(imageURLField);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(quizTitleField);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(40, 376);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(773, 244);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // quizTopicField
            // 
            quizTopicField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            quizTopicField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            quizTopicField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            quizTopicField.Location = new System.Drawing.Point(135, 93);
            quizTopicField.Name = "quizTopicField";
            quizTopicField.Size = new System.Drawing.Size(565, 24);
            quizTopicField.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(64, 92);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 22);
            label5.TabIndex = 14;
            label5.Text = "Topic:";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            radioButton5.Location = new System.Drawing.Point(519, 177);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new System.Drawing.Size(168, 26);
            radioButton5.TabIndex = 13;
            radioButton5.TabStop = true;
            radioButton5.Text = "Show If Correct";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            radioButton3.Location = new System.Drawing.Point(318, 177);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(155, 26);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Allow Retakes";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            radioButton4.Location = new System.Drawing.Point(62, 177);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(191, 26);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "Allow Star Earning";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            radioButton2.Location = new System.Drawing.Point(519, 135);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(176, 26);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Allow Power Ups";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            radioButton1.Location = new System.Drawing.Point(319, 135);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(146, 26);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Auto Grader";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // randomizeField
            // 
            randomizeField.AutoSize = true;
            randomizeField.Checked = true;
            randomizeField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            randomizeField.Location = new System.Drawing.Point(63, 135);
            randomizeField.Name = "randomizeField";
            randomizeField.Size = new System.Drawing.Size(224, 26);
            randomizeField.TabIndex = 8;
            randomizeField.TabStop = true;
            randomizeField.Text = "Randomize Questions";
            randomizeField.UseVisualStyleBackColor = true;
            // 
            // imageURLField
            // 
            imageURLField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            imageURLField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            imageURLField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            imageURLField.Location = new System.Drawing.Point(135, 57);
            imageURLField.Name = "imageURLField";
            imageURLField.Size = new System.Drawing.Size(565, 24);
            imageURLField.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(16, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 22);
            label3.TabIndex = 7;
            label3.Text = "Image URL:";
            // 
            // quizTitleField
            // 
            quizTitleField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            quizTitleField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            quizTitleField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            quizTitleField.Location = new System.Drawing.Point(135, 19);
            quizTitleField.Name = "quizTitleField";
            quizTitleField.Size = new System.Drawing.Size(565, 24);
            quizTitleField.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(36, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 22);
            label2.TabIndex = 5;
            label2.Text = "Quiz Title:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(0, 191, 99);
            panel3.Controls.Add(label6);
            panel3.Location = new System.Drawing.Point(327, 638);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(218, 58);
            panel3.TabIndex = 5;
            panel3.Click += panel3_Click;
            panel3.Paint += panel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(38, 17);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(144, 23);
            label6.TabIndex = 8;
            label6.Text = "Save Changes";
            label6.Click += label6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(67, 123, 67);
            panel4.Location = new System.Drawing.Point(327, 638);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(218, 66);
            panel4.TabIndex = 9;
            panel4.Click += panel4_Click;
            // 
            // QuizEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(866, 728);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(settingsLabel);
            Controls.Add(questionLayoutPane);
            Controls.Add(label1);
            Controls.Add(quizTitle);
            Name = "QuizEditorForm";
            Text = "QuizEditorForm";
            Click += QuizEditorForm_Click;
            questionLayoutPane.ResumeLayout(false);
            addQuestionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addQuestionIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label quizTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel questionLayoutPane;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quizTitleField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imageURLField;
        private System.Windows.Forms.Panel addQuestionPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox addQuestionIcon;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton randomizeField;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox quizTopicField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
    }
}