using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Vasou_Iosif_PrivateSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the LISTS 
            List<Student> StudentList = new List<Student>();
            List<Trainer> TrainerList = new List<Trainer>();
            List<Assignment> AssignmentList = new List<Assignment>();
            List<Course> CourseList = new List<Course>();

            //SYNTHETIC DATA
            //ADDING STUDENTS
            var Student1 = new Student("Marios", "Filiou", new DateTime(1989, 11, 15), 300);
            StudentList.Add(Student1);
            var Student2 = new Student("Georgia", "Kostoglou", new DateTime(1990, 03, 24), 300);
            StudentList.Add(Student2);
            var Student3 = new Student("Giorgos", "Georgiou", new DateTime(1992, 05, 07), 300);
            StudentList.Add(Student3);
            //ADDING ASSIGNMENTS
            var Assignment1 = new Assignment("Assignment1", "1st Assignment", new DateTime(2021, 07, 15), 50, 100);
            AssignmentList.Add(Assignment1);
            var Assignment2 = new Assignment("Assignment2", "2nd Assignment", new DateTime(2021, 05, 11), 60, 110);
            AssignmentList.Add(Assignment1);
            var Assignment3 = new Assignment("Assignment3", "3rd Assignment", new DateTime(2021, 06, 20), 55, 90);
            AssignmentList.Add(Assignment1);
            //ADDING ASSGNMENTS
            Assignment.AddStudentToAssignment(Student1, Assignment1);
            Assignment.AddStudentToAssignment(Student2, Assignment2);
            Assignment.AddStudentToAssignment(Student3, Assignment3);
            //ADDING TRAINERS
            var Trainer1 = new Trainer("Kostas", "Kostoglou", "Introduction to Programming");
            TrainerList.Add(Trainer1);
            var Trainer2 = new Trainer("Maria", "Georgiou", "Introduction to Data Bases");
            TrainerList.Add(Trainer2);
            //ADDING COURSES
            var Course1 = new Course("Course1", "C#", "Full", "15/03/2021", "28/08/2021");
            CourseList.Add(Course1);
            var Course2 = new Course("Course2", "Java", "Part", "01/03/2021", "30/08/2021");
            CourseList.Add(Course2);
            var Course3 = new Course("Course3", "JavaScript", "Full", "26/02/2021", "25/08/2021");
            CourseList.Add(Course3);

            //ADDING STUDENTS, TRAINERS AND ASSIGNMENTS TO COURSES
            Course.AddTrainerToCourse(Trainer1, Course1);
            Course.AddTrainerToCourse(Trainer2, Course2);
            Course.AddStudentToCourse(Student1, Course1);
            Course.AddStudentToCourse(Student1, Course2);
            Course.AddStudentToCourse(Student2, Course2);
            Course.AddStudentToCourse(Student2, Course3);
            Course.AddStudentToCourse(Student3, Course3);
            Course.AddAssignmentTocourse(Assignment1, Course1);
            Course.AddAssignmentTocourse(Assignment2, Course2);
            Course.AddAssignmentTocourse(Assignment3, Course3);

            //Building the menu
            Console.ForegroundColor = ConsoleColor.Yellow;
            var hasEntered = false;
            while (hasEntered == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("PRIVATE SCHOOL SYSTEM");
                Console.WriteLine("\n" + "What would you like to do?");
                Console.WriteLine("\n" + "1)Create a Student"
                                + "\n" + "2)Create a Trainer"
                                + "\n" + "3)Create Assignment"
                                + "\n" + "4)Create Course"
                                + "\n" + "5)Print Students"
                                + "\n" + "6)Print Trainers"
                                + "\n" + "7)Print Assignments"
                                + "\n" + "8)Print Courses"
                                + "\n" + "9)Add Student to Course"
                                + "\n" + "10)Print Students in Course"
                                + "\n" + "11)Add Trainers to Course"
                                + "\n" + "12)Print Trainers in Course"
                                + "\n" + "13)Add Assignments to Course"
                                + "\n" + "14)Print Assignments in Course"
                                + "\n" + "15)Add Student to Assignment"
                                + "\n" + "16)Print Student per Assignment"
                                + "\n" + "17)Print List of Students that belong to more than one courses"
                                + "\n" + "18)Enter an Assignment Date to check which Students need to submit"
                                + "\n" + "19)Exit");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n" + "Choose an action from above: ");

                var menuSelection = Console.ReadLine();
                if (menuSelection == "1")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("STUDENT CREATION MODE" + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("How many students would you like to create?: ");
                        var studNrCreate = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= studNrCreate; i++)
                        {
                            Console.WriteLine("\n" + $"Creating student nr: {i} ");
                            Student.CreateStudent(StudentList);
                            Console.WriteLine("\n" + "Student Created ");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "2")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("TRAINER CREATION MODE" + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("How many trainers would you like to create?: ");
                        var trainerCreate = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= trainerCreate; i++)
                        {
                            Console.WriteLine("\n" + $"Creating trainer nr: {i} ");
                            Trainer.CreateTrainer(TrainerList);
                            Console.WriteLine("\n" + "Trainer Created ");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "3")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ASSIGNMENT CREATION MODE" + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("How many assignments would you like to create?: ");
                        var assCreate = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= assCreate; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n" + $"Creating Assignment nr: {i} ");
                            Assignment.CreateAssignment(AssignmentList);
                            Console.WriteLine("\n" + $"Assignment {i} Created ");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n" + "Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "4")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("COURSE CREATION MODE" + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("How many courses would you like to create?: ");
                        var courseCreate = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= courseCreate; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n" + $"Creating Course nr: {i} ");
                            Course.CreateCourse(CourseList);
                            Console.WriteLine("\n" + $"Course {i} Created ");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n" + "Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "5")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING THE STUDENTS");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Student.PrintStudents(StudentList);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "6")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING THE TRAINERS");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Trainer.PrintTrainers(TrainerList);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "7")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING THE ASSIGNMENTS");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Assignment.PrintAssignments(AssignmentList);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "8")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + "PRINTING THE COURSES");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Course.PrintCourses(CourseList);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "9")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ADDING STUDENT TO COURSE" + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Course course in CourseList)
                        {
                            Console.WriteLine((CourseList.IndexOf(course) + 1) + ")" + $" {course.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Courses above: ");
                        var courseNr = (Convert.ToInt16(Console.ReadLine()) - 1);

                        Console.WriteLine("");
                        foreach (Student student in StudentList)
                        {
                            Console.WriteLine((StudentList.IndexOf(student) + 1) + ")" + $" {student.FirstName}" + $" {student.LastName}");
                        }
                        Console.Write("\n" + "Choose a number from the Students above: ");
                        var studentNr = (Convert.ToInt16(Console.ReadLine()) - 1);
                        Course.AddStudentToCourse(StudentList[studentNr], CourseList[courseNr]);
                        Console.WriteLine("\n" + StudentList[studentNr].FirstName + " " + StudentList[studentNr].LastName + " " + "has been added to " + CourseList[courseNr].Title);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n" + "Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered!");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "10")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PRINTING STUDENTS IN COURSE" + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Course course in CourseList)
                        {
                            Console.WriteLine((CourseList.IndexOf(course) + 1) + ")" + $" {course.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Courses above: ");
                        var courseNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Course.PrintStudentsInCourse(CourseList[courseNr].StudentList);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n" + "Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered!");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "11")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ADDING A TRAINER TO A COURSE" + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Course course in CourseList)
                        {
                            Console.WriteLine((CourseList.IndexOf(course) + 1) + ")" + $" {course.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Courses above: ");
                        var courseNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        
                        Trainer.PrintTrainers(TrainerList);
                        Console.Write("\n" + "Choose a number from the Trainers above: ");
                        var trainertNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Course.AddTrainerToCourse(TrainerList[trainertNr], CourseList[courseNr]);
                        Console.WriteLine("\n" + TrainerList[trainertNr].FirstName + " " + TrainerList[trainertNr].LastName + " " + "has been added to" + CourseList[courseNr].Title + "\n");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered!");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "12")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PRINTING TRAINERS IN COURSE" + "\n");
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Course course in CourseList)
                        {
                            Console.WriteLine((CourseList.IndexOf(course) + 1) + ")"+ $" {course.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Course list above: ");
                        var courseNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Course.PrintTrainersInCourse(CourseList[courseNr].TrainerList);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered!");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "13")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ADDING ASSIGNMENT TO COURSE" + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Course course in CourseList)
                        {
                            Console.WriteLine((CourseList.IndexOf(course) + 1) + ")" + $" {course.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Course list above: ");
                        var courseNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        
                        Console.WriteLine("");
                        foreach (Assignment assignment in AssignmentList)
                        {
                            Console.WriteLine((AssignmentList.IndexOf(assignment) + 1) + ")" + $" {assignment.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Assignment list above: ");
                        var assNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Course.AddAssignmentTocourse(AssignmentList[assNr], CourseList[courseNr]);
                        Console.WriteLine("\n" + AssignmentList[assNr].Title + " " + "has been added to" + CourseList[courseNr].Title);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n" + "Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "14")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PRINTING ASSIGNMENTS IN COURSE" + "\n");
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Course course in CourseList)
                        {
                            Console.WriteLine((CourseList.IndexOf(course) + 1) + ")" + $" {course.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Courses list above: ");
                        var courseNr = (Convert.ToInt32(Console.ReadLine()) - 1);

                        Console.WriteLine("");
                        Course.PrintAssignmentsInCourse(CourseList[courseNr], CourseList[courseNr].AssignmentList);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n" + "Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered!");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "15")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ADD STUDENT TO ASSIGNMENT" + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Student student in StudentList)
                        {
                            Console.WriteLine((StudentList.IndexOf(student) + 1) + ")" + $" {student.FirstName}" + $" {student.LastName}");
                        }
                        Console.Write("\n" + "Choose a number from the Students list above: ");
                        var studentNr = (Convert.ToInt32(Console.ReadLine()) - 1);

                        Console.WriteLine("");
                        foreach (Assignment assignment in AssignmentList)
                        {
                            Console.WriteLine((AssignmentList.IndexOf(assignment) + 1) + ")" + $" {assignment.Title}");
                        }
                        Console.Write("Choose a number from the Assignment list above: ");
                        var assNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Assignment.AddStudentToAssignment(StudentList[studentNr], AssignmentList[assNr]);

                        Console.WriteLine("\n" + StudentList[studentNr].FirstName + " " + StudentList[studentNr].LastName + " " + "has been added to" + AssignmentList[assNr].Title);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n" + "Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "16")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PRINTING STUDENTS IN ASSIGNMENT" + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Assignment assignment in AssignmentList)
                        {
                            Console.WriteLine((AssignmentList.IndexOf(assignment) + 1) + ")" + $" {assignment.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Assignment list above: ");
                        var AssNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("");
                        Assignment.PrintStudentsInAssignment(AssignmentList[AssNr].StudentList);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n" + "Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered!");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "17")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    var newList = CourseList[0].StudentList.Intersect(CourseList[2].StudentList);

                    foreach (Student student in newList)
                    {
                        Console.WriteLine("\n" + student.FirstName + " " + student.LastName + " is a student in more than one Course");
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "18")
                {
                    Console.Clear();
                    Console.Write("Enter date (dd/MM/yyyy): ");
                    DateTime myDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine("\n" + $"You have entered: {myDate}");

                    //Method to convert DateTime to Day of Week
                    int GetWeekOfYear(DateTime time)
                    {
                        DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
                        if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                        {
                            time = time.AddDays(3);
                        }
                        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                    }

                    int myWeek = GetWeekOfYear(myDate);
                    Console.WriteLine("\n" + $"Week number of the date that you have entered: {myWeek}");

                    foreach (Assignment assignment in AssignmentList)
                    {
                        int deadlineWeek = GetWeekOfYear(assignment.SubmissionDate);
                        Console.WriteLine("\n" + $"Week number of the {assignment.Title} assignment is: {deadlineWeek}");

                        if (myWeek == deadlineWeek)
                        {
                            foreach (Student student in assignment.StudentList)
                            {
                                Console.WriteLine("\n" + student.FirstName + " " + student.LastName + $" needs to deliver an {assignment.Title} assignment");
                                Console.Write("\n" + "Press any key to show next.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No student needs to submit in the given week");
                            Console.Write("\n" + "Press any key to show next.");
                            Console.ReadKey();
                        }
                    }
                }
                if (menuSelection == "19")
                {
                    hasEntered = true;
                }
            }
        }
    }
}
