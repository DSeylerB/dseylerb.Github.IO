using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numVal = new int[5];

            Console.WriteLine("Please enter 5 numbers:");

            for(int i = 0; i < numVal.Length; i++)
            {
                numVal[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(numVal.Sum());

            Console.ReadLine();
        }
    }
}
