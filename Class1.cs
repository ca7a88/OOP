using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP_01_4
{
    // Sa se creeze un tip de date def. de utilizator pentru lucrul cu nr. complexe.
    // Sa se implementeze pt. acest tip operatiile de adunare, scadere si inmultire a doua numere complexe,
    // ridicarea la putere si afisarea in forma trigonometrica.
    // Se vor utiliza 3 modalitati de initializare a unui obiect de tipul complex si anume:
    // - complex()
    // - complex(partea reala)
    // - complex(partea reala, partea imaginara)
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1.7, 2.3);
            Complex c2 = new Complex(1.3, 2.7);
            Console.WriteLine("c1 = {0}\nc2 = {1}", c1, c2);
            Console.WriteLine("c1 + c2 = {0}", c1 + c2);
            Console.WriteLine("c1 - c2 = {0}", c1 - c2);
            Console.WriteLine("c1 * c2 = {0}", c1 * c2);
            int putere = 3;
            Console.WriteLine("c1 ^ {0} = {1}", putere, c1 ^ putere);
            Console.WriteLine("Forma trigonometrica: c1 = {0}", c1.trigo());
            Console.WriteLine("Forma trigonometrica: c2 = {0}", c2.trigo());
        }

        class Complex
        {
            protected double real, imaginar;
            public Complex(double real = 0.0, double imaginar = 0.0)
            {
                this.real = real;
                this.imaginar = imaginar;
            }

            public override string ToString()
            {
                StringBuilder s = new StringBuilder();
                if (imaginar > 0)
                    s.AppendFormat("{0:0.##} + {1:0.##}i", real, imaginar);
                else
                    if (imaginar < 0)
                    s.AppendFormat("{0:0.##} - {1:0.##}i", real, Math.Abs(imaginar));
                else
                    s.AppendFormat("{0:0.##}", real);
                return s.ToString();
            }

            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex(c1.real + c2.real, c1.imaginar + c2.imaginar);
            }

            public static Complex operator -(Complex c1, Complex c2)
            {
                return new Complex(c1.real - c2.real, c1.imaginar - c2.imaginar);
            }

            public static Complex operator *(Complex c1, Complex c2)
            {
                return new Complex(c1.real * c2.real - c1.imaginar * c2.imaginar,
                    c1.real * c2.imaginar + c1.imaginar * c2.real);
            }

            public static Complex operator ^(Complex c1, int putere)
            {
                Complex c2 = new Complex(c1.real, c1.imaginar);
                for (int i = 1; i < putere; i++)
                    c2 = c2 * c1;
                return c2;
            }

            public virtual string RidicareLaPutere(int putere)
            {
                Complex c = new Complex(real, imaginar);
                for (int i = 1; i < putere; i++)
                    c = c * this;
                return c.ToString();
            }

            public string trigo()
            {
                double r = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginar, 2));
                double fi = Math.Atan(imaginar / real);
                return String.Format("{0:0.##}", r) + " ( cos " +
                    String.Format("{0:0.##}", fi) + " + i * sin " +
                    String.Format("{0:0.##}", fi) + " )";
            }
        }
    }
}