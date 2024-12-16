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
    public partial class QuizTakingForm : Form
    {

        public QuizTakingForm()
        {
            InitializeComponent();
            this.Size = new Size(1111, 758);
            this.MinimumSize = new Size(1111, 758);
            this.MaximumSize = new Size(1111, 758);
            this.CenterToScreen();

            disableAllButtons();
        }

        private void buildToQuestion()
        {
            
        }

        private void disableAllButtons()
        {
            redButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            blueButton.Visible = false;

            truePanel.Visible = false;
            falsePanel.Visible = false;
        }

        private void enableMultipleChoiceButtons()
        {
            redButton.Visible = true;
            yellowButton.Visible = true;
            greenButton.Visible = true;
            blueButton.Visible = true;

            truePanel.Visible = false;
            falsePanel.Visible = false;
        }

        private void enableTrueOrFalseButtons()
        {
            redButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            blueButton.Visible = false;

            truePanel.Visible = true;
            falsePanel.Visible = true;
        }
    }
}
