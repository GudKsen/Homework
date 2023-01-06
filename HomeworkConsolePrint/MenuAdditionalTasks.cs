using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask;
using ClassLibraryTask.Models;

namespace HomeworkConsolePrint
{
    internal class MenuAdditionalTasks
    {
        
        private MenuOptAddtionalTasks t = new MenuOptAddtionalTasks(); 
        public void add_l()
        {
            Console.Write("Enter max mark for task: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            t.add(mark);
        }

        public void check_mark_l()
        {
            Console.Write("Enter ID of task: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            t.check(id, mark);
        }

        public void show()
        {
            t.show();
        }
    }
}
