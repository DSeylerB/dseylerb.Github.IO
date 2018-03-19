using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array length:");
            int ArrayLength = int.Parse(Console.ReadLine());

            int[] NewArray = new int[ArrayLength];

            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Enter number {0}/{1}:", i + 1, ArrayLength);
                NewArray[i] = int.Parse(Console.ReadLine());
            }

            int MaxValue = GreatestOfArray(NewArray);

            Console.WriteLine("The highest number you entered was: {0}", MaxValue);
            Console.ReadLine();
        }

        static int GreatestOfArray (int[] Newarray)
        {
            int MaxValue = Newarray.Max();
            return MaxValue;
        }



    }
}
