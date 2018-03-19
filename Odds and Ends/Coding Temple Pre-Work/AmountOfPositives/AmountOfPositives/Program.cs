using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmountOfPositives
{
    class Program
    {
        static void Main(string[] args)
        {

            /* NEIN
            Console.WriteLine("Enter number 1/3:");
            string varX = Console.ReadLine();

            int x = Convert.ToInt32(varX);

            Console.WriteLine("Enter number 2/3:");
            string varY = Console.ReadLine();

            int y = Convert.ToInt32(varY);

            Console.WriteLine("Enter number 3/3:");
            string varZ = Console.ReadLine();

            int z = Convert.ToInt32(varZ);
            */


            /*
            int[] pos = new int[3];

            for (int i = 0; i > 0; i++)
            {
                Console.WriteLine("Please enter 3 numbers: ");
                pos[i] = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
            */


            /* NEIN NEIN
            Console.WriteLine("Enter number 1/3:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2/3:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 3/3:");
            int z = int.Parse(Console.ReadLine());

            int?[] intArray = new int[3];
            int[0]= x;
            int[1]= y;
            int[2]= z;

            //Console.WriteLine(x + " " + y + " " + z);
            */

            //VICTORY:
            int z = 0;
            
            Console.WriteLine("Enter number 1/2:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2/2:");
            int y = int.Parse(Console.ReadLine());

            if(x > 0)
            {
                z++;
            }

            if (y > 0)
            {
                z++;
            }

            Console.WriteLine("You entered {0} positive integer(s).", z);
            Console.ReadLine();
        }
    }
}
