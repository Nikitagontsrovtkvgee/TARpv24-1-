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
    }
}
