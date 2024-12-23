using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LaboratorOOP_Matrici
{
    // Sa se creeze un tip de date pentru lucrul cu matrici.
    // Sa se implementeze operatiile de adunare, scadere si inmultire a doua matrici,
    // ridicarea la putere si determinarea inversei.
    // Se va tine cont de dimensiunile matricilor pentru fiecare operatie.
    // Operatiile se vor implementa ca si metode cu un singur parametru cu semnificatia ca
    // operanzii sunt membrul data din clasa si parametrul respectiv.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2, m1 = 2, n2 = 2, m2 = 2;
            Matrici a = new Matrici(n1, m1);
            Matrici b = new Matrici(n2, m2);
            Console.WriteLine("Matricea A\n{0}", a);
            Console.WriteLine("Matricea B\n{0}", b);
            Console.WriteLine("A + B =\n{0}", a.Aduna(b));
            Console.WriteLine("B - A =\n{0}", b.Scade(a));
            Console.WriteLine("A * B =\n{0}", a.Inmulteste(b));
            int k = 3;
            Console.WriteLine("A ^ {0} =\n{1}", k, a.Putere(k));
            Console.WriteLine("Matricea inversa A ^ (-1)\n{0}", a.inversa());

        }

        class Matrici
        {
            private int n, m;
            private double[,] matrix;

            public Matrici(int n = 0, int m = 0)
            {
                this.n = n;
                this.m = m;
                matrix = new double[this.n, this.m];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = rnd.Next(10) /** rnd.NextDouble()*/;
                        Thread.Sleep(1);
                    }         
            }

            public override string ToString()
            {
                StringBuilder s = new StringBuilder();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        s.AppendFormat("{0,8:0.##}", matrix[i, j]);
                    s.Append("\n");
                }
                return s.ToString();
            }

            public Matrici Aduna(Matrici a)
            {
                if (a.n == n && a.m == m)
                {
                    Matrici rezultat = new Matrici(n, m);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < m; j++)
                            rezultat.matrix[i, j] = matrix[i, j] + a.matrix[i, j];
                    return rezultat;
                }
                Console.WriteLine("Matricile care nu au aceeasi dimensiune nu se pot aduna.");
                return null;
            }
            public Matrici Scade(Matrici a)
            {
                if (a.n == this.n && a.m == this.m)
                {
                    Matrici rezultat = new Matrici(n, m);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < m; j++)
                            rezultat.matrix[i, j] = matrix[i, j] - a.matrix[i, j];
                    return rezultat;
                }
                Console.WriteLine("Matricile care nu au aceeasi dimensiune nu se pot scadea.");
                return null;
            }

            public Matrici Inmulteste(Matrici a)
            {
                if (m == a.n)
                {
                    Matrici rezultat = new Matrici(n, a.m);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < a.m; j++)
                        {
                            rezultat.matrix[i, j] = 0.0;
                            for (int k = 0; k < m; k++)
                                rezultat.matrix[i, j] += matrix[i, k] * a.matrix[k, j];
                        }
                    return rezultat;
                }
                Console.WriteLine("Matricile nu se pot inmulti. Nu corespund dimensiunile.");
                return null;
            }
            public Matrici Putere(int k)
            {
                if (n == m)
                {
                    Matrici m1 = new Matrici(n, m);
                    m1.matrix = matrix;
                    Matrici rezultat = new Matrici(n, m);
                    rezultat.matrix = matrix;
                    for (int i = 1; i < k; i++)
                        rezultat = rezultat.Inmulteste(m1);
                    return rezultat;
                }
                Console.WriteLine("Matricile nu este patratica, deci nu se poate ridica la putere.");
                return null;
            }

            private double Determinant(double[,] a, int n)
            {
                int i, j;
                double d, e, aux;
                if (n == 1)
                    return a[0, 0];
                else
                {
                    d = 0.0;
                    for (j = 0; j < n; j++)
                    {
                        if (((n - 1 - j) % 2 == 1) || (j == n - 1))
                            e = a[n - 1, j];
                        else
                            e = -a[n - 1, j];
                        for (i = 0; i < n - 1; i++)
                        {
                            aux = a[i, j];
                            a[i, j] = a[i, n - 1];
                            a[i, n - 1] = aux;
                        }
                        if ((n - 1 + j) % 2 == 0)
                            d += e * Determinant(a, n - 1);
                        else
                            d -= e * Determinant(a, n - 1);
                        for (i = 0; i < n - 1; i++)
                        {
                            aux = a[i, j];
                            a[i, j] = a[i, n - 1];
                            a[i, n - 1] = aux;
                        }
                    }
                    return d;
                }
            }

            public Matrici inversa()
            {
                if(n == m)
                {
                    double d = Determinant(matrix, n);
                    if (d != 0)
                    {
                        Matrici rez = new Matrici(n, n);
                        Matrici temp = new Matrici(n, n);
                        // matricea transpusa
                        for(int i = 0; i < n; i++)
                            for (int j = 0; j < n; j++)
                                temp.matrix[i, j] = matrix[j, i];
                        double aux;
                        int semn;
                        // matricea adjuncta
                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < n; j++)
                            {
                                // interschimb linia i cu ultima linie (n - 1)
                                for (int k = 0; k < n; k++)
                                {
                                    aux = temp.matrix[i, k];
                                    temp.matrix[i, k] = temp.matrix[n - 1, k];
                                    temp.matrix[n - 1, k] = aux;
                                }
                                // interschimb coloana j cu ultima linie (n - 1)
                                for (int k = 0; k < n; k++)
                                {
                                    aux = temp.matrix[k, j];
                                    temp.matrix[k, j] = temp.matrix[k, n - 1];
                                    temp.matrix[k, n - 1] = aux;
                                }
                                // stabilim semnul pentru permutarea liniilor si a coloanelor in matrice
                                semn = 1;
                                if (((n - 1 - i) % 2 == 0) && (i != n - 1))
                                    semn *= -1;
                                if (((n - 1 - j) % 2 == 0) && (j != n - 1))
                                    semn *= -1;

                                if ((i + j) % 2 == 1)
                                    semn *= -1;
                                rez.matrix[i, j] = semn * Determinant(temp.matrix, n - 1);
                                // refac matricea
                                for (int k = 0; k < n; k++)
                                {
                                    aux = temp.matrix[i, k];
                                    temp.matrix[i, k] = temp.matrix[n - 1, k];
                                    temp.matrix[n - 1, k] = aux;
                                }
                                for (int k = 0; k < n; k++)
                                {
                                    aux = temp.matrix[k, j];
                                    temp.matrix[k, j] = temp.matrix[k, n - 1];
                                    temp.matrix[k, n - 1] = aux;
                                }
                            }
                        // matricea inversa
                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < n; j++)
                                rez.matrix[i, j] /= d;
                        return rez;
                    }
                    Console.WriteLine("Matricea nu este inversabila. Are determinantul nul.");
                    return null;
                }
                Console.WriteLine("Matricea nu se poate inversa. Nu este patratica");
                return null;
            }
        }
    }
}
