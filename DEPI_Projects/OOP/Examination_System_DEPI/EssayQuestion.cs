using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_DEPI
{
    internal class EssayQuestion : Question
    {
        public EssayQuestion() : base()
        {

        }
        public EssayQuestion(int ID, int Number, int Mark, string Text, string CorrectAnswer) : base()
        {

        }
        public override void Display()
        {
            Console.WriteLine($"[{Number}] {Text} {Mark}");
        }
    }
}
