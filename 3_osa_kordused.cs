using System;
using System.Collections.Generic;
using System.Linq;

namespace TARpv24__1_
{
    public static class Harjutused
    {
        // Harjutus 2
        public static double[] Tekstist_arvud()
        {
            Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult: ");
            string sisend = Console.ReadLine() ?? "";
            char[] eraldajad = { ' ', ',' };
            string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);
            double[] arvud = Array.ConvertAll(osad, double.Parse);
            return arvud;
        }

        // 🔥 Новая версия для StartClass
        public static double[] TekstistArvudKasutajalt()
        {
            Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult:");
            string sisend = Console.ReadLine();

            string[] osad = sisend.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(osad, double.Parse);
        }

        public static Tuple<double, double, double> AnaluusiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }

        // Harjutus 4
        public static string KuniMarksonani(string marksõna)
        {
            string fraas;
            do
            {
                Console.WriteLine("Arvate ära");
                fraas = Console.ReadLine() ?? "";
            }
            while (fraas.ToLower() != marksõna.ToLower());

            return fraas;
        }

        //harjutus 6
        public static int SuurimNeliarv(int[] arvud)
        {
            foreach (int arv in arvud)
            {
                if (arv < 0 || arv > 9)
                    throw new ArgumentException("Kõik arvud peavad olema ühekohalised (0–9).");
            }

            Array.Sort(arvud);
            Array.Reverse(arvud);

            int tulemus = 0;
            foreach (int n in arvud)
            {
                tulemus = tulemus * 10 + n;
            }

            return tulemus;
        }

        //harjutus 7
        public static class Tabel
        {
            public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
            {
                int[,] korrutustabel = new int[ridadeArv, veergudeArv];

                for (int r = 1; r <= ridadeArv; r++)
                {
                    for (int v = 1; v <= veergudeArv; v++)
                    {
                        korrutustabel[r - 1, v - 1] = r * v;
                        Console.Write((r * v).ToString().PadLeft(5));
                    }
                    Console.WriteLine();
                }

                return korrutustabel;
            }

            public static void OtsiTulemus(int[,] tabel, int a, int b)
            {
                if (a <= tabel.GetLength(0) && b <= tabel.GetLength(1))
                {
                    Console.WriteLine($"{a} x {b} = {tabel[a - 1, b - 1]}");
                }
                else
                {
                    Console.WriteLine($"Viga: {a} või {b} ületab tabeli mõõtmeid.");
                }
            }
        }
    }
}
