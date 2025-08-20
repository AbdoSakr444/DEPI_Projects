using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_DEPI
{
    internal class StudentAnswer
    {
        // Properties
        public int ID { get; set; }
        public string Answer {  get; set; }
        public double AnswerMark { get; set; }
        public Question Question { get; set; } 
        public Student Student { get; set; } 


        // Constructors
        public StudentAnswer()
        {
            ID = 1;
            Answer = "A";
        }
        public StudentAnswer(int ID,string Answer)
        {
            this.ID = ID;
            this.Answer = Answer;
        }


        // Methods
        public void Display()
        {
            Console.WriteLine($"Student Answer : {Answer}");
        }
        public bool IsCorrect()
        {
            if(Answer == Question.CorrectAnswer)
            {
                AnswerMark = Question.Mark;
                return true;
            }

            else
            {
                AnswerMark = 0;
                return false;
            }
        }

    }
}
