using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
    public class TaskClass : IComparable<TaskClass>
    {
        private int id;
        public int ID { get => id; set => id = value; }

        private string name;
        public string Name
        {
            get => name;
            set { name = value; }
        }

        private string Description { get; set; }
        private TypeTask Type;

        public TypeTask type
        {
            get => Type;
            set => Type = value;
        }

        private DateTime Deadline;

        public delegate void MyDelegate(string msg); // declare a delegate
        public void checkDate() {
            
            DateTime today = DateTime.Today;
            if (today > Deadline)
            {
                MyDelegate del = (string msg) => Console.WriteLine(msg);
                del("Vse, zapiznyvsya");
            }
        }


        public TaskClass() { }
        public TaskClass(string namet, string description, string type, DateTime deadline)
        {
            Random rnd = new Random();
            ID = rnd.Next();
            name = namet;
            Description = description;
            switch (type)
            {
                case "none":
                    Type = TypeTask.None;
                    break;

                case "theory":
                    Type = TypeTask.Theory;
                    break;

                case "practice":
                    Type = TypeTask.Practice;
                    break;

                case "additional":
                    Type = TypeTask.Additional;
                    break;
            }
            Deadline = deadline;
        }


        public override string ToString() {
            return "ID: " + ID + " Name: " + name + " Description: " + Description + "\n";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as TaskClass);
        }
        public bool Equals(TaskClass t)
        {
            if (t.Name != Name)
            {
                return false;
            }
            else if (t.Description != Description)
            {
                return false;
            }
            else if (t.Type != Type)
            {
                return false;
            }
            else if (t.Deadline != Deadline)
            {
                return false;
            }
            return true;
        }

        public double GetDayToDeadline()
        {
            DateTime today = DateTime.Today;
           // var daysLeft = Deadline - today;
            return (Deadline - today).TotalDays;
        }

        public int CompareTo(TaskClass other)
        {
            return name.CompareTo(other.name);
        }

        public string GetDaysLeft
        {
            get { return $"Number of left days: {GetDayToDeadline()}"; }
        }
    }
}
