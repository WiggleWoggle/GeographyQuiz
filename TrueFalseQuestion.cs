using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    public class TrueFalseQuestion : Question
    {
        private String question;

        public TrueFalseQuestion(string question) : base(question)
        {
            this.question = question;
        }
    }
}
