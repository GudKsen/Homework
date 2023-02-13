using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask;
using ClassLibraryTask.OldModels.Validation;
using ClassLibraryTask.Models;
using ClassLibraryTask.OldModels;

namespace HomeworkConsolePrint.Service
{
    internal class ServiceTasks
    {
        IRepository<TaskClass> repository { get; set; }
        Serialize<List<TaskClass>> serialize = new Serialize<List<TaskClass>>();


        public void AddTask(string name, string description, string type, DateTime deadline)
        {
            TypeTask typeTask = (new TypeTaskValidate(type).Validate());
            TaskClass task = new TaskClass(name, description, typeTask, deadline);
            repository.Add(task);
        }

        public void DeleteTaskByID(int id)
        {
            repository.DeleteByID(id);
        }

        public void DeleteTaskByName(string name_delete)
        {
            repository.DeleteByName(name_delete);
        }

        public TaskClass SearchTaskByID(int id)
        {
            return repository.SearchByID(id);
        }
        public TaskClass SearchTaskByName(string name_search)
        {
            return repository.SearchByName(name_search);
        }

        public List<TaskClass> GetTasks()
        {
            return repository.GetAll();
        }

        public void SortTasks()
        {
            List<TaskClass> tasks = repository.GetAll();
            tasks.Sort();
        }

        public string TasksToJson()
        {
            var tasks = GetTasks();

            return serialize.SerializeJSON(tasks);
        }

        public List<TaskClass> TasksFromJson(string json)
        {
            return serialize.DeserializeJSON(json);
        }

        public void TasksToXml(string way)
        {
            List<TaskClass> tasks = repository.GetAll();
            if (way == "console")
            {
                serialize.SerializeXML(Console.OpenStandardOutput(), tasks);
            }
            else if (way == "file")
            {
                string destination = "D:\\Lesson\\hw3.xml";
                Stream fs = new FileStream(destination, FileMode.Create);
                serialize.SerializeXML(fs, tasks);
            }
        }

        public List<TaskClass> TasksFromXml()
        {
            string str = File.ReadAllText("D:\\Lesson\\hw3.xml");
            List<TaskClass> tasks = serialize.DeserializeXML(str);
            return tasks;
        }

        public void CheckTaskDate(int id)
        {
            var task = SearchTaskByID(id);

        }

        public void GroupByDeadlines()
        {
            repository.GroupByDeadline();
        }


    }
}
