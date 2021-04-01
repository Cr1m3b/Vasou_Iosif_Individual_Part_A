using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasou_Iosif_PrivateSchool
{
    class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Trainer(string firstName, string lastName, string subject)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
        }

        static public void PrintTrainers(List<Trainer> TrainersList)
        {
            foreach (Trainer trainer in TrainersList)
            {
                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine("\n" + "Trainer NR: " + (TrainersList.IndexOf(trainer) + 1) + ")" );
                Console.WriteLine("First Name: " + trainer.FirstName
                    + "\n" + "Last Name: " + trainer.LastName + "\n"
                    + "subject: " + trainer.Subject);
                Console.WriteLine("------------------------------------------");
            }
        }
        public static void CreateTrainer(List<Trainer> TrainerList)
        {
            Console.Clear();
            Console.Write("Enter Trainer's first Name: ");
            var firstNameInput = Console.ReadLine();
            Console.Write("Enter Trainer's last Name: ");
            var lastNameInput = Console.ReadLine();
            Console.Write("Enter subject: ");
            var subjectInput = Console.ReadLine();

            var newTrainer = new Trainer(firstNameInput, lastNameInput, subjectInput);
            TrainerList.Add(newTrainer);
        }
    }
}
