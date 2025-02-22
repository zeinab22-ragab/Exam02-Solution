using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestion, List<Question> questions) : base(timeOfExam, numberOfQuestion, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("\nExam Questions:");

            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].ShowQuection();
                Console.Write("Your answer: ");
                Console.WriteLine($"Q{i + 1}) {Questions[i].Body}: {Console.ReadLine()}");
            }
            Console.WriteLine($"Your Exam Grade is {Questions.Count} from {Questions.Count}");
        }
    
    }
}
