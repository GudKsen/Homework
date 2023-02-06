using HomeworkConsolePrint.ReadConsole;
using Spectre.Console;

namespace HomeworkConsolePrint.Menu
{
    internal class PlannerMenu
    {
        public string TypeOfPlanner;
        public TasksMenu tasksMenu = new TasksMenu();
        public EnterDataPlanner dataPlanner  = new EnterDataPlanner();
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
                .Title("Choose option:")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                .AddChoices(new[] {
                "New planner", "Print planner", "Edit planner", "Delete planner", "Go to task menu", "Exit"
            }));

            switch (Option)
            {
                case "New planner":
                    Console.Clear();
                    dataPlanner.CreationData(type);
                    break;

                case "Print planner":
                    Console.Clear();
                    dataPlanner.PrintingData(type);
                    break;

                case "Edit planner":
                    Console.Clear();
                    dataPlanner.EditingData();
                    break;

                case "Delete planer":
                    Console.Clear();
                    dataPlanner.DeletingData();
                    break;

                case "Go to task menu":
                    Console.Clear();
                    tasksMenu.MenuLoop();
                    break;

                case "Exit":
                    return false;
            }

            return true;
        }
    }
}
