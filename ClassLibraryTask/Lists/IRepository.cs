using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
    public interface IRepository<T>
    {
        void Add(T task);
        void DeleteByID(int id);
        void DeleteByName(string name_delete);
        T SearchByID(int id);
        T SearchByName(string name_search);
        List<T> GetAll();
    }
}
