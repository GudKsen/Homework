using HomeworkConsolePrint.Menu;

namespace HomeworkConsolePrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.MenuLoop();
        }
    }
}