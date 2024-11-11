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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Size = new Size(594, 692);
            this.MinimumSize = new Size(594, 692);
            this.MaximumSize = new Size(594, 692);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }
    }
}
