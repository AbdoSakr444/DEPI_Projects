using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_DEPI
{
    internal class Question
    {
        // Properties
        public int ID { get; set; }
        public int Number {  get; set; }
        public double Mark {  get; set; }
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public StudentAnswer StudentAnswer { get; set; }
        public Exam exam { get; set; } 


        // Constructors
        public Question()
        {
            ID = 1;
            Number = 1;
            Text = "What HTML Stands for ?\nA)Hyper Text Markup Language";
            CorrectAnswer = "Not yet";
            Mark = 1;
        }
        public Question(int ID,int Number,int Mark,string Text,string CorrectAnswer)
        {
            this.ID = ID;
            this.Number = Number;
            this.Mark = Mark;
            this.Text = Text;
            this.CorrectAnswer = CorrectAnswer;
        }


        // Methods
        public virtual void Display()
        {
            Console.WriteLine("Will be Overridden");
        }


    }
}
