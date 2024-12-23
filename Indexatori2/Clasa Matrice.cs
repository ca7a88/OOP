using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori2
{
    internal class Matrice
    {
        int[,] a;
        public int dimensiuneN;
        public int dimensiuneM;
        public bool err;

        public Matrice(int n, int m)
        {
            a = new int[n, m];
            dimensiuneN = n; 
            dimensiuneM = m;
        }

        public int this[int indexN, int indexM]
        {
            get
            {
                if (indexN >= 0 && indexM >= 0 && indexN < dimensiuneN && indexM < dimensiuneM)
                {
                    err = false;
                    return a[indexN, indexM];
                }
                else
                    err = true;
                    return -1;
            }
            set
            {
                if (indexN >= 0 && indexM >= 0 && indexN < dimensiuneN && indexM < dimensiuneM)
                {
                    a[indexN, indexM] = value;
                    err = false;
                }
                else
                    err = true;
            }
        }
    }
}
