using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class ShortResponse : Question
    {
        private String question;
        private List<String> phrases;
        private int starValue;

        public ShortResponse(string question, int starValue, String URLString) : base(question, starValue, URLString)
        { 
            setURLString(URLString);
            this.question = question;
            this.starValue = starValue; 
        }
    }
}
