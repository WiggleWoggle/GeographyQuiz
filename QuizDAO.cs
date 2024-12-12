using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class QuizDAO
    {
        private static List<Quiz> assignedQuizzes = new List<Quiz>();
        
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=geography;";

        public static void retrieveQuizzes()
        {
            //database call

            Quiz quiz = new Quiz();
            quiz.setTopic("TEST");
            quiz.setImage("https://t3.ftcdn.net/jpg/08/21/03/76/360_F_821037644_xm43dA9k8h6BOzVgqpGWZjJX4d07omHh.jpg");
            assignedQuizzes.Add(quiz);
        }

        public static List<Quiz> getQuizzes()
        {
            return assignedQuizzes;
        }
    }
}
