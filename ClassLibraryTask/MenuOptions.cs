using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Theory;

namespace ClassLibraryTask
{
    public class MenuOptions
    {
        private TasksClass<TaskClass> tt = new TasksClass<TaskClass>();
        private TasksClass<TheoryClass> thh = new TasksClass<TheoryClass>();

        private ListOfAddTask<LaboratoryProjectClass> arr = new ListOfAddTask<LaboratoryProjectClass>();

        public int AddingOption(string name, string description, string type, DateTime date)
        {
            TaskClass t = new TaskClass(name, description, type, date);
            
            tt.AddTask(t);
            return t.ID;
        }

        public void AddingTheory(int id, string NameOfBook, int NumberOfWords, int NumberOfPage)
        {
            TheoryClass teor = new TheoryClass();
            teor.ID = id;
            teor.Book = NameOfBook;
            teor.NumberOfWords = NumberOfWords;
            teor.Page = NumberOfPage;
            thh.AddTask(teor);
        }

        
        public void DeletingOption(string delete_option, string delete_field)
        {
            if (delete_option == "1")
            {
                int id_delete = Convert.ToInt32(delete_field);
                tt.DeleteTaskByID(id_delete);

            }
            else if (delete_option == "2")
            {
                tt.DeleteTaskByName(delete_field);
            }
        }



        public void DemMethod()
        {
            foreach (TaskClass task in tt.Tasks)
            {
                string str = task.GetDaysLeft;
                Console.WriteLine(str);
            }
        }



        public TaskClass SearchingOption(string field, string search_field)
        {
            if (field == "1")
            {
                int id = Convert.ToInt32(search_field);
                TaskClass task = tt.SearchByID(id);
                return task;
            }
            else if (field == "2")
            {
                TaskClass e = tt.SearchByName(search_field);
                return e;
            }
            return null;
        }



        public void ShowingOption()
        {
            
            for (int i = 0; i < tt.Tasks.Count; i++)
            {
                Console.WriteLine(tt.Tasks[i]);
                if (tt.Tasks[i].type == TypeTask.Theory)
                {
                    Console.Write("\t");
                    Console.WriteLine(thh.Tasks.Find(x => x.ID == tt.Tasks[i].ID));
                }
            }
        }



        public void CheckIsTaskActual(int id)
        {
            TaskClass t = tt.Tasks[id];
            t.checkDate();
        }

        public void Sort_Tasks_By_Name()
        {
            tt.Tasks.Sort();
        }

        public void CheckIsPass(int i)
        {
            if (arr.Addition_tasks.Count == 0)
            {
                Console.WriteLine("There are no works");
            }
            else
            {
                
            }
        }




    }
}
