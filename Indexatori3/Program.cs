using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori3
{
    // Sa se implementeze o clasa care sa contina un indexator care returneaza puterile intregi pozitive ale lui 3. 

    internal class Program
    {
        static void Main(string[] args)
        {
            Putere3 p = new Putere3();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("3^{0}={1}", i, p[i]);
            }
        }
    }
}
