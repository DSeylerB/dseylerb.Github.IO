using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOdds
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a positive number:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i++);
            }
            
            Console.ReadLine();
        }
    }
}
