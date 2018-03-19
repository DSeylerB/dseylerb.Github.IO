using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character:");
            char input = Console.ReadKey().KeyChar;



            Console.WriteLine("\nEnter the deisred width:");
            int x = int.Parse(Console.ReadLine());

            //string box = new string(input, x); 

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int a = 0; a < x; a++)
                {
                    Console.Write(input);
                }
            }

            

            Console.ReadLine();
        }
    }
}
