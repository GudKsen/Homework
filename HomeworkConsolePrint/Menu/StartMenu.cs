using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsolePrint.Menu
{
    internal class StartMenu
    {
        public PlannerMenu mainMenu = new PlannerMenu();
        public TasksMenu tasksMenu = new TasksMenu();
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
                .Title("Choose planner:")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                .AddChoices(new[] {
                "University planner", "Holiday planner", "None", "Exit"
            }));

            switch (Option)
            {
                case "University planner":
                    mainMenu.TypeOfPlanner = "university";
                    mainMenu.MenuLoop("university");
                    break;

                case "Holiday planner":
                    mainMenu.TypeOfPlanner = "holiday";
                    mainMenu.MenuLoop("holiday");
                    break;

                case "None":
                    tasksMenu.MenuLoop();
                    break;

                case "Exit":
                    return false;
            }

            return true;
        }
    }
}
