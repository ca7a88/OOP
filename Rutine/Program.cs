using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutine
{
    // Rutine de tratare a unui eveniment

    // --> delegare corespunzatoare evenimentului
    public delegate void MyHandlerDelegate();

    class MyEvent
    {
        // declarare eveniment
        public event MyHandlerDelegate activare;

        // metoda care genereaza evenimentul
        public void Fire()
        {
            activare();
        }
    }
    class EventDemo
    {
        // rutina de tratare a evenimentului
        static void HandlerEv()
        {
            Console.WriteLine("Evenimentul s-a produs.");
        }
        public static void Main()
        {
            // creerea instantei eveniment
            MyEvent ev = new MyEvent();

            // adaugarea rutinei de tratare in lant
            ev.activare += new MyHandlerDelegate(HandlerEv);

            // lansarea evenimentului
            ev.Fire();
        }
    }
}
