using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP_ClasaAbstractPoint
{
//    Sa se implementeze o clasa abstracta AbstractPoint care sa contina:
//- un membru data public de tip enumerare FontRepresentation cu val.posibile Polar si Rectangular
//- patru proprietati abstracte corespunzatoare coordonatelor carteziene si respectiv polare
//- metoda publica Moove cu 2 parametrii dx si dy pt.translatarea punctului
//- metoda publica Rotate(angle) cu un parametru pt.rotatia punctului
//- suprascrierea metodei ToString pt. afisarea sub forma (a, b):[r, A]
//- patru metode protejate statice care sa returneze r si A in functie de a si b si respectiv a si b in functie de r si A
//Sa se implementeze clasa Point derivata din AbstractPoint care sa contina
//- membrii data r si A (corespunzatori reprezentarii polare a unui punct).
//- un constructor cu trei parametrii si anume tipul reprezentarii si doua val.numerice
//- implementarea celor 4 proprietati din clasa de baza.
    internal class Program
    {
        public static Point PromptPoint(string prompt)
        {
            double x, y;
            AbstractPoint.PointRepresentation mode =
                AbstractPoint.PointRepresentation.Rectangular;
            Console.WriteLine(prompt);
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            return new Point(mode, x, y);
        }
        static void Main(string[] args)
        {
            AbstractPoint p1, p2, p3;
            double p1p2Dist, p2p3Dist, p3p1Dist, perimeter;

            p1 = PromptPoint("Enter first point:");
            p2 = PromptPoint("Enter second point:");
            p3 = PromptPoint("Enter third point:");

            p1.Rotate(Math.PI);
            p2.Move(1.0, 2.0);

            p1p2Dist = Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            p2p3Dist = Math.Sqrt((p2.X - p3.X) * (p2.X - p3.X) + (p2.Y - p3.Y) * (p2.Y - p3.Y));
            p3p1Dist = Math.Sqrt((p3.X - p1.X) * (p3.X - p1.X) + (p3.Y - p1.Y) * (p3.Y - p1.Y));

            perimeter = p1p2Dist + p2p3Dist + p3p1Dist;

            Console.WriteLine("Circumference:\n {0}\n {1}\n {2}\n Perimeter: {3:0.##}", p1, p2, p3, perimeter);
        }
    }
}
