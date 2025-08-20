using Examination_System_DEPI;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examination_System_DEPI
{
    internal class Program
    {
        static void InstructorCreatesExam(List<Exam> Examslist)
        {
            Instructor instructor = new Instructor();

            Console.WriteLine("Enter Your ID : ");
            int InsID = Convert.ToInt32(Console.ReadLine());
            instructor.ID = InsID;

            Console.WriteLine("Enter Your Name : ");
            string InsName = Console.ReadLine();
            instructor.Name = InsName;

            Console.WriteLine("Enter Your Specialization : ");
            string InsSpec = Console.ReadLine();
            instructor.Specialization = InsSpec;


            Exam exam = new Exam();

            Console.WriteLine("Enter Exam ID : ");
            int ExamID = Convert.ToInt32(Console.ReadLine());
            exam.ID = ExamID;

            Console.WriteLine("Enter Exam Duration : ");
            double ExamDuration = Convert.ToDouble(Console.ReadLine());
            exam.Duration = ExamDuration;

            Console.WriteLine("Enter Exam Num Of Questions : ");
            int ExamNOQ = Convert.ToInt32(Console.ReadLine());
            exam.NumOfQuestions = ExamNOQ;

            Console.WriteLine("Enter Exam Year : ");
            int ExamYear = Convert.ToInt32(Console.ReadLine());
            exam.Year = ExamYear;


            Course course = new Course();

            Console.WriteLine("Enter Course ID");
            int CoID = Convert.ToInt32(Console.ReadLine());
            course.ID = CoID;

            Console.WriteLine("Enter Course Name : ");
            string CourseName = Console.ReadLine();
            course.Title = CourseName;

            Console.WriteLine("Enter Course Description : ");
            string CourseDes = Console.ReadLine();
            course.Description = CourseDes;

            Console.WriteLine("Enter Course Max Degree : ");
            double CourseDeg = Convert.ToDouble(Console.ReadLine());
            course.MaxDegree = CourseDeg;

           

            Console.WriteLine("Enter Questions : ");
            for(int i =0;i<exam.NumOfQuestions;i++)
            {
                Console.WriteLine("What is the Type of The Question (MCQ , True or False , Essay)");
                Console.WriteLine("1) MCQ");
                Console.WriteLine("2) True or False");
                Console.WriteLine("3) Essay");
                int option = 0;
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    MCQQuestions mcqQuestions = new MCQQuestions();

                    Console.WriteLine("Enter Question ID :  ");
                    int mcqqID = Convert.ToInt32(Console.ReadLine());
                    mcqQuestions.ID = mcqqID;

                    Console.WriteLine("Enter Question Number :  ");
                    int mcqqNumber = Convert.ToInt32(Console.ReadLine());
                    mcqQuestions.Number = mcqqNumber;

                    Console.WriteLine("Enter Question Mark :  ");
                    double mcqqMark = Convert.ToDouble(Console.ReadLine());
                    mcqQuestions.Mark = mcqqMark;

                    Console.WriteLine("Enter Question Header :  ");
                    string mcqqtxt = Console.ReadLine();
                    mcqQuestions.Text = mcqqtxt;

                    Console.WriteLine("Enter Question Answers :  ");
                    string mcqqans = Console.ReadLine();
                    mcqQuestions.QuetionAnswers = mcqqans;

                    Console.WriteLine("Enter Question Correct Answer (A,B,C,D) :  ");
                    string mcqqcans = Console.ReadLine();
                    mcqQuestions.CorrectAnswer = mcqqcans;

                    exam.AddQuestion(mcqQuestions);
                }

                else if (option == 2)
                {
                    TFQuestion tfQuestions = new TFQuestion();

                    Console.WriteLine("Enter Question ID :  ");
                    int tfqID = Convert.ToInt32(Console.ReadLine());
                    tfQuestions.ID = tfqID;

                    Console.WriteLine("Enter Question Number :  ");
                    int tfqNumber = Convert.ToInt32(Console.ReadLine());
                    tfQuestions.Number = tfqNumber;

                    Console.WriteLine("Enter Question Mark :  ");
                    double tfqMark = Convert.ToDouble(Console.ReadLine());
                    tfQuestions.Mark = tfqMark;

                    Console.WriteLine("Enter Question Header :  ");
                    string tfqtxt = Console.ReadLine();
                    tfQuestions.Text = tfqtxt;

                    Console.WriteLine("Enter Question Answers :  ");
                    string tfqans = Console.ReadLine();
                    tfQuestions.QuetionAnswers = tfqans;

                    Console.WriteLine("Enter Question Correct Answer (A,B) :  ");
                    string tfqcans = Console.ReadLine();
                    tfQuestions.CorrectAnswer = tfqcans;

                    exam.AddQuestion(tfQuestions);

                }

                else if (option == 3)
                {
                    EssayQuestion esQuestions = new EssayQuestion();

                    Console.WriteLine("Enter Question ID :  ");
                    int esqID = Convert.ToInt32(Console.ReadLine());
                    esQuestions.ID = esqID;

                    Console.WriteLine("Enter Question Number :  ");
                    int esqNumber = Convert.ToInt32(Console.ReadLine());
                    esQuestions.Number = esqNumber;

                    Console.WriteLine("Enter Question Mark :  ");
                    double esqMark = Convert.ToDouble(Console.ReadLine());
                    esQuestions.Mark = esqMark;

                    Console.WriteLine("Enter Question Header :  ");
                    string esqtxt = Console.ReadLine();
                    esQuestions.Text = esqtxt;

                    Console.WriteLine("Enter Question Correct Answer:  ");
                    string esqcans = Console.ReadLine();
                    esQuestions.CorrectAnswer = esqcans;

                    exam.AddQuestion(esQuestions);
                }
            }

            course.Instructor = new Instructor();
            course.Instructor = instructor;

            exam.Instructor = new Instructor();
            exam.Instructor = instructor;

            exam.Course = new Course();
            exam.Course = course;

            instructor.TeachCourse(course);
            instructor.CreateExam(exam);

            course.AddExam(exam);

            exam.Display();

            Examslist.Add(exam);

        }
        static Exam IsExamExist(List<Exam> Examslist,int ExamID)
        {
            Exam exam1 = new Exam();

            foreach (Exam exam in Examslist)
            {
                if (exam.ID == ExamID)
                {
                    exam1 = exam;
                    return exam1;
                }
            }

            return null;

        }
        static void BackToMainMenue(List<Exam> Examslist)
        {
            Console.WriteLine("Press any Key to go back to Main Menu ...");
            Console.ReadKey();
            ShowMainMenue(Examslist);
        }
        static void StudenTakesanExam(List<Exam> Examslist)
        {
            Student student = new Student();

            Console.WriteLine("Enter Your ID : ");
            int stdID = Convert.ToInt32(Console.ReadLine());
            student.ID = stdID;

            Console.WriteLine("Enter Your Name : ");
            string stdName = Console.ReadLine();
            student.Name = stdName;

            Console.WriteLine("Enter Your Email : ");
            string stdEmail = Console.ReadLine();
            student.Email = stdEmail;

            


            Console.WriteLine("Enter Exam ID : ");
            int exID = Convert.ToInt32(Console.ReadLine());

            Exam studexam = IsExamExist(Examslist,exID);

            if( studexam == null )
            {
                Console.WriteLine("Exam Does not Exist!");
                return;
            }

            student.TakeExam(studexam);
            studexam.ExamHeader();

            double TotalGrades = 0;
            foreach (Question question in studexam.questions)
            {
                TotalGrades += question.Mark;
                question.Display();
                Console.WriteLine("Enter Your Answer : ");
                StudentAnswer studentAnswer = new StudentAnswer();
                string StdAnswer = Console.ReadLine();
                studentAnswer.Question = new Question();
                studentAnswer.Question = question;
                studentAnswer.Answer = StdAnswer;
                studentAnswer.IsCorrect();
                student.AddAnswer(studentAnswer);
            }

            double Grade = 0;
            foreach(StudentAnswer ans in student.answers)
            {
                Grade += ans.AnswerMark;
            }

            Console.WriteLine("\n\n===================================================");
            Console.WriteLine($"Your Grade : {Grade}/{TotalGrades}");
            Console.WriteLine("===================================================");
        }
        static void PerformMainMenueOptions(int choice, List<Exam> exams)
        {
            if (choice == 1)
            {
                Console.Clear();
                InstructorCreatesExam(exams);
                BackToMainMenue(exams);
            }

            else if (choice == 2)
            {
                Console.Clear();
                StudenTakesanExam(exams);
                BackToMainMenue(exams);
            }
        }
        static void ShowMainMenue(List<Exam> exams)
        {
            Console.Clear();
            Console.WriteLine("========== Examination System ==========");
            Console.WriteLine("1) Instructor");
            Console.WriteLine("2) Student");
            Console.WriteLine("========================================");
            int choice = 0;
            Console.WriteLine("Enter an option (1 or 2) : ");
            choice = Convert.ToInt32(Console.ReadLine());
            PerformMainMenueOptions(choice,exams);
        }
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();
            ShowMainMenue(exams);
        }
    }
}


