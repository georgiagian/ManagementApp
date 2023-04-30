using ProjectPartA.Core.Entities;
using ProjectPartA.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectPartA.View.ViewPairEntities
{
    public class ViewPairCoursesTrainers
    {
        public int ChooseCourseToMatch(List<Course> courses)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"TITLE",space}{"STREAM",space}{"TYPE",space}{"START DATE",space}{"END DATE",space}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id,space}{course.Title,space}{course.Stream,space}{course.Type,space}{course.StartDate.ToShortDateString(),space}{course.EndDate.ToShortDateString(),space}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose a course by Id, that you want to add trainers to.");
            Console.ResetColor();
            string courseChoice;
            do
            {
                courseChoice = Console.ReadLine();
            } while (!Validation.IsProperNumber(courseChoice) || !Enumerable.Range(1, courses.Count).Contains(Convert.ToInt32(courseChoice)));
            return Convert.ToInt32(courseChoice);
        }

        public List<int> ChooseTrainersToAddToCourse(List<Trainer> trainers)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"FIRST NAME",space}{"LAST NAME",space}{"SUBJECT",space}");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Id,space}{trainer.FirstName,space}{trainer.LastName,space}{trainer.Subject,space}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Choose the space seperated trainers by Id, that you want to add to this course");
            Console.ResetColor();
            string trainersChoice;
            do
            {
                trainersChoice = Console.ReadLine();
            } while (!Validation.IsProperSpaceSeperatedNumbers(trainersChoice) || !trainersChoice.All(x => Enumerable.Range(0, trainers.Count + 1).Contains(x - 48) || x == 32));
            List<int> trainersList = Regex.Replace(trainersChoice, @"\s{2,}", " ").Trim().Split().Where(w=> Enumerable.Range(0, trainers.Count + 1).Contains(Convert.ToInt32(w))).Select(x => Convert.ToInt32(x)).ToList();
            return trainersList;
        }
    }
}
