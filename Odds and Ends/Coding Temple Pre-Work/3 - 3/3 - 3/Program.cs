using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___3
{
    public int raise;
    class Program
    {
        static void Main(string[] args)
        {
            //public int Raise;

            Employee D = new Employee("abc", 60000);
       
        }
    }

    class Employee
    {
        public string id { get; set; }
        private int salary { get; set; }
        

        public Employee(string id, int salary)
        {

        }

        public void Dispense(string id, int salary)
        {
            Console.WriteLine(salary/24 + " has been dispensed to their account.");
        }

        public void Raise(int salary, int raise)
        {
        salary += raise;
        return raise;
        }
    }
}
