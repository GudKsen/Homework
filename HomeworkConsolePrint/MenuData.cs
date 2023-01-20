using ClassLibraryTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationData;

namespace HomeworkConsolePrint
{
    internal class MenuData
    {

        private MenuOptions MenuOption = new MenuOptions();
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

            if (type == "theory") 
            {
                Console.Write("Do you want add theory information? (y, n): ");
                string? answer = Console.ReadLine();

                if (answer == "y")
                {
                    int id = MenuOption.AddingOption(name, description, type, date);
                    EnterTheory(id);
                }
            } 
            else
            {
                MenuOption.AddingOption(name, description, type, date);
            }
        }

        public void Convert_To_Xml()
        {
            MenuOption.ConvertToXML(1);
        }

        public void Convert_To_Json()
        {
            MenuOption.ConvertToJSON(1);
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
            MenuOption.AddingTheory(id, NameOfBook, NumberOfWords, NumberOfPage);

        }



        public void EnterDataForDelete()
        {
            Console.Write("Enter field for deleting (1 - ID, 2 - Name): ");

            string? delete_option = Console.ReadLine();

            if (delete_option == "1")
            {
                Console.Write("Enter id for deleting object: ");

                string? id_delete = Console.ReadLine();
                
                MenuOption.DeletingOption(delete_option, id_delete);

                Console.WriteLine("Deleted");
            }
            else if (delete_option == "2")
            {
                Console.Write("Enter id for deleting object: ");

                string? name_delete = Console.ReadLine();

                MenuOption.DeletingOption(delete_option, name_delete);

                Console.WriteLine("Deleted");
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

                TaskClass res = MenuOption.SearchingOption(field, id.ToString());

                Console.WriteLine(res);
            }
            else if (field == "2")
            {
                Console.Write("Enter name to find object: ");

                string? name = Console.ReadLine();

                TaskClass res = MenuOption.SearchingOption(field, name);

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
            MenuOption.CheckIsTaskActual(id);
        }

        public void Sort_Tasks()
        {
            MenuOption.Sort_Tasks_By_Name();
        }


        public void ShowData()
        {
            MenuOption.ShowingOption();
        }

        public void DemDataMeth()
        {
            MenuOption.DemMethod();
        }
    }
}
