using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaClasaDreptunghi
{
    // Tema:
    // Se considera clasa dreptunghi avand caracteristicile lungime si latime
    // Sa se scrie un constructor, o proprietate si o autoproprietate
    // Sa se carculeze in Main aria prin intermediul proprietatilor
    // se recomanda ca membrii data sa fie privati
    internal class Program
    {
        static void Main(string[] args)
        {
            Dreptunghi d = new Dreptunghi(256);
            d.Length = 0.972;
            d.Width = 9.321;

            double arie = d.Length * d.Width;
            Console.WriteLine("Aria dreptunghiului cu Id-ul {0} este {1:0.00}", d.Id, arie); 
        }
    }

    internal class Dreptunghi
    {
        private double length;
        public double Length
        {
            get { return length; }
            set { 
                if(value > 0)
                    length = value; 
                else
                    Console.WriteLine("Lungimea nu poate fi negativa sau 0.");
            }
        }

        private double width;
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    Console.WriteLine("Latimea nu poate fi negativa sau 0.");
            }
        }

        public int Id { get; set; }


        public Dreptunghi(int n)
        {
            Id = n;
        }
    }
}