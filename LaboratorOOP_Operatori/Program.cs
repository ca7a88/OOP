using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorOOP_Operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(25, 3, 2022);
            Date d2 = new Date("25/3/2024");

            Console.WriteLine("data1: {0}\ndata2: {1}", d1, d2);

            if (d1 == d2)
                Console.WriteLine("date identice");
            else
                Console.WriteLine("datele nu coincid");

            if (d1 < d2)
                Console.WriteLine("d1 < d2");
            else
                Console.WriteLine("d1 !< d2");
            if (d1 > d2)
                Console.WriteLine("d1 > d2");
            else
                Console.WriteLine("d1 !> d2");
            if (d1 <= d2)
                Console.WriteLine("d1 <= d2");
            else
                Console.WriteLine("d1 !<= d2");
            if (d1 >= d2)
                Console.WriteLine("d1 >= d2");
            else
                Console.WriteLine("d1 !>= d2");

            Console.WriteLine(Date.GetDays(d1));

            Console.WriteLine("diferenta dintre cele doua date este de {0} zile.", d1 - d2);


            Console.WriteLine();


            Time t1 = new Time(5, 23, 19, 86);
            Time t2 = new Time("3 45 21 97");

            if (t1 == t2)
                Console.WriteLine("Timpii coincid.");
            else
            {
                if (t1 < t2)
                {
                    Console.WriteLine("timp1 - timp2 = {0}", t1 - t2);
                }
                else
                {
                    Console.WriteLine("timp1 - timp2 = {0}", t2 - t1);
                }
            }
            Console.WriteLine("timp1: {0}\ntimp2: {1}", t1, t2);

            Console.WriteLine("timp1 + timp2 = {0}", t1 + t2);

            Console.WriteLine("timp1 - timp2 = {0}", t1 - t2);
        }
    }
    #region Clasa Date
    // Sa se creeze un tip de date definit de utilizator, numit "date" pentru reprezentarea datei calendaristice sub forma zi-luna-an.
    // pt. acest tip de date sa se implementeze operatorii relationali precum si o operatie pt. determinarea diferentei in numar de zile dintre doua date
    // Se vor utiliza doua modalitati de initializare a unui obiect de tip date si anume date de zi-luna-an (3 parametrii) si date de "zi.luna.an" (un parametru de tip string)
    class Date
    {
        private int zi, luna, an;
        public Date(int zi, int luna, int an)
        {
            this.zi = zi;
            this.luna = luna;
            this.an = an;
        }

        public Date(string s)
        {
            char[] separator = {'.','/',':',' '};
            string[] x = s.Split(separator);

            if (x.Length != 3)
                Console.WriteLine("Data incorecta!");
            else
            {
                this.zi = int.Parse(x[0]);
                this.luna = int.Parse(x[1]);
                this.an = int.Parse(x[2]);
            }
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}.{1}.{2}", zi, luna, an);
            return s.ToString();
        }

        public static bool operator == (Date d1, Date d2)
        {
            if ((d1.an == d2.an) && (d1.luna == d2.luna) && (d1.zi == d2.zi))
                return true;
            return false;
        }
        public static bool operator != (Date d1, Date d2)
        {
            //if (d1 == d2)
            //    return false;
            //return true;

            return !(d1 == d2);
        }

        public static bool operator < (Date d1, Date d2)
        {
            if (d1.an < d2.an)
                return true;
            if ((d1.an == d2.an) && (d1.luna < d2.luna))
                return true;
            if ((d1.an == d2.an) && (d1.luna < d2.luna) && (d1.zi < d2.zi))
                return true;
            return false;
        }
        public static bool operator <= (Date d1, Date d2)
        {
            if ((d1 < d2) || (d1 == d2))
                return true;
            return false;
        }
        public static bool operator > (Date d1, Date d2)
        {
            //if (d1 <= d2)
            //    return false;
            //return true;
            
            return !(d1 <= d2);
        }
        public static bool operator >= (Date d1, Date d2)
        {
            //if ((d1 > d2) || (d1 == d2))
            //    return true;
            //return false;

            return !(d1 < d2);
        }

        public static int GetDays(Date d)
        {
            int i, zile = 0;

            for (i = 1; i < d.an; i++)
            {
                zile += (DateTime.IsLeapYear(i)) ? 366 : 365;
            }
            for (i = 1; i < d.luna; i++)
            {
                zile += DateTime.DaysInMonth(d.an, i);
            }
            zile += d.zi;
            return zile;
        }

        public static int operator - (Date d1, Date d2)
        {
            return Math.Abs(GetDays(d1) - GetDays(d2));
        }
    }
    #endregion

    #region Clasa Time
    // Sa se creeze un tip de date definit de utilizator numit Time pentru reprezentarea timpului sub forma ore-minute-secunde-sutimi.
    // Pt. acest tip de date sa se implementeze operatiile de adunare a doi timpi respectiv de scadere precum si operatorii relationali
    // Se vor utiliza 4 modalitati de initializare a unui obiect de tip time si anume time de ore-minute time de ore-minute-secunde
    // time de ore-minute-secunde-sutimi si time de "ore:minute:secunde:sutimi"(string).
    class Time
    {
        private int ora, minut, secunda, sutime;
        public Time(int ora, int minut, int secunda = 0, int sutime = 0)
        {
            this.ora = ora;
            this.minut = minut;
            this.secunda = secunda;
            this.sutime = sutime;
        }

        public Time(string s)
        {
            char[] separator = {'.',':',' '};
            string[] x = s.Split(separator);

            if (x.Length != 4)
                Console.WriteLine("Timp incomplet!");
            else
                this.ora = int.Parse(x[0]);
                this.minut = int.Parse(x[1]);
                this.secunda = int.Parse(x[2]);
                this.sutime = int.Parse(x[3]);
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}:{1}:{2}:{3}", ora, minut, secunda, sutime);
            return s.ToString();
        }

        public static Time operator + (Time t1, Time t2)
        {
            Time t = new Time(0, 0, 0, 0);
            int k;
            t.sutime = (t1.sutime + t2.sutime) % 100;
            k = (t1.sutime + t2.sutime) / 100;
            t.secunda = (t1.secunda + t2.secunda + k) % 60;
            k = (t1.secunda + t2.secunda + k) / 60;
            t.minut = (t1.minut + t2.minut + k) % 60;
            k = (t1.minut + t2.minut + k) / 60;
            t.ora = t1.ora + t2.ora + k;
            return t;
        }
        public static Time operator -(Time t1, Time t2)                     // 5 : 23 : 19 : 86      
        {                                                                   // 3 : 45 : 21 : 97      
            Time t = new Time(0, 0, 0, 0);
            int sutimi_t1 = t1.ora * 360000 + t1.minut * 6000 + t1.secunda * 100 + t1.sutime;
            int sutimi_t2 = t2.ora * 360000 + t2.minut * 6000 + t2.secunda * 100 + t2.sutime;
            int dif_sutimi = sutimi_t1 - sutimi_t2;

            t.ora = dif_sutimi / 360000; dif_sutimi %= 360000;
            t.minut = dif_sutimi / 6000; dif_sutimi %= 6000;
            t.secunda = dif_sutimi / 100; dif_sutimi %= 100;
            t.sutime = dif_sutimi;

            return t;

            //if (t1.sutime < t2.sutime)
            //{
            //    t1.sutime += 100;
            //    t1.secunda--;
            //}
            //t.sutime = t1.sutime - t2.sutime;

            //if (t1.secunda < t2.secunda)
            //{
            //    t1.secunda += 60;
            //    t1.minut--;
            //}
            //t.secunda = t1.secunda - t2.secunda;

            //if (t1.minut < t2.minut)
            //{
            //    t1.minut += 60;
            //    t1.ora--;
            //}
            //t.minut = t1.minut - t2.minut;

            //t.ora = t1.ora - t2.ora;

            //return t;
        }

        public static bool operator ==(Time t1, Time t2)
        {
            if ((t1.ora == t2.ora) && (t1.minut == t2.minut) && (t1.secunda == t2.secunda) && (t1.sutime == t2.sutime))
                return true;
            return false;
        }
        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1.ora < t2.ora)
                return true;
            if ((t1.ora == t2.ora) && (t1.minut < t2.minut))
                return true;
            if ((t1.ora == t2.ora) && (t1.minut == t2.minut) && (t1.secunda < t2.secunda))
                return true;
            if ((t1.ora == t2.ora) && (t1.minut == t2.minut) && (t1.secunda == t2.secunda) && (t1.sutime < t2.sutime))
                return true;
            return false;
        }
        public static bool operator <=(Time t1, Time t2)
        {
            if ((t1 < t2) || (t1 == t2))
                return true;
            return false;
        }
        public static bool operator >(Time t1, Time t2)
        {
            return !(t1 <= t2);
        }
        public static bool operator >=(Time t1, Time t2)
        {
            return !(t1 < t2);
        }
    }
    #endregion
}
