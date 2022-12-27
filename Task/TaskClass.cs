﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClass
{
    public class TaskClass
    {
        public int Id;
        public string Name;
        public string Description;

        public TaskClass() { }
        public TaskClass(int id)
        {
            Id = id;
            
        }

        public string print_obj()
        {
            return $"{Id}, {Name}, {Description}";
        }
    }
}

