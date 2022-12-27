using ClassLibraryTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class Deleting
    {
        public static void DeletingOption(List<TaskClass> tasks)
        {
            Console.Write("Enter field for deleting (1 - ID, 2 - Name): ");

            string delete_field = Console.ReadLine();

            if (delete_field == "1")
            {
                Console.Write("Enter id for deleting object: ");

                int id_delete = Convert.ToInt32(Console.ReadLine());

                TaskClass item_to_remove = tasks.Find(x => x.ID == id_delete);

                if (item_to_remove != null)
                {
                    tasks.Remove(item_to_remove);
                    Console.WriteLine("Element deleted");
                }
            }
            else if (delete_field == "2")
            {
                Console.Write("Enter id for deleting object: ");

                string name_delete = Console.ReadLine();

                TaskClass item_to_remove = tasks.Find(x => x.Name == name_delete);

                if (item_to_remove != null)
                {
                    tasks.Remove(item_to_remove);
                    Console.Write("Element deleted");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
