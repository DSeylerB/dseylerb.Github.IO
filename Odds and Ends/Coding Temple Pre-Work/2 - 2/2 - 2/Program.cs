using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string a = Console.ReadLine();

            Console.WriteLine("Enter another string:");
            string b = Console.ReadLine();

            bool SameString = true;

            SameString = CompStrings(a, b);

            if (SameString == true)
            {
                Console.WriteLine("Both strings are the same.");
            }

            else
            {
                Console.WriteLine("These strings are not the same");
            }

            Console.ReadLine();
        }

        public static bool CompStrings(string a, string b)
        {
            if (a == b)
            {
                return true;
            }

            else
            {
                return false;
            }

            // return a==b;
        }

    }
}
