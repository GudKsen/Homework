using ClassLibraryTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProjectHomework
{
    [TestClass]
    public class TestAddingElement
    {
        [TestMethod]
        public void isRightAddResult()
        {
            string date_str = "29.12.2022";
            DateTime date;
            DateTime.TryParse(date_str, out date);
            List<TaskClass> tasks = new List<TaskClass>();
            List<TaskClass> resultList = new List<TaskClass>();
            resultList.Add(new TaskClass("java", "system println", TypeTask.None, date));
            var class1 = new TaskClass("java", "system println", TypeTask.None, date);
            bool res = true;
            bool res2 = true;

            tasks.Add(class1);

            for (int i = 0; i < resultList.Count; i++)
            {
                if (!resultList[i].Equals(tasks[i]))
                {
                    res2 = false;
                }
            }
            
            if (res == res2)
            {
                Console.WriteLine("Success: lists are equal");
            }
            else
            {
                Console.WriteLine("Error: lists aren't equal");
            }
 
        }

        [TestMethod]
        public void isRightSearchResult() 
        {
            string date_str = "28.12.2022";
            DateTime date;
            DateTime.TryParse(date_str, out date);
            List<TaskClass> arr = new List<TaskClass>();
            TaskClass OneTask = new TaskClass("name", "descr", TypeTask.None, date);
            int Result_Index = 1;
            int Test_Index = -1;

            arr.Add(new TaskClass("name123", "descr", TypeTask.None, date));
            arr.Add(new TaskClass("name", "descr", TypeTask.None, date));
            arr.Add(new TaskClass("name222", "descrfghjkl", TypeTask.None, date));

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Equals(OneTask))
                {
                    Test_Index = i;
                }
            }

            if (Result_Index == Test_Index)
            {
                Console.WriteLine("Success");
            }
            
        }

        [TestMethod]
        public void isRightDeleteResult()
        {
            string date_str = "28.12.2022";
            DateTime date;
            DateTime.TryParse(date_str, out date);
            List<TaskClass> arr = new List<TaskClass>();
            List<TaskClass> arrRes = new List<TaskClass>();
            TaskClass OneTask = new TaskClass("name", "descr", TypeTask.None, date);
            bool IsEq = true;
            bool IsEqRes = true;

            arr.Add(new TaskClass("name123", "descr", TypeTask.None, date));
            arr.Add(new TaskClass("name", "descr", TypeTask.None, date));
            arr.Add(new TaskClass("name222", "descrfghjkl", TypeTask.None, date));

            arrRes.Add(new TaskClass("name123", "descr", TypeTask.None, date));
            arrRes.Add(new TaskClass("name", "descr", TypeTask.None, date));

            arr.Remove(new TaskClass("name222", "descrfghjkl", TypeTask.None, date));

            for (int i = 0; i < arrRes.Count; i++)
            {
                if (!arrRes.Equals(arrRes[i]))
                {
                    IsEq = false;
                }
            }
            if (IsEq == IsEqRes)
            {
                Console.WriteLine("Success: arrays are equals");
            }
        }
    }
}
