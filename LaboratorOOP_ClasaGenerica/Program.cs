using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP_ClasaGenerica
{
    // Sa se implementeze clasa generica Stiva care sa permita stocarea unui numar maxim precizat de elemente.
    // Clasa va contine 3 metode si anume Push pt. introducerea elementelor in stiva Pop pt. extragere si Clear pt. stergerea tuturor elementelor.
    // Metodele vor contine tratarea exceptiilor. Stiva se va folosi pt. 2 tipuri de date concrete.
    internal class Program
    {
        static void Main(string[] args)
        {
            Stiva<char> st = new Stiva<char>(5);
            for (char ch = 'a'; ch <= 'f'; ch++)
                st.Push(ch);
            for (int i = 0; i < 7; i++)
            {
                char x = st.Pop();
                if(x != default)
                    Console.WriteLine($"Element scos din stiva {x}");
                else
                    Console.WriteLine("Stiva goala!!");
            }
            st.Clear();
        }
    }
}
