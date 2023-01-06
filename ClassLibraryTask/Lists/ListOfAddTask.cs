using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
    internal class ListOfAddTask<T> : IRepository<T> where T : DodTask
    {
        private List<T> addition_tasks = new List<T>();
        public event EventHandler<CustomEventArgs> ProcessCompleted;

        public List<T> Addition_tasks { get { return addition_tasks; } set { } }

        public void Add(T task)
        {
            addition_tasks.Add(task);
        }

        public void Delete(int id)
        {
            var data = new CustomEventArgs();
            try
            {
                T t = Find(id);
                addition_tasks.Remove(t);
                data.IsSuccess = true;
                data.Message = "Item successfully deleted";
            }
            catch (Exception e)
            {
                data.IsSuccess = false;
                data.Message = e.Message;
            }
        }

        public T Find(int id)
        {
            T t = addition_tasks.Find(x => x.ID == id);
            return t;
        }

        protected virtual void OnProcessCompletedCustom(CustomEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }

    }
}
