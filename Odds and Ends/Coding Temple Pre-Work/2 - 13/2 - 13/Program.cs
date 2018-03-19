using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___13
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal(9);
            Dog b = new Dog(3);
            Cat c = new Cat(4);
            a.Speak();
            b.Speak();
            c.Speak();

            Console.ReadLine();
        }
    }
    class Animal
    {
        public int Age { get;  set; }


        public Animal(int age)
        {
            Age = age;
        }
        
        public virtual void Speak()
        {
            Console.WriteLine();
        }
    }
    class Cat : Animal
    {
        public Cat(int age) : base(age)
        {

        }

        new public void Speak()
        {
            Console.WriteLine("Meow");
        }

    }
    class Dog : Animal
    {
        public Dog(int age) : base(age)
        {

        }

        new public void Speak()
        {
            Console.WriteLine("Borf");
        }
    }
}
