using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 0 to 100:");
            int x = int.Parse(Console.ReadLine());

            if (x >= 90)
                Console.WriteLine("You got an A!");

            else if (x >= 80)
                Console.WriteLine("You got a B.");

            else if (x >= 70)
                Console.WriteLine("You got a C.");

            else if (x >= 60)
                Console.WriteLine("You got a D");

            else //if (x <= 59)
                Console.WriteLine("You got an F.");

            Console.ReadLine();
                 

        }
    }
}
