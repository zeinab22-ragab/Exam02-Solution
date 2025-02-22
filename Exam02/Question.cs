using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }

        public int Mark { get; set; }

        public List<Answer> Answers { get; set; }

        
        public Question( string body , int mark) 
        { 
          
            Body = body;
            Mark = mark;
            Answers = new List<Answer>();
        
        }

        public void ShowQuection()
        {
            Console.WriteLine($" {Header} \n  {Body} \n  Mark=> {Mark}");
            
        }

    }
}
