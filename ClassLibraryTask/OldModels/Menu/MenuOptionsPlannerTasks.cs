using ClassLibraryTask.OldModels.Planner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.OldModels.Menu
{
    public class MenuOptionsPlannerTasks : MenuOptions
    {

        public new TasksClass<TaskClass> tt { get; set; }
        public MenuOptionsPlannerTasks() { }

        public MenuOptionsPlannerTasks(TasksClass<TaskClass> options)
        {

        }

        public override void AddTaskOption(string name, string description, string type, DateTime date)
        {
             base.AddTaskOption(name, description, type, date);
        }

    }
}
