using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori1
{
    internal class Tablou
    {
        int[] a;
        public int dimensiune;
        public bool err;

        public Tablou(int lungime)
        {
            a = new int[lungime];
            dimensiune = lungime;
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < dimensiune)
                {
                    err = false;
                    return a[index];
                }
                else
                {
                    err = true;
                    return -1;
                }
            }
            set
            {
                if (index >= 0 && index < dimensiune)
                {
                    a[index] = value;
                    err = false;
                }
                else
                    err = true;
            }
        }
    }
}
