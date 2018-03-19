using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___9
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle();
            myCar.Make = "Chevy";
            myCar.Model = "Cobalt";
            myCar.Year = 2010;
            myCar.Color = "Green";
            myCar.Miles = 78000;

            bool domestic = myCar.IsDomestic();
            Console.Write(domestic);

            bool New = myCar.IsNew();
            Console.WriteLine(" {0}", New);
            
            Console.ReadLine();
        }
    }

    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }

        public bool IsNew()
        {
            bool New = true;

            if (Miles > 25)
                New = false;

            return New;
        }

        public bool IsDomestic()
        {
            string[] ForeignMakes = new string[] {"Nissan", "Mitsubishi", "Infiniti",
            "Honda", "Toyota", "BMW", "Volkswagon", "Audi", "Mercedez Benz"};

            bool domestic = true;

            if (ForeignMakes.Contains(Make))
                domestic = false;

            return domestic;
        }
    }
}
