using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4NumberAverager
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int a;
            int b;
            

            Console.WriteLine("Please enter number 1/4");
            string varX = Console.ReadLine();

            x = Convert.ToInt32(varX);

            Console.WriteLine("Please enter number 2/4");
            string varY = Console.ReadLine();

            y = Convert.ToInt32(varY);

            Console.WriteLine("Please enter number 3/4");
            string varA = Console.ReadLine();

            a = Convert.ToInt32(varA);

            Console.WriteLine("Please enter number 4/4");
            string varB = Console.ReadLine();

            b = Convert.ToInt32(varB);

            Console.Write("The average of " + x + ", " + y + ", " + a + ", and " + b + " is: "  );
            Console.WriteLine((x + y + a + b) / 4.0);
            Console.ReadLine();
        }
    }
}
