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
                   
                    break;

                case "from XML":
                    
                    break;

                case "to JSON":
                    
                    break;

                case "from JSON":
                    break;

                case "Exit":
                    return false;
            }

            return true;
        }
    }
}
