using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an exponent:");
            int b = int.Parse(Console.ReadLine());

            double Result = Power(a, b);

            Console.WriteLine(Result);

            Console.ReadLine();
        }

        static double Power(int a, int b)
        {
            double Result = Math.Pow(a, b);
            return Result;
        }
    }
}
