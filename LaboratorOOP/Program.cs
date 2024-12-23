using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clasa c1 = new Clasa();
            // Clasa c2 = new Clasa();

            //Console.Write("a = ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //double b = double.Parse(Console.ReadLine());
            //Operatii o1 = new Operatii(a, b);
            //Console.WriteLine($"{a} - {b}");
            //Console.WriteLine("a + b = {0:0.00}", o1.Adunare());
            //Console.WriteLine("a - b = {0:0.00}", o1.Scadere());
            //Console.WriteLine("a x b = {0:0.00}", o1.Inmultire());
            //Console.WriteLine("a : b = {0:0.00}", o1.Impartire());

            int c = int.Parse(Console.ReadLine());
            Stelute s = new Stelute(c);
            s.Afisare();
        }
    }

    internal class Nimic
    {

    }

    internal class Clasa
    {

        public Clasa()
        {
            Console.WriteLine("Hello World!");
        }

        static Clasa()
        {
            Console.WriteLine("Afisare");
        }

        private Clasa(string parametru)
        {
            Console.WriteLine("Constructor privat");            // Constructorul PRIVAT este folosit 
        }

        ~Clasa()
        {
            Console.WriteLine("Memoria a fost eliberata de destructor.");           // Nu este recomandata folosirea lui
                                                                                    // intrucat garbage collectorul elibereaza
                                                                                    // memoria
        }
    }

    internal class Operatii
    {
        double a, b;
        public Operatii(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Adunare()
        {
            return a + b;
        }

        public double Scadere()
        {
            return a - b;
        }

        public double Inmultire()
        {
            return a * b;
        }

        public double Impartire()
        {
            return a / b;
        }
    }

    public class Stelute
    {
        int n;
        public Stelute(int n)
        {
            this.n = n;
        }

        public void Afisare()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    // Tema:
    // Se considera clasa dreptunghi avand caracteristicile lungime si latime
    // Sa se scrie un constructor, o proprietate si o autoproprietate
    // Sa se carculeze in Main aria prin intermediul proprietatilor
    // se recomanda ca membrii data sa fie privati
}
