using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string Mutant = Console.ReadLine();

            Console.WriteLine("Enter a number less than or equal to the length of the string:");
            int MutationPosistion = int.Parse(Console.ReadLine()) - 1; //because indexing starts at 0
                      
            Console.WriteLine("enter a single charactor:");
            char Mutation = Convert.ToChar(Console.ReadLine());

            MutationChamber(Mutant, MutationPosistion, Mutation);

            Console.ReadLine();
        }

        static void MutationChamber(string Mutant, int MutationPosition, char Mutation)
        {
            StringBuilder MutationResult = new StringBuilder(Mutant);
            MutationResult[MutationPosition] = Mutation;
            Mutant = MutationResult.ToString();

            Console.WriteLine(Mutant);
        }
    }
}
