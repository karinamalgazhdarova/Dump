using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public abstract class Employee
    {
        private class WorkRelations
        {

        }

        protected class WorkRumors
        {

        }

        protected String name;
        private short age;
        String tag = "sometag";//private same

        public Employee(string name, short age)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
        }

        public virtual void work()
        {
            Console.WriteLine(String.Format("Our age is {0}", age));
            Console.WriteLine(String.Format("Our name is {0}", name));
            Console.WriteLine(String.Format("Our tag is {0}", tag));
            someSecret();
            someProtected();
            Console.WriteLine("Employee works");
        }

        protected void someProtected()
        {
            Console.WriteLine("Some protected");
        }

        private void someSecret()
        {
            Console.WriteLine("Some very secret");
            WorkRelations workRelations = new WorkRelations();
            WorkRumors workRumors = new WorkRumors();
        }

        public abstract void printSalary();
        public abstract String getDescription();
    }
}
