using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryTask
{
    public class TasksClass<T> : IRepository<T> where T : TaskClass
    {
        private List<T> tasks = new List<T>();

        public List<T> Tasks { get { return tasks; } set { tasks = value; } }

        public event EventHandler<bool> ProcessCompleted;

        public void Add(T task)
        {
            try
            {
                tasks.Add(task);
                OnProcessCompleted(true);

            } catch (Exception)
            {
                OnProcessCompleted(false);
            }
            
        }

        protected virtual void OnProcessCompleted(bool isSuccess)
        {
            ProcessCompleted?.Invoke(this, isSuccess);
        }

       

        public void DeleteByID(int id_delete)
        {
            T item_to_remove = tasks.Find(x => x.ID == id_delete);

            if (item_to_remove != null)
            {
                tasks.Remove(item_to_remove);
                
            }
        }


        public void DeleteByName(string name_delete)
        {
            T item_to_remove = tasks.Find(x => x.Name == name_delete);

            if (item_to_remove != null)
            {
                tasks.Remove(item_to_remove);
            }
        }

        public T SearchByID(int id)
        {
            var data = new CustomEventArgs();

            
            TaskClass res_by_id = tasks.Find(x => x.ID == id);
            return (T)res_by_id;
           
            
        }

        public T SearchByName(string name_search)
        {
            TaskClass res_by_name = tasks.Find(x => x.Name == name_search);
            return (T)res_by_name;
        }

        public List<T> GetAll()
        {
            return tasks;
        }
    }
}
