using ClassLibraryTask;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsolePrint
{
    public class Menu
    {
        MenuData m = new MenuData();
        private int counter_of_adding_el = 0;
        internal void menuLoop(int N)
        {
            bool isLoop = true;
            do
            {
                isLoop = menu(N);
            } while (isLoop == true);
            
        }

        private bool menu(int N)
        {
            int option;
            Console.WriteLine("\n---------------------------------------------");

            Console.WriteLine("1 - add object\n" +
                "2 - print object\n" +
                "3 - find object\n" +
                "4 - delete object\n" +
                "5 - demonstration of the behavior of objects\n" +
                "6 - check if task actual\n" +
                "7 - sort all tasks by name\n" +
                "8 - go to menu for additional tasks\n" +
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
                        m.EnterDataAdd();
                        counter_of_adding_el++;
                    }
                    else
                    {
                        Console.WriteLine("You can't add element");
                    }
                    break;

                case 2:
                    m.ShowData();
                    break;

                case 3:
                    m.EnterDataForSearch();
                    break;

                case 4:
                    m.EnterDataForDelete();
                    break;

                case 5:
                    m.DemDataMeth();
                    break;

                case 6:
                    m.PrintIsTaskActual();
                    break;

                case 7:
                    m.Sort_Tasks();
                    break;

                case 8:

                    break;

                case 0:
                    return false;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            return true;
        }


        void menu_additional_tasks()
        {
            Console.WriteLine("1 - add laboratory work\n" +
                "2 - delete laboratory work\n" +
                "3 - find laboratory work\n" +
                "4 - check if you have passed the task" +
                "click any key to exit\n");

            string? choice = Console.ReadLine();

            if (choice != null)
            {
                switch(choice)
                {
                    case "1":

                        break;
                }
            }
        }
    }
}
