using HomeworkConsolePrint.ReadConsole;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsolePrint.Menu
{
    internal class PlannerTasksMenu
    {
        public EnterDataTasks et = new EnterDataTasks();
        public TasksMenu tasksMenu= new TasksMenu();
        internal void MenuLoop(string type)
        {
            bool isLoop;
            do
            {
                isLoop = Menu(type);
            } while (isLoop == true);
        }

        private bool Menu(string type)
        {
            var Option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Choose tasks:")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                .AddChoices(new[] {
                "Important tasks", "Tasks", "Exit"
            }));

            switch (Option)
            {
                case "Important tasks":
                    
                    break;

                case "Tasks":
                    
                    break;
                
                case "Exit":
                    return false;
            }

            return true;
        }
    }
}
