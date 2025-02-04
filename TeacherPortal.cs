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
    public partial class TeacherPortal : Form
    {
        public TeacherPortal()
        {
            InitializeComponent();
            this.Size = new Size(1111, 719);
            this.MinimumSize = new Size(1111, 719);
            this.MaximumSize = new Size(1111, 719);
            this.CenterToScreen();
        }

        private void TeacherPortal_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void createQuizPanel_Click(object sender, EventArgs e)
        {
            QuizEditorForm form = new QuizEditorForm();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QuizEditorForm form = new QuizEditorForm();
            form.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            QuizEditorForm form = new QuizEditorForm();
            form.Show();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
