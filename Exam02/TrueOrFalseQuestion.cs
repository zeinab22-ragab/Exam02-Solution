using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{

    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion( string body, int mark) : base( body, mark)
        {
            Header = "True || False Question";
            Answers = new List<Answer>
            { 
              new Answer (1 , "True"),
              new Answer(2 , "False")
            
            };
              
            


            
        }
    }
}
