using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            x = 24 / 5;
            y = 24 % 5;

            Console.WriteLine("24 / 5 = " + x + " Remainder: " + y);
            Console.ReadLine();

        }
    }
}
