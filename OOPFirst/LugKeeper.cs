using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public abstract class LugKeeper : Employee, IKeyKeeper
    {
        public LugKeeper(string name, short age) : base(name, age)
        {
        }

        public abstract void keepLugg();

        public override string getDescription()
        {
            return "This is luggage keeper";
        }

        public void openDoor()
        {
            Console.WriteLine("Door opened");
        }
    }
}
