using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultwinform
{
    internal static class Program
    {

        public static Boolean successfulConnection = true;
        public static UserAccount currentAccount = null;
        public static String profilePicPath = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginFrm = new LoginForm();
            QuizDAO.tempQuiz();
            loginFrm.Show();
            Application.Run();
        }
    }
}
