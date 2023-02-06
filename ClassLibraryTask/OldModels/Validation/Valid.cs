using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationData
{
    public class Valid
    {
        public static bool IsValidString(string str)
        {
            //if (str == null)
            //{
            //    Console.WriteLine("Invalid input: String is empty.\n");
            //    return false;
            //}
            //else if (str.Length < 3 || str.Length > 255)
            //{
            //    Console.WriteLine("Invalid input: string can be more than three characters and less than 255.\n");
            //    return false;
            //}
            return true;
        }

        public static bool IsValidText(string str) { 
            if (str == null)
            {
                Console.WriteLine("Invalid input: Text is empty.\n");
                return false;
            }
            else if (str.Length < 10 || str.Length > 1024)
            {
                Console.WriteLine("Invalid input: text can be more than ten characters and less than 1024.\n");
                return false;
            }
            return true;
         }


        public static bool IsValidDate(DateTime date)
        {
            DateTime todayDate = DateTime.Today;

            if (date == null)
            {
                Console.WriteLine("Invalid input: Empty date.\n");
                return false;
            }
            //else if (date < todayDate)
            //{
            //    Console.WriteLine("Invalid input: the date must be greater than the current one.\n");
            //    return false;
            //}

            return true;
        }

        public static bool IsValidType(string type)
        {
            if (type != "none" && type != "theory" && type != "practice" && type != "additional")
            {
                Console.WriteLine("Invalid input: invalid type.\n");
                return false;
            }
            else if (type == null)
            {
                Console.WriteLine("Invalid input: empty type.\n");
                return false;
            }
            return true;
        }
    }
}
