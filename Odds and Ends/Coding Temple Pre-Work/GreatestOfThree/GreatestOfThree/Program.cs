using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("please enter 3 numbers:");

            int[] newArray = new int[3];
            for (int x = 0; x < newArray.Length; x++)
            {
                newArray[x] = int.Parse(Console.ReadLine());
            }

            //Array.Sort(newArray); // the highest number will be put in newArray[2]
            
            Console.WriteLine("The greatest number you entered was: " + newArray.Max());
          
            Console.ReadLine();
        }
    }
}
