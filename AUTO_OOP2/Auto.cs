using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTO_OOP2
{
    internal class Auto
    {
        private string znacka;
        private double spotreba;
        private int ujetoCelkem = 0;
        private DateTime okamzikRozjezdu;
        private double dobaJizdyCelkem;

        public bool Jede
        { 
            get;
            private set;
        }


        public  Auto(string znacka, double spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            ujetoCelkem = 0;
            dobaJizdyCelkem = 0;
            Jede = false;
        }
        public void Rozjed()
        {
            Jede = true;
            okamzikRozjezdu = DateTime.Now;
        }
        public void Zastav(int km)
        {
            if (Jede)
            {
                ujetoCelkem += km;
                dobaJizdyCelkem += (DateTime.Now - okamzikRozjezdu).TotalMinutes;
            }
            Jede = false;
        }
        public int Vrat()
        {
            return ujetoCelkem;
        }
        public double CelkovaSpotreba()
        {
            return ujetoCelkem / 100 * spotreba;
        }
        public override string ToString()
        {
            return string.Format("Auto: {0}, ma ujeto: {1}, doba jizdy je: {2}, celkova spotreba je: {3}.", znacka, Vrat(), dobaJizdyCelkem, CelkovaSpotreba());
        }

    }
}
