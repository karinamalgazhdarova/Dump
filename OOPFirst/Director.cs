using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class Director : Employee, IDrescoded
    {
        public Director(string name, short age) : base(name, age)
        {
        }

        public bool checkDresscode(string currentDress)
        {
            //Console.WriteLine(age);
            return "Suit".Equals(currentDress);
        }

        public string getDresscode()
        {
            //someSecret();
            return "Suit";
        }

        public override string getDescription()
        {
            //Console.WriteLine(tag);
            someProtected();
            return "This is airport director his name is " + name;
        }

        public override void printSalary()
        {
            WorkRumors workRumors = new WorkRumors();
            Console.WriteLine("Too much");
        }

        public override void work()
        {
            Console.WriteLine("Something important");
        }
    }
}
