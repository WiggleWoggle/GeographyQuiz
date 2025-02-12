using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultwinform
{
    internal class QuizPanel
    {

        private Quiz associatedQuiz;

        private Panel header;
        private Panel panel;
        private Label title;
        private Label questions;
        private Label topic;
        private Label attemptedStatus;
        private PictureBox image;
        private PictureBox addIcon;


        public QuizPanel()
        {

        }

        public QuizPanel(Quiz associatedQuiz, Panel panel, Label title, Label questions, Label topic, Label attemptedStatus, PictureBox image)
        {
            this.image = image;
            this.title = title;
            this.questions = questions;
            this.panel = panel;
            this.topic = topic;
            this.attemptedStatus = attemptedStatus;
            this.associatedQuiz = associatedQuiz;
        }

        public QuizPanel(Quiz associatedQuiz, Panel panel, PictureBox addIcon)
        {
            this.panel = panel;
            this.associatedQuiz = associatedQuiz;
            this.addIcon = addIcon;
        }

        public Label getTitle()
        {
            return title;
        }

        public Label getTopic()
        {
            return topic;
        }

        public Panel getPanel()
        {
            return panel;
        }

        public Panel getHeader()
        {
            return header;
        }

        public PictureBox getAddIcon()
        {
            return addIcon;
        }

        public Quiz getQuiz()
        {
            return this.associatedQuiz;
        }
    }
}
