using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Subject
    {
         public int SubjectId {  get; set; }
        public string SubjectName { get; set; }

        public Exam Exam { get; set; }
        public Subject(int subjectId , string subjectName ) 
        { 
            SubjectId=subjectId;
            SubjectName=subjectName;
            
  
        
        }

        public void CreateExam()
        {
            Console.WriteLine("please Enter The Type Of  Exam You Want To Create (1 for Practical and  2 for Final): ");
            int TypeOfExam = int.Parse(Console.ReadLine());
            Console.WriteLine("please Enter The Time Of  Exam in Minutes :");
            int Time = int.Parse(Console.ReadLine());
            Console.WriteLine("please Enter The Number Of  Question You Want To Create :");
            int Number = int.Parse(Console.ReadLine());


            Exam = TypeOfExam ==1 ? new PracticalExam(Time , Number , new List<Question>() ) : new FinalExam(Time , Number , new List<Question>() );

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Please Choose The Type of Question Number (1 for True OR False and  2 for MCQ): ");
                string TypeOfQuestion = Console.ReadLine();
                Console.WriteLine("Please Enter The Body Of Question");
                string Body = Console.ReadLine();
                Console.WriteLine("Please Enter The Mark Of Question");
                int Mark = int.Parse(Console.ReadLine());


                Question questions = TypeOfQuestion == "1" ? new TrueOrFalseQuestion(Body , Mark) : new McqQuestion (Body , Mark);

                if (TypeOfQuestion == "2")
                {
                    Console.WriteLine("The Choices of Question:");
                    
                    for(int M = 1; M<= 3; i++)
                    {
                        Console.WriteLine($"Please Enter The Choice Number {M}: ");
                        questions .Answers.Add(new Answer(M, Console.ReadLine()));
                    }

                }

              Exam.Questions.Add(questions);
                
                    
        


            }





        }










    }
}
