namespace defaultwinform
{
    partial class QuestionEditingPrompt
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
            multipleChoiceOption = new System.Windows.Forms.RadioButton();
            multipleAnswerChoice = new System.Windows.Forms.RadioButton();
            trueorFalseOption = new System.Windows.Forms.RadioButton();
            shortResponseOption = new System.Windows.Forms.RadioButton();
            panel3 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            starField = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            imageURLField = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            questionField = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            mcPanel = new System.Windows.Forms.Panel();
            tfPanel = new System.Windows.Forms.Panel();
            label14 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            answerField = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            choiceFourField = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            choiceThreeField = new System.Windows.Forms.TextBox();
            choiceTwoField = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            choiceOneField = new System.Windows.Forms.TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            mcPanel.SuspendLayout();
            tfPanel.SuspendLayout();
            SuspendLayout();
            // 
            // multipleChoiceOption
            // 
            multipleChoiceOption.AutoSize = true;
            multipleChoiceOption.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            multipleChoiceOption.Location = new System.Drawing.Point(19, 13);
            multipleChoiceOption.Name = "multipleChoiceOption";
            multipleChoiceOption.Size = new System.Drawing.Size(174, 26);
            multipleChoiceOption.TabIndex = 0;
            multipleChoiceOption.TabStop = true;
            multipleChoiceOption.Text = "Multiple Choice ";
            multipleChoiceOption.UseVisualStyleBackColor = true;
            multipleChoiceOption.CheckedChanged += multipleChoiceOption_CheckedChanged;
            // 
            // multipleAnswerChoice
            // 
            multipleAnswerChoice.AutoSize = true;
            multipleAnswerChoice.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            multipleAnswerChoice.Location = new System.Drawing.Point(19, 59);
            multipleAnswerChoice.Name = "multipleAnswerChoice";
            multipleAnswerChoice.Size = new System.Drawing.Size(171, 26);
            multipleAnswerChoice.TabIndex = 1;
            multipleAnswerChoice.TabStop = true;
            multipleAnswerChoice.Text = "Multiple Answer";
            multipleAnswerChoice.UseVisualStyleBackColor = true;
            multipleAnswerChoice.CheckedChanged += multipleAnswerChoice_CheckedChanged;
            // 
            // trueorFalseOption
            // 
            trueorFalseOption.AutoSize = true;
            trueorFalseOption.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            trueorFalseOption.Location = new System.Drawing.Point(19, 104);
            trueorFalseOption.Name = "trueorFalseOption";
            trueorFalseOption.Size = new System.Drawing.Size(138, 26);
            trueorFalseOption.TabIndex = 2;
            trueorFalseOption.TabStop = true;
            trueorFalseOption.Text = "True or False";
            trueorFalseOption.UseVisualStyleBackColor = true;
            trueorFalseOption.CheckedChanged += trueorFalseOption_CheckedChanged;
            // 
            // shortResponseOption
            // 
            shortResponseOption.AutoSize = true;
            shortResponseOption.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            shortResponseOption.Location = new System.Drawing.Point(19, 148);
            shortResponseOption.Name = "shortResponseOption";
            shortResponseOption.Size = new System.Drawing.Size(166, 26);
            shortResponseOption.TabIndex = 3;
            shortResponseOption.TabStop = true;
            shortResponseOption.Text = "Short Response";
            shortResponseOption.UseVisualStyleBackColor = true;
            shortResponseOption.CheckedChanged += shortResponseOption_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(0, 191, 99);
            panel3.Controls.Add(label6);
            panel3.Location = new System.Drawing.Point(404, 559);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(218, 58);
            panel3.TabIndex = 10;
            panel3.Click += panel3_Click;
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
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(67, 123, 67);
            panel4.Location = new System.Drawing.Point(404, 559);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(218, 66);
            panel4.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            panel1.Controls.Add(multipleChoiceOption);
            panel1.Controls.Add(multipleAnswerChoice);
            panel1.Controls.Add(trueorFalseOption);
            panel1.Controls.Add(shortResponseOption);
            panel1.Location = new System.Drawing.Point(31, 119);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(235, 194);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(24, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(242, 32);
            label1.TabIndex = 13;
            label1.Text = "Question Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(27, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 23);
            label2.TabIndex = 14;
            label2.Text = "Question Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(319, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(205, 23);
            label3.TabIndex = 15;
            label3.Text = "Question Information:";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            panel2.Controls.Add(starField);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(imageURLField);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(questionField);
            panel2.Location = new System.Drawing.Point(319, 119);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(715, 139);
            panel2.TabIndex = 13;
            // 
            // starField
            // 
            starField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            starField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            starField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            starField.Location = new System.Drawing.Point(129, 97);
            starField.Name = "starField";
            starField.Size = new System.Drawing.Size(565, 24);
            starField.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(16, 97);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(110, 22);
            label13.TabIndex = 20;
            label13.Text = "Star Value:";
            // 
            // imageURLField
            // 
            imageURLField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            imageURLField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            imageURLField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            imageURLField.Location = new System.Drawing.Point(130, 59);
            imageURLField.Name = "imageURLField";
            imageURLField.Size = new System.Drawing.Size(565, 24);
            imageURLField.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(31, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(97, 22);
            label5.TabIndex = 16;
            label5.Text = "Question:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(14, 59);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 22);
            label4.TabIndex = 18;
            label4.Text = "Image URL:";
            // 
            // questionField
            // 
            questionField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            questionField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            questionField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            questionField.Location = new System.Drawing.Point(130, 21);
            questionField.Name = "questionField";
            questionField.Size = new System.Drawing.Size(565, 24);
            questionField.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(319, 290);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(85, 23);
            label7.TabIndex = 16;
            label7.Text = "Choices";
            // 
            // mcPanel
            // 
            mcPanel.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            mcPanel.Controls.Add(answerField);
            mcPanel.Controls.Add(label12);
            mcPanel.Controls.Add(choiceFourField);
            mcPanel.Controls.Add(label11);
            mcPanel.Controls.Add(choiceThreeField);
            mcPanel.Controls.Add(choiceTwoField);
            mcPanel.Controls.Add(label10);
            mcPanel.Controls.Add(label9);
            mcPanel.Controls.Add(label8);
            mcPanel.Controls.Add(choiceOneField);
            mcPanel.Location = new System.Drawing.Point(319, 316);
            mcPanel.Name = "mcPanel";
            mcPanel.Size = new System.Drawing.Size(715, 222);
            mcPanel.TabIndex = 20;
            // 
            // tfPanel
            // 
            tfPanel.BackColor = System.Drawing.Color.FromArgb(228, 234, 239);
            tfPanel.Controls.Add(label14);
            tfPanel.Controls.Add(textBox5);
            tfPanel.Location = new System.Drawing.Point(319, 318);
            tfPanel.Name = "tfPanel";
            tfPanel.Size = new System.Drawing.Size(716, 58);
            tfPanel.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(41, 21);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(83, 22);
            label14.TabIndex = 28;
            label14.Text = "Answer:";
            // 
            // textBox5
            // 
            textBox5.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            textBox5.Location = new System.Drawing.Point(130, 19);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(565, 24);
            textBox5.TabIndex = 21;
            // 
            // answerField
            // 
            answerField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            answerField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            answerField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            answerField.Location = new System.Drawing.Point(130, 178);
            answerField.Name = "answerField";
            answerField.Size = new System.Drawing.Size(565, 24);
            answerField.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(24, 180);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(104, 22);
            label12.TabIndex = 28;
            label12.Text = "Answer(s):";
            // 
            // choiceFourField
            // 
            choiceFourField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            choiceFourField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            choiceFourField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            choiceFourField.Location = new System.Drawing.Point(130, 139);
            choiceFourField.Name = "choiceFourField";
            choiceFourField.Size = new System.Drawing.Size(565, 24);
            choiceFourField.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(30, 141);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(97, 22);
            label11.TabIndex = 26;
            label11.Text = "Choice 4:";
            // 
            // choiceThreeField
            // 
            choiceThreeField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            choiceThreeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            choiceThreeField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            choiceThreeField.Location = new System.Drawing.Point(130, 100);
            choiceThreeField.Name = "choiceThreeField";
            choiceThreeField.Size = new System.Drawing.Size(565, 24);
            choiceThreeField.TabIndex = 25;
            // 
            // choiceTwoField
            // 
            choiceTwoField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            choiceTwoField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            choiceTwoField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            choiceTwoField.Location = new System.Drawing.Point(130, 60);
            choiceTwoField.Name = "choiceTwoField";
            choiceTwoField.Size = new System.Drawing.Size(565, 24);
            choiceTwoField.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(31, 102);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(97, 22);
            label10.TabIndex = 23;
            label10.Text = "Choice 3:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(31, 61);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(97, 22);
            label9.TabIndex = 22;
            label9.Text = "Choice 2:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(31, 19);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(97, 22);
            label8.TabIndex = 20;
            label8.Text = "Choice 1:";
            // 
            // choiceOneField
            // 
            choiceOneField.BackColor = System.Drawing.Color.FromArgb(209, 216, 221);
            choiceOneField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            choiceOneField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            choiceOneField.Location = new System.Drawing.Point(130, 19);
            choiceOneField.Name = "choiceOneField";
            choiceOneField.Size = new System.Drawing.Size(565, 24);
            choiceOneField.TabIndex = 21;
            // 
            // QuestionEditingPrompt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1062, 641);
            Controls.Add(tfPanel);
            Controls.Add(mcPanel);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "QuestionEditingPrompt";
            Text = "QuestionEditingPrompt";
            Click += QuestionEditingPrompt_Click;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mcPanel.ResumeLayout(false);
            mcPanel.PerformLayout();
            tfPanel.ResumeLayout(false);
            tfPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton multipleChoiceOption;
        private System.Windows.Forms.RadioButton multipleAnswerChoice;
        private System.Windows.Forms.RadioButton trueorFalseOption;
        private System.Windows.Forms.RadioButton shortResponseOption;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox imageURLField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox questionField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel mcPanel;
        private System.Windows.Forms.TextBox choiceThreeField;
        private System.Windows.Forms.TextBox choiceTwoField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox choiceOneField;
        private System.Windows.Forms.TextBox choiceFourField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox answerField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox starField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel tfPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
    }
}