using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveWayCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int a;
            int b;
            int c;
            int d;
            int e;

            Console.WriteLine("Please designate variable x");
            string varX = Console.ReadLine();

            x = Convert.ToInt32(varX);

            Console.WriteLine("Please designate variable y");
            string varY = Console.ReadLine();

            y = Convert.ToInt32(varY);

            a = x + y;
            b = x - y;
            c = x * y;
            d = x / y;
            e = x % y;

            Console.WriteLine(varX + " + " + varY + " = " + a ); 
            Console.WriteLine(varX + " - " + varY + " = " + b); 
            Console.WriteLine(varX + " * " + varY + " = " + c); 
            Console.WriteLine(varX + " / " + varY + " = " + d + " Remainder:" + e); 
            Console.WriteLine(varX + " mod " + varY + " = " + e);

            Console.ReadLine();
        }
    }
}
