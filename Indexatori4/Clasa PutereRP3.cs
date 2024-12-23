using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori4
{
    internal class PutereRP3
    {
        public double this[double index]
        {
            get
            {
                if (index >= 0)
                    return (double)Math.Pow(3, index);
                else
                    return 0;
            }
        }
    }
}
