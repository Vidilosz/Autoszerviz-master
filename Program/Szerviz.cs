using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        private List<Jarmu> jarmuvek;

        public Szerviz()
        {
            this.jarmuvek = [];
        }

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine($"A jármű megérkezett a szervízbe.");
        }

        public void InformaciokListazasa()
        {
            Console.WriteLine("A szervízben lévő járművek listája:");
            foreach (var jarmu in jarmuvek)
            {
                jarmu.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            Console.WriteLine("A szervízelés megkezdődött.");
            foreach (var jarmu in jarmuvek)
            {
                if (!jarmu.SzervizSzukseges)
                {
                    Console.WriteLine($"Ennél az autónál nem kell szervíz.");
                }
                else {
                    jarmu.Szervizel(dij);
                } 
            }
            Console.WriteLine("A szervízelés befejeződött.");
        }
    }
}
