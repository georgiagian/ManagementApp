using ProjectPartA.HelperClasses.PairInputDates;
using ProjectPartA.Repositories.RepositoryMyEntities;
using ProjectPartA.View.ViewMenus;
using ProjectPartA.View.ViewTablesOfData;
using System;

namespace ProjectPartA.Controllers.ControllerSynthetics
{
    public class ControllerSynthetic
    {
        RepositoryMyEntity rme = new RepositoryMyEntity();

        public void PrintSyntheticData()
        {
            string option;
            do
            {
                ViewInsideMenu.PrintInsideMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 10");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": ViewTables.PrintCourses(rme.GetCourses()); break;
                    case "2": ViewTables.PrintTrainers(rme.GetTrainers()); break;
                    case "3": ViewTables.PrintStudents(rme.GetStudents()); break;
                    case "4": ViewTables.PrintAssignments(rme.GetAssignments()); break;
                    case "5": ViewTables.PrintTrainersPerCourse(rme.GetCourses()); break;
                    case "6": ViewTables.PrintStudentsPerCourse(rme.GetCourses()); break;
                    case "7": ViewTables.PrintAssignmentsPerCourse(rme.GetCourses()); break;
                    case "8": ViewTables.PrintAssignmentsPerStudent(rme.GetStudents()); break;
                    case "9": ViewTables.PrintAStudentWithMultiCourses(rme.GetStudents()); break;
                    case "10": ViewTables.PrintStudentsToReturnAssignment(rme.GetAssignments()); break;
                    case "E": Console.Clear(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 10"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
            } while (option != "E");
        }
    }
}
