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
    public partial class QuestionEditingPrompt : Form
    {

        private QuizEditorForm quizEditorForm;

        public QuestionEditingPrompt(QuizEditorForm form)
        {
            InitializeComponent();
            this.CenterToScreen();

            quizEditorForm = form;

            buildEditingSettings();
        }

        private void QuestionEditingPrompt_Click(object sender, EventArgs e)
        {

        }

        private void buildEditingSettings()
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            returnQuestion();
        }

        private void returnQuestion()
        {

        }

        private void switchType()
        {
            if (multipleChoiceOption.Checked)
            {
                mcPanel.Visible = true;
                tfPanel.Visible = false;
            }
            else if (multipleAnswerChoice.Checked)
            {
                mcPanel.Visible = true;
                tfPanel.Visible = false;
            }
            else if (trueorFalseOption.Checked)
            {
                mcPanel.Visible = false;
                tfPanel.Visible = true;
            }
            else
            {

            }
        }

        private void multipleChoiceOption_CheckedChanged(object sender, EventArgs e)
        {
            switchType();
        }

        private void multipleAnswerChoice_CheckedChanged(object sender, EventArgs e)
        {
            switchType();
        }

        private void trueorFalseOption_CheckedChanged(object sender, EventArgs e)
        {
            switchType();
        }

        private void shortResponseOption_CheckedChanged(object sender, EventArgs e)
        {
            switchType();
        }
    }
}
