using ClassLibraryTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class Searching
    {
        public static void SearchingOption(List<TaskClass> tasks) {
            Console.Write("Select the field for searching (1 - ID, 2 - name): ");

            string field = Console.ReadLine();

            if (field == null)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (field == "1")
            {
                Console.Write("Enter ID to find object: ");

                int id = Convert.ToInt32(Console.ReadLine());

                TaskClass res = tasks.Find(x => x.ID == id);
                Console.WriteLine(res);
            }
            else if (field == "2")
            {
                Console.Write("Enter name to find object: ");

                string name = Console.ReadLine();
                TaskClass e = new TaskClass();

                TaskClass res_by_name = tasks.Find(x => x.Name == name);
                Console.WriteLine(res_by_name);
            }
        }
    }
}
