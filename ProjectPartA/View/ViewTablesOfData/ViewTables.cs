using ProjectPartA.Core.Entities;
using ProjectPartA.HelperClasses.PairInputDates;
using System;
using System.Collections.Generic;

namespace ProjectPartA.View.ViewTablesOfData
{
    public static class ViewTables
    {
        public static void PrintCourses(List<Course> courses)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------ALL COURSES-----------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"TITLE",space}{"STREAM",space}{"TYPE",space}{"START DATE",space}{"END DATE",space}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Title,space}{course.Stream,space}{course.Type,space}{course.StartDate.ToShortDateString(),space}{course.EndDate.ToShortDateString(),space}");
            }
        }

        public static void PrintTrainers(List<Trainer> trainers)
        {
            const int space = -25;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------ALL TRAINERS------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"FIRST NAME",space}{"LAST NAME",space}{"SUBJECT",space}");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.FirstName,space}{trainer.LastName,space}{trainer.Subject,space}");
            }
        }

        public static void PrintStudents(List<Student> students)
        {
            const int space = -25;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------------ALL STUDENTS--------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"FIRST NAME",space}{"LAST NAME",space}{"DATE OF BIRTH",space}{"TUITION FEES",space}");
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName,space}{student.LastName,space}{student.DateOfBirth.ToShortDateString(),space}{student.TuitionFees,space}");
            }
        }

        public static void PrintAssignments(List<Assignment> assignments)
        {
            const int space = -35;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------ALL ASSIGNMENTS----------------------------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"TITLE",space}{"DESCRIPTION",space}{"SUB DATE TIME",space + 10}{"ORAL MARK",space + 15}{"TOTAL MARK",space}");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Title,space}{assignment.Description,space}{assignment.SubDateTime.ToShortDateString(),space + 10}{assignment.OralMark,space + 15}{assignment.TotalMark,space}");
            }
        }

        public static void PrintTrainersPerCourse(List<Course> courses)
        {
            const int space = -10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------ALL TRAINERS PER COURSE--------------");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{"COURSE:"} {course.Title} - {course.Stream} - {course.Type}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{"",space} {"FIRST NAME",space - 5} {"LAST NAME",space - 5} {"SUBJECT"}");
                Console.ResetColor();
                foreach (var trainer in course.Trainers)
                {
                    Console.WriteLine($"{"TRAINER:",space} {trainer.FirstName,space - 5} {trainer.LastName,space - 5} {trainer.Subject}");
                }
                Console.WriteLine("\n");
            }
        }

        public static void PrintStudentsPerCourse(List<Course> courses)
        {
            const int space = -10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------ALL STUDENTS PER COURSE-----------------");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{"COURSE:"} {course.Title} - {course.Stream} - {course.Type}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{"",space} {"FIRST NAME",space - 5} {"LAST NAME",space - 5} {"DATE OF BIRTH"}");
                Console.ResetColor();
                foreach (var student in course.Students)
                {
                    Console.WriteLine($"{"STUDENT:",space} {student.FirstName,space - 5} {student.LastName,space - 5} {student.DateOfBirth.ToShortDateString()}");
                }
                Console.WriteLine("\n");
            }
        }

        public static void PrintAssignmentsPerCourse(List<Course> courses)
        {
            const int space = -25;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------ALL ASSIGNMENTS PER COURSE-------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{"COURSE:"} {course.Title} - {course.Stream} - {course.Type}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{"",space + 10} {"TITLE",space} {"DESCRIPTION",space - 5} {"SUB DATE TIME"}");
                Console.ResetColor();
                foreach (var assignment in course.Assignments)
                {
                    Console.WriteLine($"{"ASSIGNMENT:",space + 10} {assignment.Title,space} {assignment.Description,space - 5} {assignment.SubDateTime.ToShortDateString()}");
                }
                Console.WriteLine("\n");
            }
        }

        public static void PrintAssignmentsPerStudent(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------ALL ASSIGNMENTS PER STUDENT-------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(student.FirstName + " " + student.LastName);
                Console.ResetColor();
                foreach (var course in student.Courses)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(course.Title + "|" + course.Stream);
                    Console.ResetColor();
                    foreach (var assignment in course.Assignments)
                    {
                        Console.Write(assignment.Title + ", ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static void PrintAStudentWithMultiCourses(List<Student> students)
        {
            const int space = -25;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------ALL STUDENTS WITH MULTIPLE COURSES-------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var student in students)
            {
                if (student.Courses.Count > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{"STUDENT:"} {student.FirstName} {student.LastName} - {student.DateOfBirth.ToShortDateString()}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{"",space + 10} {"TITLE",space} {"DESCRIPTION",space} {"SUB DATE TIME"}");
                    Console.ResetColor();
                    foreach (var course in student.Courses)
                    {
                        Console.WriteLine($"{"Course:",space + 10} {course.Title,space} {course.Stream,space} {course.Type}");
                    }
                    Console.WriteLine();
                }

            }
        }

        public static void PrintStudentsToReturnAssignment(List<Assignment> assignments)
        {
            DateTime choice = PairInputDateHelperCls.AskInputDate();
            List<int> calendarweek = PairInputDateHelperCls.MatchInputDateTime(choice);

            int count = 0;
            foreach (var assignment in assignments)
            {
                foreach (var d in calendarweek)
                {
                    if (assignment.SubDateTime.DayOfYear == d)
                    {
                        count++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"--------------------ALL STUDENTS WHO NEED TO SUB {assignment.Title}-------------------");
                        Console.WriteLine();
                        Console.ResetColor();
                        foreach (var student in assignment.Course.Students)
                        {
                            Console.WriteLine($"This week {student.FirstName} {student.LastName} needs to Sub his assignment with Title: {assignment.Title}");
                            Console.WriteLine();
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"No Students need to Sub an Assignment on {choice.ToShortDateString()}.");
            }
        }
    }
}
