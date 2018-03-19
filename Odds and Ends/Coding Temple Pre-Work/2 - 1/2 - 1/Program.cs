using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int b = int.Parse(Console.ReadLine());

            int c = SumNumbers(a, b);

            Console.WriteLine("{0} + {1} = {2}", a, b, c);

            Console.ReadLine();
        }

        
        static int SumNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
