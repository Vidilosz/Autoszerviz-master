using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, bool szervizSzukseges) : base(rendszam, kor, kilometerOra, uzemanyagSzint, szervizSzukseges)
        {
        }
    }
}
