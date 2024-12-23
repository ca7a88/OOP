using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP_ClasaGenerica
{
    public class Stiva<T>
    {
        private T[] elem;
        private int nivel;

        public Stiva(int max)
        {
            elem = new T[max];
            nivel = -1;
        }

        public void Push(T data)
        {
            if (nivel < elem.Count() - 1)
            {
                elem[++nivel] = data;
                Console.WriteLine($"Element adaugat in stiva {data}");
            }
                
            else
                Console.WriteLine("Stiva plina!!");
        }

        public T Pop()
        {
            if (nivel >= 0)
                return elem[nivel--];
            return default;
        }

        public void Clear()
        {
            elem = new T[0];
            nivel = -1;
            Console.WriteLine("Stiva resetata.");
        }
    }
}
