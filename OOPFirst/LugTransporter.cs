using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class LugTransporter : LugKeeper
    {
        public LugTransporter(string name, short age) : base(name, age)
        {
        }

        public override void keepLugg()
        {
            Console.WriteLine("I transport your luggage to plane");
        }

        public override void printSalary()
        {
            Console.WriteLine("250k");
        }
    }
}
