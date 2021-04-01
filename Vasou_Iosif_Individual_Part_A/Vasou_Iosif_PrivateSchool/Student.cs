using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasou_Iosif_PrivateSchool
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, double tuitionFees)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.TuitionFees = tuitionFees;
        }

        static public void PrintStudents(List<Student> StudentsList)
        {
            foreach (Student student in StudentsList)
            {

                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine("\n" + "First Name: " + student.FirstName
                    + "\n" + "Last Name: " + student.LastName + "\n"
                    + "Date of Birth: " + student.DateOfBirth + "\n"
                    + "Tuition Fees: " + student.TuitionFees);
                Console.WriteLine("------------------------------------------");
            }
        }
        public static void CreateStudent(List<Student> StudentList)
        {
            try
            {
                Console.Clear();
                Console.Write("Enter Student first Name or press Enter to use a synthetic name: ");
                var firstNameInput = Console.ReadLine();
                Console.Write("Enter Student last Name: ");
                var lastNameInput = Console.ReadLine();
                DateTime birthDateInput;
                Console.Write("Enter Date of Birth (dd/MM/yyyy): ");
                birthDateInput = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Enter tuition fees: ");
                var tuitionFeesInput = Convert.ToDouble(Console.ReadLine());

                var newStudent = new Student(firstNameInput, lastNameInput, birthDateInput, tuitionFeesInput);
                StudentList.Add(newStudent);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Parameter");
            }
        }
    }
}
