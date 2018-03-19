using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int y = int.Parse(Console.ReadLine());

            if (y > 0)
                for (int x = 0; x < y; x++)
                {
                Console.WriteLine(x);
                }

            else if (y < 0)
                for (int x = 0; x > y; y++)
                {
                    Console.WriteLine(y);
                }

           
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
