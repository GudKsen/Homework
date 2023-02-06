using ClassLibraryTask.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Theory;

namespace ClassLibraryTask
{
    public abstract class MenuOptions
    {
        public  TasksClass<TaskClass> tt { get; set; }
        //private TasksClass<TaskClass> tt = new TasksClass<TaskClass>();
        private TasksClass<TheoryClass> thh = new TasksClass<TheoryClass>();

        public MenuOptions() 
        {
            tt = new TasksClass<TaskClass> ();
        }
        
        public virtual void AddTaskOption(string name, string description, string type, DateTime date)
        {
            TypeTask obj = TypeTask.None;
            TaskClass t = new TaskClass(name, description, obj, date);
            //tt.ProcessCompleted += bl_ProcessCompleted;
            tt.AddTask(t);
            //return t;
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
                string str = "not implemented";
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

        public static void bl_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }


        public static void bl_ProcessCompleted_MyDelegate(object sender, CustomEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccess ? "Completed Successfully" : "failed"));
           
        }


        public void ShowingOption()
        {
            tt.Tasks.OrderBy(task => task.ID);
            var table = new Table();
            table.AddColumn("ID");
            table.AddColumn("Name");
            table.AddColumn("Description");
            table.AddColumn("Deadline");
            table.AddColumn("Type");
            for (int i = 0; i < tt.Tasks.Count; i++)
            {
                table.AddRow(tt.Tasks[i].ID.ToString(), tt.Tasks[i].Name.ToString(), tt.Tasks[i].Description.ToString(), tt.Tasks[i].Deadline.ToString(), tt.Tasks[i].Type.ToString());
                
                //Console.WriteLine(tt.Tasks[i]);
                //if (tt.Tasks[i].type == TypeTask.Theory)
                //{
                //    Console.Write("\t");
                //    Console.WriteLine(thh.Tasks.Find(x => x.ID == tt.Tasks[i].ID));
                //}
            }
            AnsiConsole.Write(table);
        }



        public void CheckIsTaskActual(int id)
        {
            //TaskClass t = tt.SearchByID(id);
            //t.CheckDate();
        }


        public void Sort_Tasks_By_Name()
        {
            tt.Tasks.Sort();
        }

        public void ConvertToXML(string path)
        {
            Stream fs = null;
            if (path == "file")
            {
                string destination = "D:\\Lesson\\hw3.xml";
                fs = new FileStream(destination, FileMode.Create);
            }
            else if (path == "console")
            {
                fs = Console.OpenStandardOutput();
            }

            Serialize<List<TaskClass>> s = new Serialize<List<TaskClass>>();

            s.SerializeXML(fs, tt.Tasks);
            fs.Close();
        }

        public string ConvertToJSON()
        {
            Serialize<List<TaskClass>> s = new Serialize<List<TaskClass>>();
            string str = s.SerializeJSON(tt.Tasks);
            return str;
        }

        public TasksClass<TaskClass> ConvertFromXML()
        {
            TasksClass<TaskClass> arr = new TasksClass<TaskClass>();
            Serialize<List<TaskClass>> s = new Serialize<List<TaskClass>>();
            string str = File.ReadAllText("D:\\Lesson\\hw3.xml");
            arr.Tasks = s.DeserializeXML(str);
            return arr;
        }

        public List<TaskClass> ConvertFromJSON(string str)
        {
            Serialize<List<TaskClass>> s = new Serialize<List<TaskClass>>();
            return s.DeserializeJSON(str);
        }

        public void CheckIsPass(int i)
        {
            //if (arr.Addition_tasks.Count == 0)
            //{
            //    Console.WriteLine("There are no works");
            //}
            //else
            //{
            //    LaboratoryProjectClass t = arr.Find(i);
            //    t.printActionDel(100);
            //}
        }


    }
}
