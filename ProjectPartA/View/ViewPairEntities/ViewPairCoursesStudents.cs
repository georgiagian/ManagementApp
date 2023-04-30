using ProjectPartA.Core.Entities;
using ProjectPartA.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectPartA.View.ViewPairEntities
{
    public class ViewPairCoursesStudents
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

        public List<int> ChooseStudentsToAddToCourse(List<Student> students)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"FIRST NAME",space}{"LAST NAME",space}{"DATE OF BIRTH",space}{"TUITION FEES",space}");
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id,space}{student.FirstName,space}{student.LastName,space}{student.DateOfBirth.ToShortDateString(),space}{student.TuitionFees,space}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Choose the space seperated students by Id, that you want to add to this course");
            Console.ResetColor();
            string studentsChoice;
            do
            {
                studentsChoice = Console.ReadLine();
            } while (!Validation.IsProperSpaceSeperatedNumbers(studentsChoice) || !studentsChoice.All(x => Enumerable.Range(0, students.Count + 1).Contains(x - 48) || x == 32));
            List<int> studentsList = Regex.Replace(studentsChoice, @"\s{2,}", " ").Trim().Split().Where(w => Enumerable.Range(0, students.Count + 1).Contains(Convert.ToInt32(w))).Select(x => Convert.ToInt32(x)).ToList();
            return studentsList;
        }
    }
}
