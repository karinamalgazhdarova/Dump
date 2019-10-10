using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class Controller : Employee, IDrescoded
    {
        String department;

        public Controller(string name, short age, String department) : base(name, age)
        {
            this.department = department;
        }

        public bool checkDresscode(string currentDress)
        {
            return "Jacket".Equals(currentDress);
            //return currentDress.Equals("Jacket");// NullPointerException possible
        }

        public string getDresscode()
        {
            return "Jacket";
        }

        public override string getDescription()
        {
            return "This is Controller class";
        }

        public override void printSalary()
        {
            Console.WriteLine("Normal salary");
        }

        public override void work()
        {
            base.work();
            Console.WriteLine("Checking tickets");
        }
    }
}
