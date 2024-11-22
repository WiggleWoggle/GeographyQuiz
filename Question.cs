using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    public class Question
    {
        private String question;
        private String URLString;
        private int starValue;

        public Question(String question, int starValue) {
        
            this.question = question;
            this.starValue = starValue;
        }

        public String getQuestion()
        {
            return this.question;
        }

        public void setQuestion(String question)
        {
            this.question = question;
        }

        public String getURLString()
        {
            return this.URLString;
        }

        public void setURLString(String URLString)
        {
            this.URLString = URLString;
        }

        public int getStarValue()
        {
            return this.starValue;
        }

        public void setStarValue(int starValue)
        {
            this.starValue = starValue;
        }
    }
}
