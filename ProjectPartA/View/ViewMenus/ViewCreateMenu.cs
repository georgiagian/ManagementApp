using System;

namespace ProjectPartA.View.ViewMenus
{
    public static class ViewCreateMenu
    {
        public static void PrintCreationMenu()
        {
            Console.WriteLine("1: Create new Course");
            Console.WriteLine("2: Create new Trainer");
            Console.WriteLine("3: Create new Student");
            Console.WriteLine("4: Create new Assignment");
            Console.WriteLine("5: Match Trainers per Course");
            Console.WriteLine("6: Match Students per Course");
            Console.WriteLine("7: Match Assignments per Course");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("E: Press 'E' to go to Back");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Entites has to be created in order to be able to match them.");
        }
    }
}
