using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOrMinus
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            Console.WriteLine("Give me a number!");
            string varX = Console.ReadLine();

            int x = Convert.ToInt32(varX);

            if (x > 0)
            {
                Console.WriteLine(varX + " is positive!");
            }

            else if (x < 0)
            {
                Console.WriteLine(varX + " is negative!");
            }

            else if (x == 0)
            {
                Console.WriteLine(varX + " is zero!");
            }

            Console.ReadLine();
        }
    }
}
