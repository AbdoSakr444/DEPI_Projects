using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_DEPI
{
    internal class Instructor
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public List<Exam> exams { get; set; } = new List<Exam>();
        public List<Course> courses { get; set; } = new List<Course>();



        // Constructors
        public Instructor()
        {
            ID = 1;
            Name = "Karim Essam";
            Specialization = "CS";
        }
        public Instructor(int ID,string Name,string Specialization)
        {
            this.ID = ID;
            this.Name = Name;
            this.Specialization = Specialization;
        }


        // Methods
        public void Display()
        {
            Console.WriteLine("========== Instructor Details ==========");
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Specialization : {Specialization}");
            Console.WriteLine("========================================");
        }
        public void TeachCourse(Course course)
        {
            courses.Add(course);
        }
        public void CreateExam(Exam exam)
        {
            exams.Add(exam);
        }


    }
}
