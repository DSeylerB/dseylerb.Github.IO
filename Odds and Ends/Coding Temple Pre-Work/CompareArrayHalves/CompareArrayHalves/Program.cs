using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrayHalves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an even number for array length:");
            int x = int.Parse(Console.ReadLine());

            int y = (x / 2) - 1;
            int z = x / 2;
            int w = x - 1;

            int[] numVal = new int[x];

            Console.WriteLine("Please enter " + x + " numbers:");

            for (int i = 0; i < numVal.Length; i++)
            {
                numVal[i] = int.Parse(Console.ReadLine());
            }

            /* ??????
            for (int a = 0; a < y; a++)
            {
                numVal[a]++; 
            }

            Console.WriteLine(numVal[a]);
            */
            
            Console.ReadLine();
        }
    }
}
