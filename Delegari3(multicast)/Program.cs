using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegari3_multicast_
{
    // Delegare care inglobeaza mai multe metode
    public delegate void MyDelegate(double r, ref double[] a, ref int i);

    class Circle
    {
        const float PI = 3.14159f;

        static void Aria(double r, ref double[] a, ref int i)
        {
            a[++i] =  PI * r * r;
        }

        static void LungFrontiera(double r, ref double[] a, ref int i)
        {
            a[++i] = 2 * PI * r;
        }

        static void Cercul(double r, ref double[] a, ref int i)
        {
            Console.WriteLine("cercul de raza r={0} are:", r);
            a[++i] = 0;
        }

        static void Main(string[] args)
        {
            double raza = 3;
            double[] rez = new double[3];
            int i = -1;

            MyDelegate del = new MyDelegate(Cercul);
            del += new MyDelegate(Aria);
            del += new MyDelegate(LungFrontiera);
            del(raza, ref rez, ref i);
            Console.WriteLine("\t aria = {0:#.##} \n\t lungimea frontierei = {1:#.##}", rez[1], rez[2]);

            del -= new MyDelegate(Aria);
            rez = new double[3];
            i = -1;
            del(raza, ref rez, ref i);
            Console.WriteLine("\t aria = {0:#.##} \n\t lungimea frontierei = {1:#.##}", rez[2], rez[1]);
        }
    }
}
