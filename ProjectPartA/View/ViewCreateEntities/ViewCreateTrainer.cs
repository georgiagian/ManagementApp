using ProjectPartA.Core.Entities;
using ProjectPartA.Validations;
using System;

namespace ProjectPartA.View.ViewCreateEntities
{
    public class ViewCreateTrainer
    {
        public Trainer PrintCreateNewTrainer()
        {
            string firstName = UserInputFirstName();

            string lastName = UserInputLastName();

            string subject = UserInputSubject();

            Trainer trainer = new Trainer()
            {
                FirstName = firstName,
                LastName = lastName,
                Subject = subject
            };

            return trainer;
        }

        private string UserInputFirstName()
        {
            string firstNameInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Trainer FirstName");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Name Must be only letters");
                Console.ResetColor();
                firstNameInput = Console.ReadLine();
            } while (!Validation.IsProperFirstName(firstNameInput));

            return firstNameInput;
        }

        private string UserInputLastName()
        {
            string lastNameInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Trainer LastName");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Name Must be only letters");
                Console.ResetColor();
                lastNameInput = Console.ReadLine();
            } while (!Validation.IsProperLastName(lastNameInput));

            return lastNameInput;
        }

        private string UserInputSubject()
        {
            string subjectInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Trainer's Subject");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Trainer's Subject can contain anything");
                Console.ResetColor();
                subjectInput = Console.ReadLine();
            } while (!Validation.IsProperTitleOrSubject(subjectInput));

            return subjectInput;
        }
    }
}
