using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
    internal interface IRepository<T>
    {
        void Add(T task);
        void Delete(int id);
        T Find(int id);

    }
}
