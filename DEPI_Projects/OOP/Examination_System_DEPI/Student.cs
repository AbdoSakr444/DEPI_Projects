using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_DEPI
{
    internal class Student
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Course> courses { get; set; } = new List<Course>();
        public List<Exam> exams { get; set; } = new List<Exam>();
        public List<StudentAnswer> answers { get; set; } = new List<StudentAnswer>();

        // Constructors
        public Student()
        {
            ID = 1;
            Name = "Abdelrahman Amr";
            Email = "Abdo@gmail.com";
        }
        public Student(int ID,string Name,string Email)
        {
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
        }


        // Methods
        public void Display()
        {
            Console.WriteLine("========== Student Details ==========");
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine("=====================================");
        }
        public void AddCourse(Course course)
        {
            courses.Add( course );
        }
        public void TakeExam(Exam exam)
        {
            exams.Add( exam );
        }
        public void AddAnswer(StudentAnswer studentAnswer)
        {
            answers.Add( studentAnswer );
        }
    }
}
