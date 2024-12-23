using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori4
{
    // Sa se implementeze o clasa care sa contina un indexator care returneaza puterile reale pozitive ale lui 3.

    internal class Program
    {
        static void Main(string[] args)
        {
            PutereRP3 p = new PutereRP3();
            for (double i = 0; i < 1; i+=0.1)
            {
                Console.WriteLine("3^{0:0.#}={1:0.##}", i, p[i]);
            }
        }
    }
}
