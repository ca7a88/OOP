using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori2
{
    // Sa se implementeze Clasa matrice pentru un indexator bidimensional. cu valori intregi
    // precum si dimensiunea acestuia.
    // Sa se scrie un constructor cu un parametru reprezentand lungimea tabloului si un indexator unidimensional
    // in care sa se trateze eventualele erori posibile.
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrice m = new Matrice(5, 8);
            for (int i = 0; i < m.dimensiuneN * 2; i++)
            {
                for (int j = 0; j < m.dimensiuneM * 2; j++)
                {
                    m[i, j] = i;
                }
            }
            for (int i = 0; i < m.dimensiuneN * 2; i++)
            {
                for (int j = 0; j < m.dimensiuneM * 2; j++)
                {
                    int x = m[i, j];
                    if (m.err)
                        Console.Write(" e", i);
                    else
                        Console.Write(" {0}", x);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
