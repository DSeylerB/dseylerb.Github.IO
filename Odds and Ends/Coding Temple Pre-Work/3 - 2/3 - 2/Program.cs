using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3___2
{
   
}

namespace n1
{
    class Program
    {
        static void Main(string[] args)
        {
            n2.Person N2 = new n2.Person();
            n3.Person N3 = new n3.Person();

            n2.Person.print();

            n3.Person.print();

            Console.ReadLine();
        }
    }
}

namespace n2
{
    class Person
    {

        static void print()
        {
            Console.WriteLine("I am from n2.");
        }
    }
}

namespace n3
{
    class Person
    {
        static void print()
        {
            Console.WriteLine("I am from n3.");
        }
    }
}