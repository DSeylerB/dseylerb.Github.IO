using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___4
{
    class Rectangle
    {
        private int Length { get; set; }
        private int Width { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Area(int Length, int Width)
        {
           int area = (Length * Width);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(4, 5);
            Console.WriteLine(a.Area());

            Console.ReadLine();
        }
    }

    

}
