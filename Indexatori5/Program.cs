using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori5
{
    // Sa se implementeze o clasa Names pentru reprez. unei liste de nume (tablou unidimensional cu val. de tip string).
    // Constructorul initializeaza toate elementele din lista cu o val. predefinita.
    // Clasa va contine si un indexator de tip intreg care va accesa valoarea de sir aflata pe o anumita pozitie
    // si care va trata exceptiile posibile (index out of range),
    // precum si suprascrierea acestuia intr-un indexator de tip string (doar pt. get)
    // care va returna pozitia pe care se afla o anumita valoare din sir.
    internal class Program
    {
        static void Main(string[] args)
        {
            Names n = new Names(5);
            for (int i = 2; i < n.size; i++)
                n[i] = "A";
            for (int i = 0; i < n.size; i++)
                Console.WriteLine("{0}\t", n[i]);

            Console.WriteLine("\nFinding A on index {0}.\n\n", n["A"]);
        }
    }
}
