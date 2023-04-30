using System;

namespace ProjectPartA.View.ViewMenus
{
    public static class ViewMainMenu
    {
        public static void PrintMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Would you like to use Synthetic Data or Create your own Data?");
            Console.ResetColor();
            Console.WriteLine("Press 1 to View Synthetic Data");
            Console.WriteLine("Press 2 to Create Your Own Data");
            Console.WriteLine("Press 3 to View Your Own Data");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press 'E' to Exit Program");
            Console.ResetColor();
        }
    }
}
