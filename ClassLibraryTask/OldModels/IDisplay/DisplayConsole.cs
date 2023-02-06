using System;
using System.Linq;
using ClassLibraryTask;
using ClassLibraryTask.Models;

namespace ClassLibrary
{
    public class DisplayConsole<T> : IDisplay
    {
        public void PrintToConsole(T tasks)
        {
            var enumerable = tasks as System.Collections.IEnumerable;
            if (enumerable != null && !(tasks is string))
            {
                foreach (var item in enumerable)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine(tasks);
            }
        }
    }
}
