using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassLibraryTask
{

    public delegate int MyDelegate(string s);

    abstract class DodTask
    {
        private int Max_mark_for_task = 100;
        private int Current_mark_for_task;

        int id;
        public int ID { get => id; set => id = value; }

        public int MAX_MARK { get { return Max_mark_for_task; } }
        public int Current_mark;

        public abstract void GetResult();

        

    }

}
