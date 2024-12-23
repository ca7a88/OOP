using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete
{
    internal class Cub : IForma3d
    {
        public double latura;
        string s = "cub";

        public Cub(double l)
        {
            latura = l;
        }

        public double Volum()
        {
            return (latura * latura * latura);
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
