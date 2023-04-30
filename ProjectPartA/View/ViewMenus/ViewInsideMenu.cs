using System;

namespace ProjectPartA.View.ViewMenus
{
    public static class ViewInsideMenu
    {
        public static void PrintInsideMenu()
        {
            Console.WriteLine("1: Show all Courses");
            Console.WriteLine("2: Show all Trainers");
            Console.WriteLine("3: Show all Students");
            Console.WriteLine("4: Show all Assignments");
            Console.WriteLine("5: Show all Trainers per Course");
            Console.WriteLine("6: Show all Students per Course");
            Console.WriteLine("7: Show all Assignments per Course");
            Console.WriteLine("8: Show all Assignments per Student");
            Console.WriteLine("9: Show all Students Belong to More than One Courses");
            Console.WriteLine("10: Enter Date to find Students who need to return Assignments at this calendar week.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("E: Press 'E' to go to Main Menu");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
