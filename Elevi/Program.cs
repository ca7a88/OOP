using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Elevi
{
    // Se considera un fisier text de intrare avand liniile de forma
    // (nume prenume n nota1 ... notan) unde n reprezinta numarul notelor.
    // Datele din fisier se adauga intr-o colectie generica prin intermediul unei clase denumite "Elev"
    // avand ca membrii data numele prenumele si media aritmetica a notelor.
    // Sa se afiseze intr-un fisier de iesire lista inregistrarilor sortate descrescator in functie de medie
    // iar pentru medii egale ordinea alfabetica in functie de nume si prenume.
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader file = new StreamReader(@"../../TextFile1.txt");
            List<Elev> elevi = new List<Elev>();
            string line;
            while ((line = file.ReadLine()) != null)
            {
                elevi.Add(new Elev(line));
            }

            elevi.Sort(new SortByMean());

            TextWriter file2 = new StreamWriter(@"../../TextFile2.txt");
            foreach (object o in elevi)
                file2.WriteLine(o);
            file2.Close();
        }
    }
}
