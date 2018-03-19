using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___10
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0.0,1.0);
            Point b = new Point(0.0,2.0);
                     
            double Dis = Distance(a, b);

            Console.WriteLine(Dis);
            
            Console.ReadLine();
        }
        static double Distance(Point alpha, Point beta)
        {
            //int x1 = alpha.x;
            //int x2 = beta.x;
            //int y1 = alpha.y;
            //int y2 = beta.y;
            int Xdis = alpha.x - beta.x;
            int Ydis = alpha.y - beta.y;

            return Math.Sqrt(Math.Pow(Xdis, 2) + Math.Pow(Ydis, 2));

            //return Dis;
        }
    }
        
    class Point 
    {
        
        private double _x;
        private double _y;
        public int x 

        public int y { get; set; }
        public Point(double x, double y)
        {
            x = _x;
            y = _y;
        }
    }


}
