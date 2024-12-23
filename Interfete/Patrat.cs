using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete
{
    internal class Patrat : IForma2d
    {
        public double latura;
        string s = "patrat";

        public Patrat(double l)
        {
            latura = l;
        }

        public double Aria()
        {
            return (latura * latura);
        }

        public double LungFrontiera()
        {
            return 4 * latura;
        }

        public string denumire
        {
            get
            {
                return s;
            }
        }
    }
}
