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

        public MultipleAnswer(string question, int starValue, String URLString) : base(question, starValue, URLString)
        {
            setURLString(URLString);
        }
    }
}
