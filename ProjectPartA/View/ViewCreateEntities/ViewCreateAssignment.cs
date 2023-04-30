using ProjectPartA.Core.Entities;
using ProjectPartA.Validations;
using System;

namespace ProjectPartA.View.ViewCreateEntities
{
    public class ViewCreateAssignment
    {
        public Assignment PrintCreateNewAssignment()
        {
            string title = UserInputTitle();

            string description = UserInputDescription();

            DateTime subDateTime;
            do
            {
                subDateTime = UserInputSubDateTime();
            } while (subDateTime < DateTime.Now);

            int oralMark;
            do
            {
                oralMark = UserInputOralMark();
            } while (oralMark < 0 || oralMark > 100);

            int totalMark;
            do
            {
                totalMark = UserInputTotalMark();
            } while (oralMark < 0 || oralMark > 100 || totalMark < oralMark);

            Assignment assignment = new Assignment()
            {
                Title = title,
                Description = description,
                SubDateTime = subDateTime,
                OralMark = oralMark,
                TotalMark = totalMark
            };

            return assignment;
        }

        private string UserInputTitle()
        {
            string titleInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Assignment Title");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Title can contain letters-digits-symbols.");
                Console.ResetColor();
                titleInput = Console.ReadLine();
            } while (!Validation.IsProperTitleOrSubject(titleInput));

            return titleInput;
        }

        private string UserInputDescription()
        {
            string descriptionInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Assignment Description");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Description can contain letters-digits-symbols.");
                Console.ResetColor();
                descriptionInput = Console.ReadLine();
            } while (!Validation.IsProperTitleOrSubject(descriptionInput));

            return descriptionInput;
        }

        private DateTime UserInputSubDateTime()
        {
            string subDateTime;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Sub Date Time");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Assignment sub date time can NOT be in the past");
                Console.ResetColor();
                subDateTime = Console.ReadLine();
            } while (!Validation.IsProperDate(subDateTime));

            return Convert.ToDateTime(subDateTime);
        }

        private int UserInputOralMark()
        {
            string oralMarkInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Assignment Oral Mark");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Oral Mark must be from 0 to 100");
                Console.ResetColor();
                oralMarkInput = Console.ReadLine();
            } while (!Validation.IsProperNumber(oralMarkInput));
            int oralMark = Convert.ToInt32(oralMarkInput);
            return oralMark;
        }

        private int UserInputTotalMark()
        {
            string totalMarkInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Assignment Total Mark");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Oral Mark must be from 0 to 100 BUT LOWER OR EQUAL THAN Oral Mark");
                Console.ResetColor();
                totalMarkInput = Console.ReadLine();
            } while (!Validation.IsProperNumber(totalMarkInput));
            int totalMark = Convert.ToInt32(totalMarkInput);
            return totalMark;
        }
    }
}
