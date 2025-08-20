using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examination_System_DEPI
{
    internal class TFQuestion : Question
    {
        // Properties
        public string QuetionAnswers { get; set; }

        // Constructors
        public TFQuestion() : base()
        {
            QuetionAnswers = "Not yet";
        }
        public TFQuestion(int ID, int Number, int Mark, string Text, string CorrectAnswer, string QustionAnswers) : base(ID, Number, Mark, Text, CorrectAnswer)
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
