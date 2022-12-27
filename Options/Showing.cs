using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask;
using Theory;

namespace Options
{
    public class Showing
    {
        public static void ShowingOption(List<TaskClass> tasks) {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }
    }
}
