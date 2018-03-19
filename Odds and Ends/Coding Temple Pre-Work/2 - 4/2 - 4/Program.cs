using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___4
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Program SumArray = new Program();

            Console.WriteLine("Enter the desired array length:");
            int ArrayLength = int.Parse(Console.ReadLine());

            int[] Numbers = new int[ArrayLength];

            Console.WriteLine("Enter {0} numbers:", ArrayLength);

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
                        
            int Sum = SumArray(Numbers);

            Console.WriteLine(Sum);
            Console.ReadLine();
        }

        static int SumArray(int[] numVal)
            {

            //int Sum = 0;
            
            //for (int i = 0; i < numVal.Length; i++)
            //{
            //    Sum += numVal[i];
            //}
            return numVal.Sum();
            }
    }
}
