using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete
{
    // Sa se implementeze clasele Cerc si Patrat pe baza interfetei IForma2d care va contine
    // metodele Aria si Lungimea frontierei precum si proprietatea de numire de tip readonly.
    // Metodele vor fi apelate din interiorul unei alte metode care are un parametru de tipul interfetei
    // (variabila referinta de tipul IForma2d) care poate referi orice obiect care implementeaza interfata.
    internal class Program
    {
        static void DisplayInfo(IForma2d f)
        {
            Console.WriteLine("aria={0:#.##}\tlungimea frontierei={1:#.##}", f.Aria(), f.LungFrontiera());
        }

        static void DisplayInfo(IForma3d f)
        {
            Console.WriteLine("volumul={0:#.##}", f.Volum());
        }

        static void Main(string[] args)
        {
            Cerc c = new Cerc(3);
            Console.WriteLine("Afiseaza informatii despre {0}:", c.denumire);
            DisplayInfo(c);

            Console.WriteLine();

            Patrat p = new Patrat(5);
            Console.WriteLine("Afiseaza informatii despre {0}:", p.denumire);
            DisplayInfo(p);

            Console.WriteLine();

            Cub cub = new Cub(5);
            Console.WriteLine("Afiseaza informatii despre {0}:", cub.denumire);
            DisplayInfo(cub);
        }
    }
}
