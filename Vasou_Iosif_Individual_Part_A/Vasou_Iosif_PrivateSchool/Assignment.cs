using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasou_Iosif_PrivateSchool
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public float OralMark { get; set; }
        public float TotalMark { get; set; }
        public List<Student> StudentList { get; set; }

        public Assignment(string title, string description, DateTime submissionDate, float oralMark, float totalMark)
        {
            this.Title = title;
            this.Description = description;
            this.SubmissionDate = submissionDate;
            this.OralMark = oralMark;
            this.TotalMark = totalMark;
            this.StudentList = new List<Student>();
        }

        static public void PrintAssignments(List<Assignment> AssignmentList)
        {
            foreach (Assignment assignment in AssignmentList)
            {
                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine("\n" + "Title: " + assignment.Title
                    + "\n" + "Description: " + assignment.Description + "\n"
                    + "Submission Date: " + assignment.SubmissionDate + "\n"
                    + "Oral Mark: " + assignment.OralMark + "\n"
                    + "Total Mark: " + assignment.TotalMark);
                Console.WriteLine("------------------------------------------");
            }
        }
        public static void CreateAssignment(List<Assignment> myAssignmentList)
        {
            try
            {
                Console.Clear();
                Console.Write("Enter title of the Assignment: ");
                var titleInput = Console.ReadLine();
                Console.Write("Enter description of the Assignment: ");
                var descriptionInput = Console.ReadLine();
                Console.Write("Enter submission date (dd/MM/yyyy): ");
                var subDateInput = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Oral Mark: ");
                var oralInput = float.Parse(Console.ReadLine());
                Console.Write("Total Mark: ");
                var totalInput = float.Parse(Console.ReadLine());

                var newAssignment = new Assignment(titleInput, descriptionInput, subDateInput, oralInput, totalInput);
                myAssignmentList.Add(newAssignment);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Parameter");
            }
        }
        public static void AddStudentToAssignment(Student inStudent, Assignment inAssignment)
        {
            inAssignment.StudentList.Add(inStudent);
        }

        public static void PrintStudentsInAssignment(List<Student> Students)
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
