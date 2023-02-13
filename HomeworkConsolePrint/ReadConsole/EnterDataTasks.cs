using ClassLibraryTask;
using ValidationData;
using ClassLibrary;
using HomeworkConsolePrint.Service;
using Spectre.Console;

namespace HomeworkConsolePrint.ReadConsole
{
    internal class EnterDataTasks
    {
        ServiceTasks service { get; set; }
        public void EnterDataAdd()
        {
            bool IsValid = false;

            Console.Write("Enter name: ");
            string? name = Console.ReadLine();

            while (IsValid != true)
            {
                IsValid = Valid.IsValidString(name);
                if (IsValid != true)
                {
                    Console.Write("Enter name: ");
                    name = Console.ReadLine();
                }
            }
            Console.Write("\n");

            Console.Write("Enter description: ");
            string? description = Console.ReadLine();
            IsValid = false;

            while (IsValid != true)
            {
                IsValid = Valid.IsValidText(description);
                if (IsValid != true)
                {
                    Console.Write("Enter description: ");
                    description = Console.ReadLine();
                }
            }
            Console.Write("\n");

            Console.Write("Enter deadline: ");
            DateTime date;
            DateTime.TryParse(Console.ReadLine(), out date);
            IsValid = false;

            while (IsValid != true)
            {
                IsValid = Valid.IsValidDate(date);
                if (IsValid != true)
                {
                    Console.Write("Enter date: ");
                    DateTime.TryParse(Console.ReadLine(), out date);
                }
            }
            Console.Write("\n");

            Console.Write("Enter type of homework (none, theory, practice, additional): ");
            string? type = Console.ReadLine();
            IsValid = false;

            while (IsValid != true)
            {
                IsValid = Valid.IsValidType(type);
                if (IsValid != true)
                {
                    Console.Write("Enter type of homework (none, theory, practice, additional): ");
                    type = Console.ReadLine();
                }
            }
            Console.Write("\n");



            if (type == "theory")
            {
                Console.Write("Do you want add theory information? (y, n): ");
                string? answer = Console.ReadLine();

                if (answer == "y")
                {
                    //var id = MenuOption.AddTaskOption(name, description, type, date);
                    //EnterTheory(id);
                }
            }
            else
            {
                service.AddTask(name, description, type, date);
            }
        }

        public void Convert_To_Xml()
        {
            Console.Write("Enter how to present information(file or console): ");
            string? type = Console.ReadLine();
            service.TasksToXml(type);
        }

        public void Convert_To_Json()
        {
            string jsonstr = service.TasksToJson();
            Console.Write("Enter how to present information(file or console): ");
            string? type = Console.ReadLine();

            if (type == "file")
            {
                DisplayTextFile<string> dt = new DisplayTextFile<string>();
                dt.PrintToTextFile(jsonstr);
            }
            else if (type == "console")
            {
                DisplayConsole<string> dc = new DisplayConsole<string>();
                dc.PrintToConsole(jsonstr);
            }
        }

        public void GrpBy()
        {
            service.GroupByDeadlines();
        }

        public void ConvertFromXml()
        {
            var t = service.TasksFromXml();
            Console.Write("Enter how to present information(file or console): ");
            string? type = Console.ReadLine();

            if (type == "file")
            {
                DisplayTextFile<List<TaskClass>> dt = new DisplayTextFile<List<TaskClass>>();
                dt.PrintToTextFile(t);
            }
            else if (type == "console")
            {
                DisplayConsole<List<TaskClass>> dc = new DisplayConsole<List<TaskClass>>();
                dc.PrintToConsole(t);
            }
        }

        public void ConvertFromJson()
        {
            Console.Write("Enter json-string for converting: ");
            string str = Console.ReadLine();
            var t = service.TasksFromJson(str);

            Console.Write("Enter how to present information(file or console): ");
            string? type = Console.ReadLine();

            if (type == "file")
            {
                DisplayTextFile<List<TaskClass>> dt = new DisplayTextFile<List<TaskClass>>();
                dt.PrintToTextFile(t);
            }
            else if (type == "console")
            {
                DisplayConsole<List<TaskClass>> dc = new DisplayConsole<List<TaskClass>>();
                dc.PrintToConsole(t);
            }
        }

        public void EnterTheory(int id)
        {
            Console.Write("Enter name of book: ");
            string? NameOfBook = Console.ReadLine();
            bool IsValid = false;

            while (IsValid != true)
            {
                IsValid = Valid.IsValidString(NameOfBook);
                if (IsValid != true)
                {
                    Console.Write("Enter name of book: ");
                    NameOfBook = Console.ReadLine();
                }
            }

            Console.Write("Enter number of page: ");
            int NumberOfPage;
            string? number = Console.ReadLine();

            while (!int.TryParse(number, out NumberOfPage))
            {
                Console.WriteLine("Invalid input: invalid number");
                if (!int.TryParse(number, out _))
                {
                    Console.Write("Enter number of page: ");
                    number = Console.ReadLine();
                }
            }

            Console.Write("Enter number of words: ");
            int NumberOfWords;
            number = Console.ReadLine();

            while (!int.TryParse(number, out NumberOfWords))
            {
                Console.WriteLine("Invalid input: invalid number");
                if (!int.TryParse(number, out _))
                {
                    Console.Write("Enter number of words: ");
                    number = Console.ReadLine();
                }
            }

            //Menu option
            //MenuOption.AddingTheory(id, NameOfBook, NumberOfWords, NumberOfPage);

        }



        public void EnterDataForDelete()
        {
            Console.Write("Enter field for deleting (1 - ID, 2 - Name): ");

            string? delete_option = Console.ReadLine();

            if (delete_option == "1")
            {
                Console.Write("Enter id for deleting object: ");

                string? id_delete = Console.ReadLine();

                service.DeleteTaskByID(Int32.Parse(id_delete));
            }
            else if (delete_option == "2")
            {
                Console.Write("Enter name for deleting object: ");

                string? name_delete = Console.ReadLine();

                service.DeleteTaskByName(name_delete);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }



        public void EnterDataForSearch()
        {
            Console.Write("Select the field for searching (1 - ID, 2 - name): ");

            string? field = Console.ReadLine();

            if (field == null)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (field == "1")
            {
                Console.Write("Enter ID to find object: ");

                int id = Convert.ToInt32(Console.ReadLine());

                TaskClass res = service.SearchTaskByID(Int32.Parse(field));

                Console.WriteLine(res);
            }
            else if (field == "2")
            {
                Console.Write("Enter name to find object: ");

                string? name = Console.ReadLine();

                TaskClass res = service.SearchTaskByName(name);

                Console.WriteLine(res);
            }

        }

        public void checkIsPass()
        {
            Console.Write("Enter your grade: ");

        }

        public void PrintIsTaskActual()
        {
            Console.Write("Enter ID of task: ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            //MenuOption.CheckIsTaskActual(id);
        }

        public void Sort_Tasks()
        {
            service.SortTasks();
        }


        public void ShowData()
        {
            List<TaskClass> tasks = service.GetTasks();
            Table table = new Table();

            table.AddColumn("ID");
            table.AddColumn("Name");
            table.AddColumn("Description");
            table.AddColumn("Deadline");
            table.AddColumn("Type");

            foreach (TaskClass task in tasks)
            {
                table.AddRow(task.ID.ToString(), task.Name.ToString(), task.Description.ToString(), task.Deadline.ToString(), task.Type.ToString());
            }

            AnsiConsole.Write(table);
        }

        public void DemDataMeth()
        {
            //MenuOption.DemMethod();
        }
    }
}
