using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori1
{
    // Sa se implementeze clasa tablou cu membrii data un tablou unidimensional cu valori intregi
    // precum si dimensiunea acestuia.
    // Sa se scrie un constructor cu un parametru reprezentand lungimea tabloului si un indexator unidimensional
    // in care sa se trateze eventualele erori posibile.
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablou t = new Tablou(5);
            for (int i = 0; i < t.dimensiune * 2; i++)
                t[i] = 10 * i;
            for (int i = 0; i < t.dimensiune * 2; i++)
            {
                int x = t[i];
                if (t.err)
                    Console.Write("\nt[{0}] depaseste marginile", i);
                else
                    Console.Write("{0}\t", x);
            }
            Console.WriteLine("\n");
        }
    }
}
