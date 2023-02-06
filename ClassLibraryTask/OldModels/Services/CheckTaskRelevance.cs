using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.OldModels
{
    internal class CheckTaskRelevance
    {
        public DateTime Deadline { get; set; }

        public delegate void MyDelegate(string msg);

        public void CheckDate()
        {
            DateTime today = DateTime.Today;

            MyDelegate PrintMessageDelegate = (string msg) => Console.WriteLine(msg);

            if (today > Deadline)
            {
                PrintMessageDelegate("You missed the deadline");
            }
            else
            {
                PrintMessageDelegate($"It's okay, you still have {GetDayToDeadline()} day(s) until the deadline");
            }
        }


        public double GetDayToDeadline()
        {
            DateTime today = DateTime.Today;
            return (Deadline - today).TotalDays;
        }
    }
}
