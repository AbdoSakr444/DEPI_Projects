using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_DEPI
{
    internal class MCQQuestions :Question
    {
        // Properties
        public string QuetionAnswers { get; set; }

        // Constructors
        public MCQQuestions():base()
        {
            QuetionAnswers = "Not yet";
        }
        public MCQQuestions(int ID, int Number, int Mark, string Text, string CorrectAnswer, string QustionAnswers):base(ID,Number,Mark,Text,CorrectAnswer)
        {
            this.QuetionAnswers = QustionAnswers;
        }


        // Methods
        public override void Display()
        {
            string formattedQAnswers = QuetionAnswers.Replace("\\n", "\n");
            Console.WriteLine($"[{Number}] {Text} ({Mark} Mark) \n{formattedQAnswers}");
        }
    }
}
