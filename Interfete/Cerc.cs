using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete
{
    public class Cerc : IForma2d
    {
        public double raza;
        private const float PI = 3.14159f;
        string s = "cerc";

        public Cerc(double r)
        {
            raza = r;
        }

        public double Aria()
        {
            return (PI * raza * raza);
        }

        public double LungFrontiera()
        {
            return 2 * PI * raza;
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
