using ClassLibrary;
using ClassLibraryTask;
using ClassLibraryTask.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            tt.ProcessCompleted += bl_ProcessCompleted;
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
            TaskClass t = tt.SearchByID(id);
            t.checkDate();
        }


        public void Sort_Tasks_By_Name()
        {
            tt.Tasks.Sort();
        }

        public void ConvertToXML(int show_option, string path)
        {
            //if (show_option == 1)
            //{
            //    DisplayTextFile dt = new DisplayTextFile();
            //    dt.PrintToTextFile(tt);
            //}
            //else if (show_option == 2)
            //{
            //    DisplayTextFile dt = new DisplayTextFile();
            //    dt.PrintToTextFile(tt);
            //}

            string destination = "";

            if (path == "file")
            {
                destination = "D:\\Lesson\\hw3.xml";
            }
            else if (path == "console")
            {
                //destination = Console.Out;
            }

            Console.WriteLine("Serialize, xml----------------------------------------------");

            Stream fs = new FileStream(destination, FileMode.Create);
            Serialize<List<TaskClass>> s = new Serialize<List<TaskClass>>();

            s.SerializeXML(Console.Out, tt.Tasks);

            Console.WriteLine("------------------------------------------------------------\n");
        }

        public void ConvertToJSON(int show_option)
        {
            //if (show_option == 1)
            //{
            //    DisplayConsole dc = new DisplayConsole();
            //    dc.PrintToCnsole(tt);
            //}
            //else if (show_option == 2)
            //{
            //    DisplayConsole dc = new DisplayConsole();
            //    dc.PrintToCnsole(tt);
            //}


        }

        public void ConvertFromXML()
        {
            TasksClass<TaskClass> arr = new TasksClass<TaskClass>();
            Serialize<List<TaskClass>> s = new Serialize<List<TaskClass>>();
            string str = File.ReadAllText("D:\\Lesson\\hw3.xml");
            arr.Tasks = s.DeserializeXML(str);
        }

        public void ConvertFromJSON()
        {

        }

        public void CheckIsPass(int i)
        {
            if (arr.Addition_tasks.Count == 0)
            {
                Console.WriteLine("There are no works");
            }
            else
            {
                LaboratoryProjectClass t = arr.Find(i);
                t.printActionDel(100);
            }
        }


    }
}
