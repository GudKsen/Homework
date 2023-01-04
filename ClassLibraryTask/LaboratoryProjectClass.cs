using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
     class LaboratoryProjectClass : DodTask
    {
        int Max_mark_for_task = 120;
        float Current_mark_for_task;
        int id;

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

        static bool print_res(int n)
        {
            Predicate<int> isPassingScore = (int x) => x > 50;
            return isPassingScore(n);
        }

        Action<int> printActionDel = delegate (int i)
        {
            Console.WriteLine(print_res(i));
        };

        public override void GetResult()
        {
            Console.WriteLine($"You get {Current_mark_for_task} from {Max_mark_for_task} for laboratory work");
        }
    }
}
