using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class LugMover : LugKeeper
    {
        public LugMover(string name, short age) : base(name, age)
        {
        }

        public override void keepLugg()
        {
            Console.WriteLine("I move your luggage");
        }

        public override void printSalary()
        {
            Console.WriteLine("200k");
        }

        public override string getDescription()
        {
            return base.getDescription() + " and move";
        }
    }
}
