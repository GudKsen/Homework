using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.Models
{
    public class MenuOptAddtionalTasks
    {
        private ListOfAddTask<LaboratoryProjectClass> tasks = new ListOfAddTask<LaboratoryProjectClass>();
        //public ListOfAddTask<LaboratoryProjectClass> Tasks { get { return tasks; } }

        public void add(int max_mark)
        {
            tasks.Add(new LaboratoryProjectClass(max_mark));
        }

        public void check(int id, int mark)
        {
            LaboratoryProjectClass t = tasks.Find(id);
            if (t != null)
            {
                t.printActionDel(mark);
            }
        }

        public void show()
        {
            for (int i = 0; i < tasks.Addition_tasks.Count; i++)
            {
                Console.WriteLine(tasks.Addition_tasks[i]);
            }
        }
       
    }
}
