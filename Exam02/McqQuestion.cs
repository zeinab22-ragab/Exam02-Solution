using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class McqQuestion : Question
    {
       

        
        public McqQuestion( string body, int mark ) : base( body, mark)
        {
            Header = "MCQ Question";
        }
    }
}
