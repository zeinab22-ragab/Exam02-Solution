using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Exam
    {
        public int  TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int timeOfExam , int numberOfQuestion , List<Question> questions) 
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestion = numberOfQuestion;
            Questions = questions;
        }

        public abstract void ShowExam();
    }
}
