using ProjectPartA.Core.Entities;
using ProjectPartA.Validations;
using System;

namespace ProjectPartA.View.ViewCreateEntities
{
    public class ViewCreateStudent
    {
        public Student PrintCreateNewStudent()
        {
            string firstName = UserInputFirstName();

            string lastName = UserInputLastName();

            DateTime dateOfBirth;
            do
            {
                dateOfBirth = UserInputDateOfBirth();
            } while (dateOfBirth.Year > DateTime.Now.Year - 18 || dateOfBirth.Year < DateTime.Now.Year - 80);

            int tuitionFees;
            do
            {
                tuitionFees = UserInputTuitionFees();
            } while (tuitionFees < 0 || tuitionFees > 10000);

            Student student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                TuitionFees = tuitionFees
            };

            return student;
        }

        private string UserInputFirstName()
        {
            string firstNameInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Student First Name");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("First Name Contain be only letters");
                Console.ResetColor();
                firstNameInput = Console.ReadLine();
            } while (!Validation.IsProperFirstName(firstNameInput));

            return firstNameInput[0].ToString().ToUpper() + firstNameInput.Substring(1).ToLower();
        }

        private string UserInputLastName()
        {
            string lastNameInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Student Last Name");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Last Name Contain be only letters");
                Console.ResetColor();
                lastNameInput = Console.ReadLine();
            } while (!Validation.IsProperLastName(lastNameInput));

            return lastNameInput[0].ToString().ToUpper() + lastNameInput.Substring(1).ToLower();
        }

        private DateTime UserInputDateOfBirth()
        {
            string dateOfBirth;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Student Date of Birth");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Student cannot be lower than 18 years old or older than 80");
                Console.ResetColor();
                dateOfBirth = Console.ReadLine();
            } while (!Validation.IsProperDate(dateOfBirth));

            return Convert.ToDateTime(dateOfBirth);
        }

        private int UserInputTuitionFees()
        {
            string tuitionFeesInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Tuition Fees of Student");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fees must be from 0 to 10000");
                Console.ResetColor();
                tuitionFeesInput = Console.ReadLine();
            } while (!Validation.IsProperNumber(tuitionFeesInput));
            int tuitionFees = Convert.ToInt32(tuitionFeesInput);
            return tuitionFees;
        }
    }
}
