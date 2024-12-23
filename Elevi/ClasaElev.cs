using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Elevi
{
    internal class Elev
    {
        public string Nume { get; }
        public string Prenume { get; }
        public double MedieNote { get; }

        public Elev(string line)
        {
            string[] parts = line.Split(' ');
            Nume = parts[0];
            Prenume = parts[1];
            int n = int.Parse(parts[2]);
            double sum = 0;
            for (int i = 3; i <= n + 2; i++)
            {
                sum += double.Parse(parts[i]);
            }
            MedieNote = sum/n;
        }

        public override string ToString()
        {
            return $"{Nume} {Prenume} {MedieNote:0.##}"; // <-- INTREABA
        }
    }

    class SortByMean : IComparer<Elev>
    {
        public int Compare(Elev e1, Elev e2)
        {
            if (e1.MedieNote < e2.MedieNote)
                return 1;
            if (e1.MedieNote > e2.MedieNote)
                return -1;
            return string.Compare(e1.Nume, e2.Nume);
        }
    }
}
