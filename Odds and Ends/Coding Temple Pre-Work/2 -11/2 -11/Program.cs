using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__11
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Count;

            Employee Dan = new Employee();
            Dan.Name = "Dan";
            Dan.Age = 23;
            Dan.Position = "Student";
            Dan.Salary = 0; //AAAAAAAAAAAAAAAA

            Employee Bob = new Employee();
            Bob.Name = "Bob";
            Bob.Age = 35;
            Bob.Position = "Janitor";
            Bob.Salary = 35000;

            Console.WriteLine(Employee.Count);


            Console.ReadLine();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public static int Count = 0;

        //public Employee()
        //{
        //}

        public Employee()
        {
            Count++;
        }
       
        public Employee (int Age)
        {

        }

        public Employee (string Name,int Age, string Position, int Salary)
        {

        }

        
    }
}


