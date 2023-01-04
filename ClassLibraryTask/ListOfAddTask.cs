using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
    internal class ListOfAddTask<T>
    {
        private List<T> addition_tasks = new List<T>();

        public List<T> Addition_tasks { get { return addition_tasks; } set { } }

        
    }
}
