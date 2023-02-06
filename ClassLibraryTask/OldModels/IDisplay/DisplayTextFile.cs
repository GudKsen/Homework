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
    public class DisplayTextFile<T> : IDisplay
    {
        public void PrintToTextFile(T variable)
        {
            var enumerable = variable as System.Collections.IEnumerable;

            using (StreamWriter writetext = new StreamWriter("D:\\Lesson\\hw3.txt"))
            {
                if (enumerable != null)
                {
                    foreach (var item in enumerable)
                    {
                        writetext.WriteLine(item);
                    }
                }
                else
                {
                    writetext.WriteLine(variable);
                }

                //for (int i = 0; i < arr.Tasks.Count; i++)
                //{
                //    writetext.WriteLine(arr.Tasks[i].ToString());
                //}
            }
        }
    }
}
