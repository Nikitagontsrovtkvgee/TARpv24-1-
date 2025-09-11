using System;
using System.Collections.Generic;

namespace TARpv24__1_
{
    public class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }

        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = 0;
            foreach (var inimene in inimesed)
            {
                summa += inimene.Vanus;
            }

            double keskmine = (double)summa / inimesed.Count;

            // Leia vanim ja noorim
            Inimene vanim = inimesed[0];
            Inimene noorim = inimesed[0];

            foreach (var inimene in inimesed)
            {
                if (inimene.Vanus > vanim.Vanus)
                    vanim = inimene;
                if (inimene.Vanus < noorim.Vanus)
                    noorim = inimene;
            }

            return Tuple.Create(summa, keskmine, vanim, noorim);
        }
    }
}
