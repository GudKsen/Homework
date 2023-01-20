using System;
using ClassLibraryTask;
using ClassLibraryTask.Models;

namespace ClassLibrary
{
    internal class DisplayConsole : IDisplay
    {

        Serialize<TaskClass> s = new Serialize<TaskClass>();
        public void PrintToCnsole(TasksClass<TaskClass> tasks)
        {
            for (int i = 0; i < tasks.Tasks.Count; i++)
            {
                Console.WriteLine("Serialize, json--------------------------------------------------");
                string jsonString = s.SerializeJSON(tasks.Tasks[i]);
                Console.WriteLine(jsonString);
                Console.WriteLine("-----------------------------------------------------------------\n");

                Console.WriteLine("Deserialize, json------------------------------------------------");
                var weatherForecast = s.DeserializeJSON(jsonString);
                Console.WriteLine(weatherForecast);
                Console.WriteLine("-----------------------------------------------------------------\n");
            }
        }
    }
}
