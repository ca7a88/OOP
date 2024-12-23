using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori3
{
    internal class Putere3
    {
        public int this[int index]
        {
            get
            {
                if (index >= 0)
                    return (int)Math.Pow(3, index);
                else
                    return 0;
            }
        }
    }
}
