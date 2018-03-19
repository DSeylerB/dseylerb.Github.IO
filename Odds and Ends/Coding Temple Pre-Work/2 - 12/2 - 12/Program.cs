using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car();
            a.Make = "Ford";
            a.Model = "Fusion";
            a.Year = 2011;
            a.Color = "Black";
            a.Miles = 250000;

            Truck b = new Truck();

            Console.WriteLine(a.Type);
            Console.WriteLine(b.Type);
            
            Console.ReadLine();
        }
    }

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }

        public Vehicle()
        {

        }
    }

    public class Car : Vehicle
    {
        public string Type
        {
            get
            {
                return "Car";
            }
        }
    }

    public class Truck : Vehicle
    {

        public string Type
        {
            get
            {
                return "Truck";
            }
        }

    }
}
