using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());

            if(x % 3 == 0)
            {
                Console.Write("Fizz ");
            }

            if (x % 5 == 0 & x > 3)
            {
                Console.Write("Buzz");
            }

            Console.ReadLine();
        }
    }
}
