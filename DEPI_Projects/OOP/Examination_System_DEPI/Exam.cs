using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_DEPI
{
    internal class Exam
    {
        // Properties
        public int ID { get; set; }
        public double Duration { get; set; }
        public int NumOfQuestions { get; set; }
        public int Year { get; set; }
        public Course Course { get; set; } = new Course();
        public Instructor Instructor { get; set; } = new Instructor();
        public List<Question> questions { get; set; } = new List<Question>();
        public List<Student> students { get; set; } = new List<Student>();

        // Constructors
        public Exam()
        {
            ID = 0;
            Duration = 0;
            NumOfQuestions = 0;
            Year = 0;
        }
        public Exam(int ID,double Duration,int NumofQuestions,int Year)
        {
            this.ID = ID;
            this.Duration = Duration;
            this.NumOfQuestions = NumofQuestions;
            this.Year = Year;
        }


        // Methods
        public void AddQuestion(Question question)
        {
            this.questions.Add(question);
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student); 
        }
        public void RemoveQuestion(Question question) 
        { 
            this.questions.Remove(question); 
        }
        public void Display()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine($"{Course.Title} Exam");
            Console.WriteLine($"Instructor : {Instructor.Name}");
            Console.WriteLine($"Year : {Year}");
            Console.WriteLine($"Duration : {Duration} Minutes");
            Console.WriteLine($"Number of Questions : {NumOfQuestions}");
            Console.WriteLine("==================== Questions ====================\n");
            foreach(Question question in questions)
            {
                question.Display();
            }
        }
        public void ExamHeader()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine($"{Course.Title} Exam");
            Console.WriteLine($"Instructor : {Instructor.Name}");
            Console.WriteLine($"Year : {Year}");
            Console.WriteLine($"Duration : {Duration} Minutes");
            Console.WriteLine($"Number of Questions : {NumOfQuestions}");
            Console.WriteLine("==================== Questions ====================\n");
        }
    }
}
