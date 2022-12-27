using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Class1
    {
        public int ID;
        public string Name;
        public string Description;
        public DateTime StartDate;
        int type = (int)TypeTask.None;

        public override string ToString ()
        {
            return $"ID: {ID}\n Name: {Name}\n Description: {Description}\n Start Date: {StartDate}";
        }


    }
}
