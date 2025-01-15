using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class QuizDAO
    {

        private static List<QuizPanel> quizPanels = new List<QuizPanel>();

        private static List<Quiz> assignedQuizzes = new List<Quiz>();

        private static Quiz currentQuiz = null;

        
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=geography;";

        public static void retrieveQuizzes()
        {
            //database call

            
        }

        public static void tempQuiz()
        {
            Quiz quiz = new Quiz();
            quiz.setTopic("State Geography");
            quiz.setImage("https://cdn.britannica.com/13/197813-138-3CF1CCFA/state-more-president-Washington-economy-geography-history.jpg?w=800&h=450&c=crop");

            quiz.addQuestion(new MultipleChoice("What type of geographic feature is this?", 1, "https://cdn.britannica.com/13/197813-138-3CF1CCFA/state-more-president-Washington-economy-geography-history.jpg?w=800&h=450&c=crop", new List<String> {"Valley", "Plateu", "Mountains", "Canyon"}, "Valley"));
            quiz.addQuestion(new TrueFalseQuestion("Mountains are a geography feature.", 3, true, ""));
            quiz.addQuestion(new MultipleAnswer("Which of the following countries border France?", 3, "", new List<String> { "Italy", "Belgium", "Germany", "Spain" }, new List<String> { "Italy", "Germany" }));

            assignedQuizzes.Add(quiz);
        }

        public static List<Quiz> getQuizzes()
        {
            return assignedQuizzes;
        }

        public static List<QuizPanel> getQuizPanels()
        {
            return quizPanels;
        }

        public static void addQuizPanel(QuizPanel quizPanel)
        {

            if (!quizPanels.Contains(quizPanel))
            {
                quizPanels.Add(quizPanel);
            }
        }

        public static void setCurrentQuiz(Quiz quiz)
        {
            currentQuiz = quiz;
        }

        public static Quiz getCurrentQuiz()
        {
            return currentQuiz;
        }
    }
}
