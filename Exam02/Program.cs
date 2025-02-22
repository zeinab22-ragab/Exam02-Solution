using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Subject subject = new Subject(1,"c3");
            subject.CreateExam();
            Console.Clear();

            Console.WriteLine("Do You Want Start The Exam (Y/N) ");
            if (char.Parse(Console.ReadLine()) == 'Y')
            { 
            
             Stopwatch stopwatch = new Stopwatch(); 
                stopwatch.Start();
                subject.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {stopwatch.Elapsed}");

            
            
            
            }


        }
    }
}
