using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_DEPI
{
    internal class Course
    {
        // Properites
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double MaxDegree { get; set; }
        public List<Exam> exams { get; set; } = new List<Exam>();
        public Instructor Instructor { get; set; } = new Instructor();
        public List<Student> students { get; set; } = new List<Student>();

        // Constructors
        public Course()
        {
            ID = 0;
            Title = "C#";
            Description = ".Net Programming Language";
            MaxDegree = 100;
        }
        public Course(int ID,string Title,string Description,double MaxDegree)
        {
            this.ID=ID;
            this.Title = Title;
            this.Description = Description;
            this.MaxDegree = MaxDegree;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine("========== Course Details ==========");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Max Degree : {MaxDegree}");
            Console.WriteLine("====================================");
        }
        public void AddExam(Exam exam)
        {
            exams.Add(exam);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
