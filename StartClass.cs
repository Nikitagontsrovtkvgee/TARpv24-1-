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
                Console.WriteLine("6. ✅ Ülesanne 2 – Maakonnad ja pealinnad");
                Console.WriteLine("7. ✅ Ülesanne 3 – Õpilased ja hinnete analüüs");
                Console.WriteLine("8. ✅ Ülesanne 4 – Filmide kogu");
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
                    case "6":
                        MaakonnadJaPealinnad();
                        break;
                    case "7":
                        ÕpilasedAnalüüs();
                        break;
                    case "8":
                        FilmideKogu();
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

        //Ülesanne 1: Kalorite kalkulaator klassidega
        static void KaloriteKalkulaator()
        {
            Console.Clear();
            Console.WriteLine("Kalorite kalkulaator");

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

        //Ülesanne 7: Korrutustabel
        static void Korrutustabel()
        {
            Console.Clear();
            Console.WriteLine("Korrutustabel");

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

        //Ülesanne 6: Suurim neljakohaline arv
        static void SuurimNeljaArv()
        {
            Console.Clear();
            Console.WriteLine("Suurim neljakohaline arv");

            Console.WriteLine("Sisesta 4 ühekohalist arvu (nt 3 7 1 9): ");
            string[] osad = Console.ReadLine().Split(' ');
            int[] arvud = Array.ConvertAll(osad, int.Parse);

            int tulemus = Harjutused.SuurimNeliarv(arvud);
            Console.WriteLine($"Suurim arv: {tulemus}");

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

        //Ülesanne 2: Tekstist arvud (summa, keskmine, korrutis)
        static void TekstistArvud()
        {
            Console.Clear();
            Console.WriteLine("Tekstist arvud");

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

        //Ülesanne 4: Kuni märksõnani
        static void KuniMarksonani()
        {
            Console.Clear();
            Console.WriteLine("Märksõna arvamine");

            Console.Write("Sisesta märksõna: ");
            string marksona = Console.ReadLine();

            // Tsükkel töötab seni, kuni kasutaja ei kirjuta õiget sõna
            string vastus = Harjutused.KuniMarksonani(marksona);
            Console.WriteLine($"Tubli! Märksõna oli {vastus}");

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

        //Ülesanne 2: Maakonnad ja pealinnad
        static void MaakonnadJaPealinnad()
        {
            Console.Clear();
            Console.WriteLine("Maakonnad ja pealinnad");

            Dictionary<string, string> maakonnad = new Dictionary<string, string>()
            {
                {"Harjumaa", "Tallinn"},
                {"Tartumaa", "Tartu"},
                {"Pärnumaa", "Pärnu"}
            };

            Console.WriteLine("1 - Leia pealinn maakonna järgi");
            Console.WriteLine("2 - Leia maakond pealinna järgi");
            Console.WriteLine("3 - Mängurežiim");
            Console.Write("Vali: ");
            string valik = Console.ReadLine();

            if (valik == "1")
            {
                Console.Write("Sisesta maakond: ");
                string mk = Console.ReadLine();
                if (maakonnad.ContainsKey(mk))
                    Console.WriteLine("Pealinn: " + maakonnad[mk]);
                else
                {
                    Console.Write("Ei leitud. Lisa pealinn: ");
                    string pl = Console.ReadLine();
                    maakonnad[mk] = pl;
                }
            }
            else if (valik == "2")
            {
                Console.Write("Sisesta pealinn: ");
                string pl = Console.ReadLine();
                bool leitud = false;
                foreach (var kvp in maakonnad)
                {
                    if (kvp.Value == pl)
                    {
                        Console.WriteLine("Maakond: " + kvp.Key);
                        leitud = true;
                        break;
                    }
                }
                if (!leitud)
                {
                    Console.Write("Ei leitud. Lisa maakond: ");
                    string mk = Console.ReadLine();
                    maakonnad[mk] = pl;
                }
            }
            else if (valik == "3")
            {
                Random rnd = new Random();
                List<string> keys = new List<string>(maakonnad.Keys);
                string mk = keys[rnd.Next(keys.Count)];

                Console.Write($"Mis on {mk} pealinn? ");
                string vastus = Console.ReadLine();

                if (vastus == maakonnad[mk])
                    Console.WriteLine("Õige!");
                else
                    Console.WriteLine("Vale! Õige vastus: " + maakonnad[mk]);
            }

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

        //Ül 3
        static void ÕpilasedAnalüüs()
        {
            Console.Clear();
            Console.WriteLine("Õpilased ja hinnete analüüs");

            List<Õpilane> õpilased = new List<Õpilane>()
            {
                new Õpilane("Mari", new List<int>{5, 4, 3}),
                new Õpilane("Juhan", new List<int>{4, 5, 5, 4}),
                new Õpilane("Kati", new List<int>{3, 2, 4, 5})
            };

            Console.WriteLine("\nÕpilaste keskmised hinded:");
            foreach (var õp in õpilased)
            {
                Console.WriteLine($"{õp.Nimi}: {õp.Keskmine():F2}");
            }

            var parim = õpilased.OrderByDescending(o => o.Keskmine()).First();
            Console.WriteLine($"\nParima keskmisega õpilane: {parim.Nimi}, keskmine {parim.Keskmine():F2}");

            Console.WriteLine("\nÕpilased sorteeritud keskmise järgi:");
            var sorteeritud = õpilased.OrderByDescending(o => o.Keskmine()).ToList();
            foreach (var õp in sorteeritud)
            {
                Console.WriteLine($"{õp.Nimi}: {õp.Keskmine():F2}");
            }

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

        //Ül 4
        static void FilmideKogu()
        {
            Console.Clear();
            Console.WriteLine("Filmide kogu\n");

            // Loome filmide listi
            List<Film> filmid = new List<Film>
            {
                new Film("Inception", 2010, "Sci-Fi"),
                new Film("The Dark Knight", 2008, "Action"),
                new Film("Interstellar", 2014, "Sci-Fi"),
                new Film("The Godfather", 1972, "Drama"),
                new Film("Avengers: Endgame", 2019, "Action")
            };

            // 1) Leia kõik Sci-Fi filmid
            Console.WriteLine("=== Sci-Fi filmid ===");
            var scifi = filmid.Where(f => f.Zanr == "Sci-Fi").ToList();
            foreach (var f in scifi)
                Console.WriteLine($"{f.Pealkiri} ({f.Aasta})");

            // 2) Leia uusim film
            Console.WriteLine("\n=== Uusim film ===");
            var uusim = filmid.OrderByDescending(f => f.Aasta).First();
            Console.WriteLine($"{uusim.Pealkiri} ({uusim.Aasta})");

            // 3) Grupeerime žanri järgi
            Console.WriteLine("\n=== Filmid žanrite kaupa ===");
            var grupp = filmid.GroupBy(f => f.Zanr);
            foreach (var g in grupp)
            {
                Console.WriteLine($"\nŽanr: {g.Key}");
                foreach (var f in g)
                    Console.WriteLine($" - {f.Pealkiri} ({f.Aasta})");
            }

            Console.WriteLine("\nVajuta Enter, et jätkata...");
            Console.ReadLine();
        }

    // Klass Film
    class Film
    {
        public string Pealkiri { get; set; }
        public int Aasta { get; set; }
        public string Zanr { get; set; }

        public Film(string pealkiri, int aasta, string zanr)
        {
            Pealkiri = pealkiri;
            Aasta = aasta;
            Zanr = zanr;
        }
    }

    // Klass Õpilane (jääb samaks)
    class Õpilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        public Õpilane(string nimi, List<int> hinded)
        {
            Nimi = nimi;
            Hinded = hinded;
        }

        public double Keskmine()
        {
            return Hinded.Average();
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
