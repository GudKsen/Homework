using ClassLibraryTask;
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
        //private int _id;

        //public int ID { get { return _id; } }
        //public string Book { get; set; }
        //public int Page { get; set; }
        //public int Number_of_words { get; set; }

        //void TheoryClassC(int id, string name, string book, int page, int number_of_words)
        //{
        //    ID = id;
        //    Name = name;
        //    this.book = book;
        //    this.page = page;
        //    this.number_of_words = number_of_words;
        //}

        public string Book { get;  set;  }
        public int Page { get; set; }
        public int NumberOfWords { get; set;}

        public override string ToString()
        {
            return "Book name: " + Book + " Page: " + Page + " Number of words: " + NumberOfWords + "\n";
        }
    }
}
