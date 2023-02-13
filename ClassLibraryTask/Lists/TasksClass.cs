using ClassLibraryTask.OldModels;
using System;
using System.Collections;
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
            //var data = new CustomEventArgs();

            var task = 
                from taskClass in tasks
                where taskClass.ID == id
                select taskClass;
            
            //TaskClass res_by_id = tasks.Find(x => x.ID == id);
            return (T)task;
        }

        public T SearchByName(string name_search)
        {
            TaskClass res_by_name = tasks.Find(x => x.Name == name_search);
            return (T)res_by_name;
        }

        public void SortByDate()
        {
            tasks.OrderBy(el => el.Deadline).ToList();
        }

        public void GroupByDeadline()
        {
            var tt = tasks
                .Select(task => new { task.Name, task.Deadline, days = new CheckTaskRelevance(task.Deadline).GetDayToDeadline() })
                .GroupBy(task => task.days)
                .Select(gr =>
                {
                    
                    Dictionary<double, string> d1 = new Dictionary<double, string>();
                   
                    foreach (var item in gr)
                    {
                        
                        Console.WriteLine(item.days.ToString());
                            d1.Add(item.days, item.Name);
                        //}
                    }

                    return d1;
                });

            string text = "";

           
        }

        public List<T> GetAll()
        {
            return Tasks;
        }
    }
}
