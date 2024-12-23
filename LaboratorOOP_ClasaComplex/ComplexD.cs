using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP_ClasaComplex
{
        // Sa se implementeze clasa "ComplexD" derivata din clasa complex.
        // Noua clasa va suprascrie metoda (nu operatorul) de ridicare la putere
        // utilizand forma trigonometrica a unui numar complex si va contine in plus
        // o metoda care sa returneze distanta de la un numar complex la o multime de numere complexe.
    internal class ComplexD : Complex
    {
        public ComplexD(double real, double imaginar)
        {
            this.real = real;
            this.imaginar = imaginar;
        }

        public override string RidicareLaPutere(int putere)
        {
            double r = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginar, 2));
            double fi = Math.Atan(imaginar / real);

            return String.Format("{0:0.##}", Math.Pow(real, putere)) + " " + " ( cos " +
                String.Format("{0:0.##}", putere * fi) + " + i * sin " +
                String.Format("{0:0.##}", putere * fi) + " )";
        }

        public void dist()
        {
            Console.Write("n = ");
            int j = 1, n = Convert.ToInt32(Console.ReadLine());

            double x, y, d = double.MaxValue, dd;
            for (int i = 0; i < n; i++)
            {
                Console.Write("x{0} = ", i + 1);
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y{0} = ", i + 1);
                y = Convert.ToDouble(Console.ReadLine());
                dd = Math.Sqrt(Math.Pow(real - x, 2) + Math.Pow(imaginar - y, 2));
                if (d > dd)
                {
                    j = i + 1;
                    d = dd;
                }
            }
            Console.WriteLine("Distanta minima este fata de punctul (x{0},y{0}) si are valoarea {1:0.00}.", j, d);
        }
    }
}
