﻿using ClassLibraryTask;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Theory
{
    public class TheoryClass : TaskClass
    {
        private string book { get; set; }
        private int page { get; set; }
        private int number_of_words { get; set; }

        void TheoryClassC(string name, string book, int page, int number_of_words)
        {
            Random rnd = new Random();
            ID = rnd.Next();
            Name = name;
            this.book = book;
            this.page = page;
            this.number_of_words = number_of_words;
        }

        public string Book { get { return book; } set { book = value; } }
        public int Page { get { return page; } set { page = value; } }
        public int NumberOfWords { get { return number_of_words; }
            set
            {
                number_of_words = value;
            }
        }

        public override string ToString()
        {
            return "Book name: " + book + " Page: " + page + " Number of words: " + NumberOfWords + "\n";
        }
    }
}
