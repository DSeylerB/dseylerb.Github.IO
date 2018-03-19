using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___3_Hello_User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string UserName = Console.ReadLine();

            HelloUser(UserName);

            Console.ReadLine();
        }
                
        static void HelloUser(string UserName)
        {
            Console.WriteLine("Hello {0}", UserName);
        }
    }
}
