using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask;
using ValidationData;
using Theory;

namespace Options
{
    public class Adding
    {
        public static void AddingOption(List<TaskClass> tasks, List<TheoryClass> theoriesTasks)
        {
            bool IsValid = false;

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

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
            string description = Console.ReadLine();
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
            string type = Console.ReadLine();
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


            TaskClass t = new TaskClass(name, description, type, date);
            tasks.Add(t);
            if (type == "theory")
            {
                Console.Write("Enter name of book: ");
                string NameOfBook = Console.ReadLine();
                IsValid = false;

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
                string number = Console.ReadLine();

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

                TheoryClass th = new TheoryClass();
                th.ID = t.ID;
                th.Book = NameOfBook;
                th.NumberOfWords = NumberOfWords;
                th.Page = NumberOfPage;
                th.Name = name;
                theoriesTasks.Add(th);
            }
        }
    }
}
