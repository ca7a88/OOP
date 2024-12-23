using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegari2
{
    // Delegare care inglobeaza metode ale unor obiecte
    public delegate double MyDelegate();
    class Circle
    {
        public double raza;
        const float PI = 3.14159f;

        public Circle(double r)
        {
            raza = r;
        }

        public double Aria()
        {
            return (PI * raza * raza);
        }

        public double LungFrontiera()
        {
            return (2 * PI * raza);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(3);
            MyDelegate del = new MyDelegate(c.Aria);
            Console.WriteLine("Aria= {0:#.##}", del());
            del = new MyDelegate(c.LungFrontiera);
            Console.WriteLine("Lungimea frontierei= {0:#.##}", del());
        }
    }
}
