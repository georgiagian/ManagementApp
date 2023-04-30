using ProjectPartA.Controllers.ControllerInputs;
using ProjectPartA.Controllers.ControllerSynthetics;
using ProjectPartA.View.ViewMenus;
using System;

namespace ProjectPartA
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run();
        }
    }

    class Application
    {
        public static void Run()
        {
            ControllerSynthetic cs = new ControllerSynthetic();
            ControllerInput ci = new ControllerInput();
            string choice;
            do
            {
                Console.Clear();
                ViewMainMenu.PrintMainMenu();
                choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "1": Console.Clear(); cs.PrintSyntheticData(); break;
                    case "2": Console.Clear(); ci.PrintCreationData(); break;
                    case "3": Console.Clear(); ci.PrintInputedData(); break;
                    default: break;
                }
            } while (choice != "E");
        }
    }
}
