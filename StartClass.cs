using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TARpv24__1_
{
    class StartClass
    {
        static void Main(string[] args)
        {
            // --- Печатаем меню в бесконечном цикле ---
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Menüü ===");
                Console.WriteLine("1. ✅ Ülesanne 1 – Kalorite kalkulaator");
                Console.WriteLine("2. ✅ Ülesanne 7 – Korrutustabel");
                Console.WriteLine("3. ✅ Ülesanne 6 – Suurim neljakohaline arv");
                Console.WriteLine("4. ✅ Ülesanne 2 – Tekstist arvud (summa, keskmine, korrutis)");
                Console.WriteLine("5. ✅ Ülesanne 4 – Kuni märksõnani");
                Console.WriteLine("0. Välju");
                Console.Write("Vali: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        KaloriteKalkulaator();
                        break;
                    case "2":
                        Korrutustabel();
                        break;
                    case "3":
                        SuurimNeljaArv();
                        break;
                    case "4":
                        TekstistArvud();
                        break;
                    case "5":
                        KuniMarksonani();
                        break;
                    case "0":
                        return; // lõpetame programmi
                    default:
                        Console.WriteLine("Vale valik, vajuta Enter");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // === Ülesanne 1: Kalorite kalkulaator klassidega ===
        static void KaloriteKalkulaator()
        {
            Console.Clear();
            Console.WriteLine("=== Kalorite kalkulaator ===");

            // Loome nimekiri toodetest (manuaalselt, aga hiljem saab lugeda failist)
            List<Toode> tooted = new List<Toode>
            {
                new Toode("Õun", 52),
                new Toode("Kartul", 77),
                new Toode("Riis", 130),
                new Toode("Kana", 165),
                new Toode("Šokolaad", 546)
            };

            // Küsimine kasutajalt tema andmed
            Console.Write("Sisesta nimi: ");
            string nimi = Console.ReadLine();
            Console.Write("Vanus: ");
            int vanus = int.Parse(Console.ReadLine());
            Console.Write("Sugu (M/N): ");
            string sugu = Console.ReadLine();
            Console.Write("Pikkus (cm): ");
            double pikkus = double.Parse(Console.ReadLine());
            Console.Write("Kaal (kg): ");
            double kaal = double.Parse(Console.ReadLine());
            Console.Write("Aktiivsustase (1.2 - 1.9): ");
            double aktiivsus = double.Parse(Console.ReadLine());

            // Loome objekti ja arvutame energiavajaduse
            Inimene inimene = new Inimene(nimi, vanus, sugu, pikkus, kaal, aktiivsus);
            double vajadus = inimene.ArvutaKalorivajadus();

            Console.WriteLine($"\n{inimene.Nimi} päevane energiavajadus: {vajadus:F0} kcal\n");

            // Arvutame iga toote puhul, mitu grammi võib süüa
            foreach (var toode in tooted)
            {
                double grammid = (vajadus / toode.Kalorid100g) * 100;
                Console.WriteLine($"{toode.Nimi,-10} → {grammid:F0} g");
            }

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

        // === Ülesanne 7: Korrutustabel ===
        static void Korrutustabel()
        {
            Console.Clear();
            Console.WriteLine("=== Korrutustabel ===");

            Console.Write("Sisesta ridade arv: ");
            int read = int.Parse(Console.ReadLine());
            Console.Write("Sisesta veergude arv: ");
            int veerud = int.Parse(Console.ReadLine());

            // Loome korrutustabeli ja kuvame ekraanile
            int[,] tabel = Harjutused.Tabel.GenereeriKorrutustabel(read, veerud);

            // Küsimine kasutajalt: näiteks "7 8"
            Console.Write("\nSisesta kaks arvu (nt 7 8): ");
            string[] sisend = Console.ReadLine().Split(' ');
            int a = int.Parse(sisend[0]);
            int b = int.Parse(sisend[1]);
            Harjutused.Tabel.OtsiTulemus(tabel, a, b);

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

        // === Ülesanne 6: Suurim neljakohaline arv ===
        static void SuurimNeljaArv()
        {
            Console.Clear();
            Console.WriteLine("=== Suurim neljakohaline arv ===");

            Console.WriteLine("Sisesta 4 ühekohalist arvu (nt 3 7 1 9): ");
            string[] osad = Console.ReadLine().Split(' ');
            int[] arvud = Array.ConvertAll(osad, int.Parse);

            int tulemus = Harjutused.SuurimNeliarv(arvud);
            Console.WriteLine($"Suurim arv: {tulemus}");

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

        // === Ülesanne 2: Tekstist arvud (summa, keskmine, korrutis) ===
        static void TekstistArvud()
        {
            Console.Clear();
            Console.WriteLine("=== Tekstist arvud ===");

            // Sisend (nt "1, 2, 3" või "1 2 3")
            double[] arvud = Harjutused.Tekstist_arvud();

            // Analüüs (summa, keskmine, korrutis)
            var (summa, keskmine, korrutis) = Harjutused.AnaluusiArve(arvud);

            Console.WriteLine($"Summa = {summa}");
            Console.WriteLine($"Keskmine = {keskmine}");
            Console.WriteLine($"Korrutis = {korrutis}");

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

        // === Ülesanne 4: Kuni märksõnani ===
        static void KuniMarksonani()
        {
            Console.Clear();
            Console.WriteLine("=== Märksõna arvamine ===");

            Console.Write("Sisesta märksõna: ");
            string marksona = Console.ReadLine();

            // Tsükkel töötab seni, kuni kasutaja ei kirjuta õiget sõna
            string vastus = Harjutused.KuniMarksonani(marksona);
            Console.WriteLine($"Tubli! Märksõna oli {vastus}");

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
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
