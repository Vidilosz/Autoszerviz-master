using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        protected string rendszam;
        protected int kor;
        protected int kilometerOra;
        protected int uzemanyagSzint;
        protected bool szervizSzukseges;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }

        public string Rendszam
        {
            get => rendszam;
            set => rendszam = string.IsNullOrWhiteSpace(value) ? "ISMERETLEN" : value;
        }

        public int Kor
        {
            get => kor;
            set
            {
                if (value < 0) kor = 0;
                else if (value > 50) kor = 50;
                else kor = value;
            }
        }

        public int KilometerOra
        {
            get => kilometerOra;
            set => kilometerOra = value < 0 ? 0 : value;
        }

        public int UzemanyagSzint
        {
            get => uzemanyagSzint;
            set
            {
                if (value < 0) uzemanyagSzint = 0;
                else if (value > 100) uzemanyagSzint = 100;
                else uzemanyagSzint = value;
            }
        }
        public bool SzervizSzukseges => kilometerOra >= 200000;

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam}-{Kor} éves a jármű, {KilometerOra} km-rel");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            UzemanyagSzint -= 10;
            Console.WriteLine("A jármű szervizelés megtörtént.");
        }
    }
}
