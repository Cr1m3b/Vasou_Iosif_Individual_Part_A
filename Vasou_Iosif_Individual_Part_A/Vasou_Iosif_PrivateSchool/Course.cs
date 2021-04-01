using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasou_Iosif_PrivateSchool
{
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Trainer> TrainerList { get; set; }
        public List<Assignment> AssignmentList { get; set; }

        public Course(string title, string stream, string type, string startDate, string endDate)
        {
            this.Title = title;
            this.Stream = stream;
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StudentList = new List<Student>();
            this.TrainerList = new List<Trainer>();
            this.AssignmentList = new List<Assignment>();
        }
        static public void PrintCourses(List<Course> CourseList)
        {
            foreach (Course course in CourseList)
            {
                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine("Course Title: " + course.Title
                    + "\n" + "Stream: " + course.Stream + "\n"
                    + "Type: " + course.Type + "\n"
                    + "Start Date: " + course.StartDate + "\n"
                    + "End Date: " + course.EndDate);
                Console.WriteLine("------------------------------------------");
            }
        }
        public static void PrintStudentsInCourse(List<Student> Students)
        {
            foreach (Student student in Students)
            {
                Console.WriteLine("\n" + student.FirstName + " " + student.LastName);
            }
        }

        public static void PrintTrainersInCourse(List<Trainer> Trainers)
        {
            foreach (Trainer trainer in Trainers)
            {
                Console.WriteLine("\n" + trainer.FirstName + " " + trainer.LastName + "\n");
            }
        }

        public static void PrintAssignmentsInCourse(Course myCourse, List<Assignment> Assignments)
        {
            foreach (Assignment assignment in Assignments)
            {
                Console.WriteLine(assignment.Title + " " + assignment.SubmissionDate);
            }
        }

        public static void CreateCourse(List<Course> myCourseList)
        {
            Console.Clear();
            Console.Write("Enter Course Title: ");
            var titleInput = Console.ReadLine();
            Console.Write("Enter Stream (C# or Java): ");
            var streamInput = Console.ReadLine();
            Console.Write("Enter Course Type (Full, Part): ");
            var typeInput = Console.ReadLine();
            Console.Write("Enter Course Start Date: ");
            var startDateInput = Console.ReadLine();
            Console.Write("Enter Course End Date: ");
            var endDateInput = Console.ReadLine();

            var newCourse = new Course(titleInput, streamInput, typeInput, startDateInput, endDateInput);
            myCourseList.Add(newCourse);
        }

        public static void AddStudentToCourse(Student inStudent, Course inCourse)
        {
            inCourse.StudentList.Add(inStudent);
        }

        public static void AddAssignmentTocourse(Assignment inAssignment, Course inCourse)
        {
            inCourse.AssignmentList.Add(inAssignment);
        }
        
        public static void AddTrainerToCourse(Trainer inTrainer, Course inCourse)
        {
            inCourse.TrainerList.Add(inTrainer);
        }
    }
}
