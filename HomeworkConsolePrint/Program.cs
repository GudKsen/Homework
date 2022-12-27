using ClassLibraryTask;
using UnitTestProjectHomework;

namespace HomeworkConsolePrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter max number of added elements: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {
                Menu.menu(N);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("Here is some tests: ");
            Console.WriteLine("Test for adding element: ");
            
            TestAddingElement test1 = new TestAddingElement();
   
            test1.isRightAddResult();

            Console.WriteLine("Test for searching element: ");
            test1.isRightSearchResult();

            Console.WriteLine("Test for deleting element: ");
            test1.isRightDeleteResult();
        }
    }
}