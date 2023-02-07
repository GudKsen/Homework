using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.OldModels.Planner
{
    public abstract class Planner
    {
        public abstract int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual TasksClass<TaskClass> Tasks { get; set; }

        public Planner() { }
        public Planner (string name, string description) { }

    }
}
