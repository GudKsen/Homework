using ClassLibraryTask;
using ClassLibraryTask.OldModels.Menu;
using ClassLibraryTask.OldModels.Planner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationData;

namespace HomeworkConsolePrint.ReadConsole
{
    internal class EnterDataPlanner
    {
        public MenuOptionsPlanner optionsPlanner = new MenuOptionsPlanner();
        public void CreationData (string type)
        {
            bool IsValid = false;

            Console.Write("Enter name: ");
            string? name = Console.ReadLine();

            while (IsValid != true)
            {
                IsValid = Valid.IsValidString(name);
                if (IsValid != true)
                {
                    Console.Write("Enter name: ");
                    name = Console.ReadLine();
                }
            }
            Console.Write("\n");

            Console.Write("Enter description: ");
            string? description = Console.ReadLine();
            IsValid = false;

            while (IsValid != true)
            {
                IsValid = Valid.IsValidText(description);
                if (IsValid != true)
                {
                    Console.Write("Enter description: ");
                    description = Console.ReadLine();
                }
            }
            Console.Write("\n");

            if (type == "university")
            {
                optionsPlanner.CreatePlanner(new UniversityPlanner(name, description), type);
            }
            else
            {
                optionsPlanner.CreatePlanner(new HolidayPlanner(name, description), type);
            }
            
        }

        public void PrintingData (string type)
        {
            optionsPlanner.ReadPlanner(type);
            Console.WriteLine();
        }

        public void EditingData ()
        {

        }

        public void DeletingData ()
        {

        }
    }
}
