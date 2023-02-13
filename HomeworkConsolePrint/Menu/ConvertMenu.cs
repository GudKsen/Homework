using HomeworkConsolePrint.ReadConsole;
using HomeworkConsolePrint.Service;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsolePrint.Menu
{
    internal class ConvertMenu
    {
        ServiceTasks serviceTasks = new ServiceTasks();
        public EnterDataTasks dataTasks { get; set; }
        internal void MenuLoop()
        {
            bool isLoop;
            do
            {
                isLoop = Menu();
            } while (isLoop == true);
        }

        private bool Menu()
        {
            var Option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Select convert:")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                .AddChoices(new[] {
                "to XML", "from XML", "to JSON", "from JSON", "Exit"
            }));

            switch (Option)
            {
                case "to XML":
                    dataTasks.Convert_To_Xml();
                    break;

                case "from XML":
                    dataTasks.ConvertFromXml();
                    break;

                case "to JSON":
                    dataTasks.Convert_To_Json();
                    break;

                case "from JSON":
                    dataTasks.ConvertFromJson();
                    break;

                case "Exit":
                    return false;
            }

            return true;
        }
    }
}
