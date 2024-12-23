using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegari
{
    // Delegare care inglobeaza metode statice
    public delegate double MyDelegate(double a);
    class Circle
    {
        const float PI = 3.14159f;

        public static double Aria(double r)
        {
            return (PI * r * r);
        }

        public static double LungFrontiera(double r)
        {
            return (2 * PI * r);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            double raza = 3;
            MyDelegate del = new MyDelegate(Circle.Aria);
            Console.WriteLine("Aria= {0:#.##}", del(raza));
            del = new MyDelegate(Circle.LungFrontiera);
            Console.WriteLine("Lungimea frontierei= {0:#.##}", del(raza));
        }
    }
}
