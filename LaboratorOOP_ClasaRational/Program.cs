using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP_ClasaRational
{
    // Sa se scrie un tip de date pentru lucrul cu numere rationale (numarator si numitor).
    // Sa se implementeze pentru acest tip operatiile de adunare, scadere, inmultire, impartire, ridicarea la putere, operatorii relationali,
    // precum si o operatie pentru aducerea fractiei la forma ireductibila.
    // Se vor utiliza 3 modalitati de initializare a unui obiect de acest tip si anume
    //  - rational()
    //  - rational(n)
    //  - rational(n, m)
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(2, 4);
            Rational r2 = new Rational(3, 2);

            Console.WriteLine("r1 = {0}\nr2 = {1}", r1, r2);
            Console.WriteLine("{0} + {1} = {2}", r1, r2, r1 + r2);
            Console.WriteLine("{0} - {1} = {2}", r1, r2, r1 - r2);
            Console.WriteLine("{0} x {1} = {2}", r1, r2, r1 * r2);
            Console.WriteLine("{0} : {1} = {2}", r1, r2, r1 / r2);
            int putere = 3;
            Console.WriteLine("{0} ^ {1} = {2}", r2, putere, r2 ^ putere);
            if(r1 == r2)
                Console.WriteLine("{0} este egal cu {1}", r1, r2);
            else
            {
                if (r1 < r2)
                {
                    Console.WriteLine("{0} < {1}", r1, r2);
                }
                else
                {
                    Console.WriteLine("{0} > {1}", r1, r2);
                }
            }
        }

        class Rational
        {
            int numarator, numitor;
            public Rational(int numarator = 0, int numitor = 1)
            {
                if (numitor < 0)
                    this.numarator = -numarator;
                else
                    this.numarator = numarator;
                if (numitor == 0)
                    this.numitor = 1;
                else
                    this.numitor = Math.Abs(numitor);
                this.Ireductibil();
            }

            public override string ToString()
            {
                StringBuilder s = new StringBuilder();
                if (numitor == 1)
                    s.AppendFormat("{0}", numarator);
                else
                    if (numarator == 0)
                        s.AppendFormat("0");
                    else
                        s.AppendFormat("{0}/{1}", numarator, numitor);

                return s.ToString();
            }

            static int Cmmdc(int a, int b)
            {
                if (b == 0)
                    return a;
                else
                    return Cmmdc(b, a % b);
            }
            public void Ireductibil()
            {
                int k = Cmmdc(numarator, numitor);
                numarator /= k;
                numitor /= k;
            }

            public static Rational operator + (Rational r1, Rational r2)
            {
                return new Rational(r1.numarator * r2.numitor + r2.numarator * r1.numitor, r1.numitor * r2.numitor);
            }
            public static Rational operator -(Rational r1, Rational r2)
            {
                return new Rational(r1.numarator * r2.numitor - r2.numarator * r1.numitor, r1.numitor * r2.numitor);
            }
            public static Rational operator *(Rational r1, Rational r2)
            {
                return new Rational(r1.numarator * r2.numarator, r1.numitor * r2.numitor);
            }
            public static Rational operator /(Rational r1, Rational r2)
            {
                Rational r3 = new Rational(r2.numitor, r2.numarator);
                return r1 * r3;
            }
            public static Rational operator ^(Rational r1, int putere)
            {
                Rational r2 = new Rational(r1.numarator, r1.numitor);
                for (int i = 1; i < putere; i++)
                    r2.numarator = r2.numarator  * r1.numarator;
                for (int i = 1; i < putere; i++)
                    r2.numitor = r2.numitor * r1.numitor;
                return r2;
            }

            public static bool operator ==(Rational r1, Rational r2)
            {
                Rational r3 = new Rational(0, 0);
                if (r1.numarator * r2.numitor == r2.numarator * r1.numitor)
                    return true;
                return false;
            }
            public static bool operator !=(Rational r1, Rational r2)
            {
                return !(r1 == r2);
            }
            public static bool operator >(Rational r1, Rational r2)
            {
                if (r1.numarator * r2.numitor > r2.numarator * r1.numitor)
                    return true;
                return false;
            }
            public static bool operator >=(Rational r1, Rational r2)
            {
                if ((r1 > r2) || (r1 == r2))
                    return true;
                return false;
            }
            public static bool operator <(Rational r1, Rational r2)
            {
                return !(r1 >= r2);
            }
            public static bool operator <=(Rational r1, Rational r2)
            {
                return !(r1 > r2);
            }
        }
    }
}
