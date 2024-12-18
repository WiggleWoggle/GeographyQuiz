﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class QuizDAO
    {

        public static List<QuizPanel> quizPanels = new List<QuizPanel>();

        private static List<Quiz> assignedQuizzes = new List<Quiz>();

        private static Quiz currentQuiz = null;

        
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=geography;";

        public static void retrieveQuizzes()
        {
            //database call

            tempQuiz();
        }

        private static void tempQuiz()
        {
            Quiz quiz = new Quiz();
            quiz.setTopic("State Geography");
            quiz.setImage("https://cdn.britannica.com/13/197813-138-3CF1CCFA/state-more-president-Washington-economy-geography-history.jpg?w=800&h=450&c=crop");

            MultipleChoice question = new MultipleChoice("What type of geographic feature is this?", 1, "", null, "TEST");
            quiz.addQuestion(question);

            assignedQuizzes.Add(quiz);
        }

        public static List<Quiz> getQuizzes()
        {
            return assignedQuizzes;
        }

        public static void addQuizPanel(QuizPanel quizPanel)
        {

            quizPanels.Add(quizPanel);
        }
    }
}
