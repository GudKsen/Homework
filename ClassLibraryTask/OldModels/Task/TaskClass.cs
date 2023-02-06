using ClassLibraryTask.Models;
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
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public TypeTask Type { get; set; }

        public DateTime Deadline { get; set; }


        public TaskClass() { }

        public TaskClass(string namet, string description, TypeTask type, DateTime deadline)
        {
            Random rnd = new Random();
            ID = rnd.Next(100);
            Name = namet;
            Description = description;
            Type = type;
            Deadline = deadline;
        }


        public override string ToString()
        {
            return $"ID: {ID}  Name: {Name}  Description: {Description}";
        }

        public override bool Equals(object t)
        {
            if (!(t is TaskClass task))
            {
                return false;
            }

            if (task.Name != Name)
            {
                return false;
            }
            else if (task.Description != Description)
            {
                return false;
            }
            else if (task.Type != Type)
            {
                return false;
            }
            else if (task.Deadline != Deadline)
            {
                return false;
            }
            return true;
        }

       

        public int CompareTo(TaskClass other)
        {
            return Name.CompareTo(other.Name);
        }

    }
}
