using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class Security : Employee, IDrescoded, IKeyKeeper
    {
        bool isMain;

        public Security(string name, short age) : base(name, age)
        {
            isMain = false;
        }

        public bool checkDresscode(string currentDress)
        {
            return "Shirt".Equals(currentDress);
        }

        public string getDresscode()
        {
            return "Shirt";
        }

        public override string getDescription()
        {
            return "This is airport security";
        }

        public override void printSalary()
        {
            Console.WriteLine("Not so much");
        }

        public override void work()
        {
            base.work();
            Console.WriteLine("Protect and serve");
        }

        public void openDoor()
        {
            Console.WriteLine("Door opened by security");
        }
    }
}
