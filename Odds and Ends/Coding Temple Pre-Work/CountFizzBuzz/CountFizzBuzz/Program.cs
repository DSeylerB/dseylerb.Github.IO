using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number greater than 1:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                if (i % 5 == 0 & i > 3)
                {
                    Console.WriteLine("Buzz");
                }

                if (i % 5 == 0 & i % 3 == 0 & i > 3)
                {
                    Console.WriteLine("Fizz Buzz");
                }

                if (i % 5 != 0 & i % 3 != 0 & i != 3)
                {
                    Console.WriteLine(i);
                }
             }

            Console.ReadLine();
        }
    }
}
