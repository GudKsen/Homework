using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryTask
{
     class LaboratoryProjectClass : DodTask
    {
        private int Max_mark_for_task = 120;
        private float Current_mark_for_task;
        private int id;

        public int ID { get => id; set => id = value; }

        public new int MAX_MARK
        {
            get { return Max_mark_for_task; }
            set { Max_mark_for_task = value; }
        }

        public new float Current_mark
        {
            get { return Current_mark_for_task; }
            set { Current_mark_for_task = value * 100 - 10; }
        }

        LaboratoryProjectClass() { }
        public LaboratoryProjectClass(int curr) { MAX_MARK = curr; }
        LaboratoryProjectClass(int curr, int max_mark) { Current_mark = curr; MAX_MARK = max_mark; }

        static bool print_res(int n)
        {
            Predicate<int> isPassingScore = (int x) => x > 50;
            return isPassingScore(n);
        }

        public Action<int> printActionDel = delegate (int i)
        {
            bool ispass = print_res(i);
            if (ispass)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Did not pass");
            }
            
        };

        public override void GetResult()
        {
            Console.WriteLine($"You get {Current_mark_for_task} from {Max_mark_for_task} for laboratory work");
        }

        public override string ToString()
        {
            return "ID: " + ID + "\n";
        }
    }
}
