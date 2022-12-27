using ClassLibraryTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Options;
using Theory;

namespace HomeworkConsolePrint
{
    public class Menu
    {
        internal static void menu(int N)
        {
            int option = 20;
            int counter_of_adding_el = 0;
            List<TaskClass> tasks = new List<TaskClass>();
            List<TheoryClass> theoriesTasks = new List<TheoryClass>();

            while (option != 0)
            {
                Console.WriteLine("\n---------------------------------------------");

                Console.WriteLine("1 - add object\n" +
                    "2 - print object\n" +
                    "3 - find object\n" +
                    "4 - delete object\n" +
                    "5 - demonstration of the behavior of objects\n" +
                    "0 - exit\n");

                Console.Write("Option: ");
                string? optionStr = Console.ReadLine();
                
                while (!int.TryParse(optionStr, out option))
                {
                    Console.WriteLine("Invalid input: invalid option");
                    if (!int.TryParse(optionStr, out option))
                    {
                        Console.Write("Option: ");
                        optionStr = Console.ReadLine();
                    }
                }

                Console.WriteLine("\n---------------------------------------------");

                switch (option)
                {
                    case 1:
                        if (counter_of_adding_el < N)
                        {
                            Adding.AddingOption(tasks, theoriesTasks);
                            counter_of_adding_el++;
                        }
                        else
                        {
                            Console.WriteLine("You can't add element");
                        }
                        break;

                    case 2:
                        Showing.ShowingOption(tasks, theoriesTasks);
                        break;

                    case 3:
                        Searching.SearchingOption(tasks);
                        break;

                    case 4:
                        Deleting.DeletingOption(tasks);
                        break;
                    case 5:
                        DemonstratingMethod.DemMethod(tasks);
                        break;
                }
            }
        }
    }
}
