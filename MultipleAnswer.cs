using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class MultipleAnswer : Question
    {
        private String question;
        private List<String> choices;
        private List<String> answers;
        private int starValue;

        public MultipleAnswer(string question, int starValue, String URLString, List<String> choices, List<String> answers) : base(question, starValue, URLString)
        {
            this.setURLString(URLString);
            this.question = question;
            this.starValue = starValue;
            this.answers = answers;
            this.choices = choices;
        }

        public List<String> getChoices()
        {
            return choices;
        }

        public String getFirstChoice()
        {
            return choices[0];
        }

        public String getSecondChoice()
        {
            return choices[1];
        }

        public String getThirdChoice()
        {
            return choices[2];
        }

        public String getFourthChoice()
        {
            return choices[3];
        }
    }
}
