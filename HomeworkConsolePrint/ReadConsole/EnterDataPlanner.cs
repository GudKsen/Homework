using ClassLibraryTask;
using ClassLibraryTask.OldModels.Planner;
using ClassLibraryTask.OldModels.Validation;
using HomeworkConsolePrint.Service;
using ValidationData;

namespace HomeworkConsolePrint.ReadConsole
{
    internal class EnterDataPlanner
    {
        public ServicePlanner sp = new ServicePlanner();
        public ServiceTasks serviceTasks;
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

            sp.CreatePlanner(type, name, description);

            //if (type == "university")
            //{
            //    Planner planner = new UniversityPlanner(name, description);
            //}
            //else
            //{
            //    Planner planner = new HolidayPlanner(name, description);
            //}
            
        }

        public void PrintingData (string type)
        {
            
            Console.WriteLine();
        }

        public void EditingData ()
        {

        }

        public void DeletingData ()
        {

        }

        public void AddTask()
        {
            
        }

        public void DeleteTaskByID()
        {
            
        }

       
    }
}
