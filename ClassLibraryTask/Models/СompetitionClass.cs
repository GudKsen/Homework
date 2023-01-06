using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
    internal class СompetitionClass : DodTask
    {
        private int Max_mark_for_task = 200;
        private float Current_mark_for_task = 0.9f;

        public new int MAX_MARK
        {
            get { return Max_mark_for_task; } set { Max_mark_for_task = value; }
        }

        public new float Current_mark
        {
            get { return Current_mark_for_task; } set { Current_mark_for_task = value * 100; }
        }

        public override void GetResult()
        {
            Console.WriteLine($"You get {Current_mark_for_task} from {Max_mark_for_task} for competiton");
        }
    }
}
