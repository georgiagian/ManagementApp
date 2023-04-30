using ProjectPartA.Core.Entities;
using ProjectPartA.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectPartA.View.ViewPairEntities
{
    public class ViewPairCourseAssignments
    {
        public int ChooseCourseToMatch(List<Course> courses)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"FIRST NAME",space}{"LAST NAME",space}{"DATE OF BIRTH",space}{"TUITION FEES",space}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id,space}{course.Title,space}{course.Stream,space}{course.Type,space}{course.StartDate.ToShortDateString(),space}{course.EndDate.ToShortDateString(),space}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose a course by Id, that you want to add students to.");
            Console.ResetColor();
            string courseChoice;
            do
            {
                courseChoice = Console.ReadLine();
            } while (!Validation.IsProperNumber(courseChoice) || !Enumerable.Range(1, courses.Count).Contains(Convert.ToInt32(courseChoice)));
            return Convert.ToInt32(courseChoice);
        }

        public List<int> ChooseAssignmentsToAddToCourse(List<Assignment> assignments)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"TITLE",space}{"DESCRIPTION",space}{"SUB DATE TIME",space + 10}{"ORAL MARK",space + 15}{"TOTAL MARK",space}");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Id,space}{assignment.Title,space}{assignment.Description,space}{assignment.SubDateTime.ToShortDateString(),space + 10}{assignment.OralMark,space + 15}{assignment.TotalMark,space}");
            }
            Console.WriteLine();
            Console.WriteLine($"Choose the space seperated assignments by Id, that you want to add to this course");
            Console.ResetColor();
            string assignmentsChoice;
            do
            {
                assignmentsChoice = Console.ReadLine();
            } while (!Validation.IsProperSpaceSeperatedNumbers(assignmentsChoice) || !assignmentsChoice.All(x => Enumerable.Range(0, assignments.Count + 1).Contains(x - 48) || x == 32));
            List<int> assignmentsList = Regex.Replace(assignmentsChoice, @"\s{2,}", " ").Trim().Split().Where(w => Enumerable.Range(0, assignments.Count + 1).Contains(Convert.ToInt32(w))).Select(x => Convert.ToInt32(x)).ToList();
            return assignmentsList;
        }
    }
}
