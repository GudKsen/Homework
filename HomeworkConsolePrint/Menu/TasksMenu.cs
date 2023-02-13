using HomeworkConsolePrint.ReadConsole;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsolePrint.Menu
{
    internal class TasksMenu
    {
        //EnterData m = new EnterData();
        EnterDataTasks m = new EnterDataTasks();
        ConvertMenu cm = new ConvertMenu();

        internal void MenuLoop()
        {
            bool isLoop = true;
            do
            {
                isLoop = Menu();
            } while (isLoop == true);

        }

        private bool Menu()
        {
            var Option = AnsiConsole.Prompt(
               new SelectionPrompt<string>()
               .Title("Choose an activity with tasks:")
               .PageSize(10)
               .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
               .AddChoices(new[] {
                "Add", "Print", "Find", "Delete", "Sort", "Convert", "Group by deadlines", "Exit"
           }));
            //int option;
            
            //Console.WriteLine("1 - add object\n" +
            //    "2 - print object\n" +
            //    "3 - find object\n" +
            //    "4 - delete object\n" +
            //    "5 - demonstration of the behavior of objects\n" +
            //    "6 - check if task actual\n" +
            //    "7 - sort all tasks by name\n" +
            //    "8 - convert data\n" +
            //    //"9 - convert data to JSON\n" +
            //    //"10 - convert data from XML" +
            //    //"11 - convert data from JSON" +
            //    //"12 - go to menu for additional tasks\n" +
            //    "0 - exit\n");

            //Console.Write("Option: ");
            //string? optionStr = Console.ReadLine();

            //while (!int.TryParse(optionStr, out option))
            //{
            //    Console.WriteLine("Invalid input: invalid option");
            //    if (!int.TryParse(optionStr, out option))
            //    {
            //        Console.Write("Option: ");
            //        optionStr = Console.ReadLine();
            //    }
            //}

            

            switch (Option)
            {
                case "Add":
                    m.EnterDataAdd();
                    break;

                case "Print":
                    m.ShowData();
                    break;

                case "Find":
                    m.EnterDataForSearch();
                    break;

                case "Delete":
                    m.EnterDataForDelete();
                    break;

                //case "":
                //    m.DemDataMeth();
                //    break;

                //case 6:
                //    m.PrintIsTaskActual();
                //    break;

                case "Sort":
                    m.Sort_Tasks();
                    break;

                case "Convert":
                    cm.dataTasks = m;
                    cm.MenuLoop();
                    break;

                case "Group by deadlines":
                    m.GrpBy();
                    break;
                //case 9:
                //    m.Convert_To_Json();
                //    break;

                //case 10:
                //    m.ConvertFromXml();
                //    break;

                //case 11:
                //    m.ConvertFromJson();
                //    break;

                case "Exit":
                    return false;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            return true;
        }
    }
}
