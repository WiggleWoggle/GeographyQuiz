using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class MultipleChoice : Question
    {
        private String question;
        private List<String> choices;
        private String answer;
        private int starValue;

        public MultipleChoice(string question, int starValue) : base(question, starValue)
        {

        }
    }
}
