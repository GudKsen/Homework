using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.Models
{
    public class MenuOptAddtionalTasks
    {
        ListOfAddTask<LaboratoryProjectClass> tasks;
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
    }
}
