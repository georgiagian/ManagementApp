using ProjectPartA.Core.Entities;
using ProjectPartA.Core.Enums;
using ProjectPartA.Validations;
using System;

namespace ProjectPartA.View.ViewCreateEntities
{
    public class ViewCreateCourse
    {
        public Course PrintCreateNewCourse()
        {
            string title = UserInputTitle();

            string stream = UserInputStream();

            CourseType type = UserInputType();

            DateTime startDate;
            do
            {
                startDate = UserInputStartDate();
            } while (startDate < DateTime.Now);

            DateTime endDate;
            do
            {
                endDate = UserInputEndDate();
            } while (startDate > endDate);

            Course course = new Course()
            {
                Title = title,
                Stream = stream,
                Type = type,
                StartDate = startDate,
                EndDate = endDate
            };

            return course;
        }

        private string UserInputTitle()
        {
            string titleInput;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Course Title");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Name can contain letters-digits-symbols.");
                Console.ResetColor();
                titleInput = Console.ReadLine();
            } while (!Validation.IsProperTitleOrSubject(titleInput));

            return titleInput;
        }

        private string UserInputStream()
        {
            string stream;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Course Stream");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Stream must be from CB-8 to CB-15, at this format.");
                Console.ResetColor();
                stream = Console.ReadLine();
            } while (!Validation.IsProperStream(stream));

            return stream;
        }

        private CourseType UserInputType()
        {
            string[] types = Enum.GetNames(typeof(CourseType));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Course Type");
            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {types[i]}");
            }
            string typeChoice;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You must choose 1 or 2 option");
                Console.ResetColor();
                typeChoice = Console.ReadLine();
            } while (!Validation.IsProperType(typeChoice));
            CourseType type = (CourseType)Convert.ToInt32(typeChoice);

            return type;
        }

        private DateTime UserInputStartDate()
        {
            string startDate;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Starting Date of Course");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Start Date can NOT be in the past! Format: ex.25-12-2022");
                Console.ResetColor();
                startDate = Console.ReadLine();
            } while (!Validation.IsProperDate(startDate));

            return Convert.ToDateTime(startDate);
        }

        private DateTime UserInputEndDate()
        {
            string endDate;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Ending Date of Course");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("End Date must be after Start Date! Format: 30-12-2022");
                Console.ResetColor();
                endDate = Console.ReadLine();
            } while (!Validation.IsProperDate(endDate));

            return Convert.ToDateTime(endDate);
        }
    }
}
