using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.OldModels.Planner
{
    public class UniversityPlanner : Planner
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override TasksClass<TaskClass> Tasks { get; set; }
        public TasksClass<TaskClass> TasksImportant { get; set; }


        public UniversityPlanner() { }

        public UniversityPlanner(string name, string description, TasksClass<TaskClass> tasks, TasksClass<TaskClass> tasksImportant)
        {
            Random rnd = new Random();
            ID = rnd.Next(100);
            Name = name;
            Description = description;
            Tasks = tasks;
            TasksImportant = tasksImportant;
        }

        public UniversityPlanner(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"University planner\nName: {Name}\nDescription: {Description}";
        }
    }
}
