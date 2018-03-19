using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grades> grades = new List<Grades>()
            {
                new Grades {grade = "A" },
                new Grades {grade = "B" },
                new Grades {grade = "C" },
                new Grades {grade = "D" },
                new Grades {grade = "F" }
            };



            Console.WriteLine("What letter grade did you get on the test?");
            string Score = Console.ReadLine();

            Grade(Score);

            Console.ReadLine();
        }

        static void Grade(string Score)
        {
            foreach (var Grades in grades)
            {
                switch (Grades.grade)
                {
                    case Score = "A":
                }
            }
        }
    }

    class Grades
    {
        public string grade { get; set; }
    }

    /* //DON'T ASK, I DON'T KNOW
    enum TeacherComment
    {
        Exellent,
        Well_done,
        Average
    }
    */
}
