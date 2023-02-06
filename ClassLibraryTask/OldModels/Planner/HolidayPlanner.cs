using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.OldModels.Planner
{
    public class HolidayPlanner : Planner
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override TasksClass<TaskClass> Tasks { get; set; }


        public HolidayPlanner() { }

        public HolidayPlanner(string NameOfPlanner, string DescriptionOfPlanner, TasksClass<TaskClass> TasksOfPlanner)
        {
            Random rnd = new Random();
            ID = rnd.Next(100);
            Name = NameOfPlanner;
            Description = DescriptionOfPlanner;
            Tasks = TasksOfPlanner;
        }

        public HolidayPlanner(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"Holiday planner\nName: {Name}\nDescription: {Description}";
        }
    }
}
