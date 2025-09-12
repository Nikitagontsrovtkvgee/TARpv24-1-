using System;
using System.Collections.Generic;

namespace TARpv24__1_
{
    public class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; }      // M või N
        public double Pikkus { get; set; }    // cm
        public double Kaal { get; set; }      // kg
        public double Aktiivsus { get; set; } // 1.2 – 1.9

        // Vanem konstruktor (2 аргумента) — оставляем, чтобы старый код не ломался
        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        // Новый конструктор (6 аргументов)
        public Inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, double aktiivsus)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsus = aktiivsus;
        }

        // Функция расчёта дневной потребности в калориях
        public double ArvutaKalorivajadus()
        {
            double BMR;

            if (Sugu.ToUpper() == "M")
            {
                // Harris–Benedict BMR формула для мужчин
                BMR = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
            }
            else
            {
                // для женщин
                BMR = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);
            }

            return BMR * Aktiivsus;
        }

        // Старая статистика (оставил как было)
        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = 0;
            foreach (var inimene in inimesed)
            {
                summa += inimene.Vanus;
            }

            double keskmine = (double)summa / inimesed.Count;

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
