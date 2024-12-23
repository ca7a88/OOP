using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori5
{
    internal class Names
    {
        public int size;
        string[] name;

        public Names(int n)
        {
            size = n;
            name = new string[n];
            for (int i = 0; i < size; i++)
                name[i] = "N.A.";
        }

        public string this[int index]
        {
            get
            {
                return (index >= 0 && index < size) ? name[index] : "";
            }
            set
            {
                if (index >= 0 && index < size)
                    name[index] = value;
            }
        }
        public int this[string nm]
        {
            get
            {
                int index = 0;
                while (index++ < size)
                {
                    if (string.Compare(name[index], nm) == 0)
                        return index;
                }
                return -1;
            }
        }
    }
}
