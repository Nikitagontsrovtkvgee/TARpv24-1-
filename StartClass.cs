using System;
using System.Collections.Generic;

namespace TARpv24__1_
{
    internal class StartClass
    {
        static void Main(string[] args)
        {
            // Harjutus 1
            ArvuToo arvuToo = new ArvuToo();
            arvuToo.GenereeriRuudud(1, 10);

            // Harjutus 2
            double[] arvud = Harjutused.Tekstist_arvud();
            var anal = Harjutused.AnaluusiArve(arvud);
            Console.WriteLine($"Summa: {anal.Item1}, Keskmine: {anal.Item2}, Korrutis: {anal.Item3}");

            // Harjutus 3
            List<Inimene> inimesed = new List<Inimene>
            {
                new Inimene("Mati", 25),
                new Inimene("Kati", 30),
                new Inimene("Juhan", 19)
            };
            var stat = Inimene.Statistika(inimesed);
            Console.WriteLine($"Summa: {stat.Item1}, Keskmine: {stat.Item2}, Vanim: {stat.Item3.Nimi}, Noorim: {stat.Item4.Nimi}");

            // Harjutus 4
            string vastus = Harjutused.KuniMarksonani("stopp");
            Console.WriteLine("Sa arvasid ära: " + vastus);
        }
    }
}

//Console.OutputEncoding = Encoding.UTF8;
//Console.BackgroundColor = ConsoleColor.Green;
//Console.ForegroundColor = ConsoleColor.Blue;

//Console.WriteLine("Tere tulemast: Mis on sinu nimi?");
//string tekst = Console.ReadLine();
//Console.WriteLine($"{tekst}, Rõõm näha");

//int a = 1000;
//Console.WriteLine($"Esimene arv on {a}, Sisesta b=...");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"Summa on {a + b}");

//Console.Write("Sisesta double arv: ");
//double d = double.Parse(Console.ReadLine());
//Console.WriteLine(d);

//Console.Write("Sisesta float arv: ");
//float f = float.Parse(Console.ReadLine());
//Console.WriteLine(f);

//a = rnd.Next(-100, 200);
//Console.WriteLine($"Juhuslik arv: {a}");
//float tulemus = Osa_funktsioon.Kalkulaator(f, a);
//Console.WriteLine($"Kalkulaatori tulemus: {tulemus}");
