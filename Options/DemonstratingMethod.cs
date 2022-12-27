using ClassLibraryTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class DemonstratingMethod
    {
        public static void DemMethod(List<TaskClass> tasks)
        {
            foreach (TaskClass task in tasks)
            {
                string str = task.GetDaysLeft;
                Console.WriteLine(str);
            }
           
        }
    }
}
