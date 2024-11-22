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
        private Boolean isTrue;
        private int starValue;

        public TrueFalseQuestion(string question, int starValue) : base(question, starValue)
        {
            this.question = question;
            this.starValue = starValue;
        }

        public void SetTrue()
        {
            this.isTrue = true;
        }

        public void SetFalse()
        {
            this.isTrue = false;
        }
    }
}
