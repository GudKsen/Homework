using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryTask
{
    internal class TasksClass<T> where T : TaskClass
    {
        private List<T> tasks = new List<T>();

        public List<T> Tasks { get { return tasks; } set { } }

        public event EventHandler<bool> ProcessCompleted;

        public void AddTask(T task)
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

        protected virtual void OnProcessCompletedCustom(bool isSuccess)
        {
            ProcessCompleted?.Invoke(this, isSuccess);
        }

        public void DeleteTaskByID(int id_delete)
        {
            T item_to_remove = tasks.Find(x => x.ID == id_delete);

            if (item_to_remove != null)
            {
                tasks.Remove(item_to_remove);
                
            }
        }


        public void DeleteTaskByName(string name_delete)
        {
            T item_to_remove = tasks.Find(x => x.Name == name_delete);

            if (item_to_remove != null)
            {
                tasks.Remove(item_to_remove);
            }
        }

        public TaskClass SearchByID(int id)
        {
            var data = new CustomEventArgs();

            //try
            //{
            TaskClass res_by_id = tasks.Find(x => x.ID == id);
            return res_by_id;
            //    data.IsSuccess = true;
            //    data.Message = "Item successfully finded";
            //    return res_by_id;
            //} catch (Exception e)
            //{
            //    data.IsSuccess = false;
            //    data.Message = e.Message;
            //    return null;
            //}
            
        }

        public TaskClass SearchByName(string name_search)
        {
            TaskClass res_by_name = tasks.Find(x => x.Name == name_search);
            return res_by_name;
        }


    }
}
