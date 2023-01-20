using System;
using System.Collections.Generic;
//using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ClassLibraryTask;
using ClassLibraryTask.Models;
//using ConsoleApp.Repository;

namespace ClassLibrary
{
    internal class DisplayTextFile : IDisplay
    {
        public void PrintToTextFile(TasksClass<TaskClass> tasks)
        {
            //Console.WriteLine("Serialize, xml----------------------------------------------");
            
            //Stream fs = new FileStream("D:\\Lesson\\hw3.xml", FileMode.Create);
            //Serialize<List<TaskClass>> s = new Serialize<List<TaskClass>>();

            //s.SerializeXML(fs, tasks.Tasks);

            //Console.WriteLine("------------------------------------------------------------\n");



            Console.WriteLine("Deserialize, xml--------------------------------------------");
            

            using (StreamWriter writetext = new StreamWriter("D:\\Lesson\\hw3.txt"))
            {
                for (int i = 0; i < arr.Tasks.Count; i++)
                {
                    writetext.WriteLine(arr.Tasks[i].ToString());
                }
            }

            Console.WriteLine("------------------------------------------------------------\n");
        }
    }
}
