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
        public static void ShowingOption(List<TaskClass> tasks, List<TheoryClass> theoriesTasks) {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine(tasks[i]);
                if (tasks[i].type == TypeTask.Theory)
                {
                    Console.Write("\t");
                    Console.WriteLine(theoriesTasks.Find(x => x.ID == tasks[i].ID));
                }
            }
        }
    }
}
