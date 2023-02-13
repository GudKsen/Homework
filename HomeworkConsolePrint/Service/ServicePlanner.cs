using ClassLibraryTask.OldModels.Planner;
using HomeworkConsolePrint.ReadConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsolePrint.Service
{
    internal class ServicePlanner
    {
        Planner planner { get; set; }
        public void CreatePlanner(string type, string name, string description)
        {
            if (type == "holiday")
            {
                planner = new HolidayPlanner(name, description);
                
            }
            else
            {
                planner = new UniversityPlanner(name, description);
                
            }
        }


    }
}
