using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class SportAuto : Jarmu
    {
        private int teljesitmeny;

        public SportAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int teljesitmeny) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Teljesitmeny = teljesitmeny;
        }

        public int Teljesitmeny
        {
            get => teljesitmeny;
            set
            {
                if (value < 170) teljesitmeny = 170;
                else teljesitmeny = value;
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves sportautó, {KilometerOra} km-rel, teljesítmény: {Teljesitmeny} LE");
        }

        public override void Szervizel(int dij)
        {
            if (teljesitmeny > 300)
            {
                Console.WriteLine("A sportautó kora megnőtt.");
                kor+=1;
            }
            base.Szervizel(dij);
        }
    }
}
