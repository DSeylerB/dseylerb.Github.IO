using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person User = new Person();

            Console.WriteLine("Enter your name:");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            User.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your gender:");
            User.Gender = Console.ReadLine();

            bool adult = User.IsAdult();
            Console.WriteLine(adult);
            
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public bool IsAdult()
        {
            bool adult = true;
            if (Age <= 18)
            {
               adult  = false;
            }

            return adult;
        }
    }
}
