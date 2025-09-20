using System;
using System.Collections.Generic;
using System.Linq;

namespace TARpv24__1_
{
    class StartClass
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Menüü ===");
                Console.WriteLine("1. ✅ Kalorite kalkulaator");
                Console.WriteLine("2. ✅ Korrutustabel");
                Console.WriteLine("3. ✅ Suurim neljakohaline arv");
                Console.WriteLine("4. ✅ Tekstist arvud (summa, keskmine, korrutis)");
                Console.WriteLine("5. ✅ Kuni märksõnani");
                Console.WriteLine("6. ✅ Maakonnad ja pealinnad");
                Console.WriteLine("7. ✅ Õpilased ja hinnete analüüs");
                Console.WriteLine("8. ✅ Filmide kogu");
                Console.WriteLine("9. ✅ Arvude massiivi statistika");
                Console.WriteLine("10. ✅ Lemmikloomade register");
                Console.WriteLine("11. ✅ Valuutakalkulaator");
                Console.WriteLine("0. ❌ Välju");
                Console.Write("Vali: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1": KaloriteKalkulaator(); break;
                    case "2": Korrutustabel(); break;
                    case "3": SuurimNeljaArv(); break;
                    case "4": TekstistArvud(); break;
                    case "5": KuniMarksonani(); break;
                    case "6": MaakonnadJaPealinnad(); break;
                    case "7": ÕpilasedAnalüüs(); break;
                    case "8": FilmideKogu(); break;
                    case "9": ArvudeMassiiviStatistika(); break;
                    case "10": LemmikloomadeRegister(); break;
                    case "11": Valuutakalkulaator(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Vale valik, vajuta Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Ülesanne 1: Kalorite kalkulaator
        static void KaloriteKalkulaator()
        {
            Console.Clear();
            Console.WriteLine("Kalorite kalkulaator");

            List<Toode> tooted = new List<Toode>
            {
                new Toode("Õun", 52),
                new Toode("Kartul", 77),
                new Toode("Riis", 130),
                new Toode("Kana", 165),
                new Toode("Šokolaad", 546)
            };

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

            Inimene inimene = new Inimene(nimi, vanus, sugu, pikkus, kaal, aktiivsus);
            double vajadus = inimene.ArvutaKalorivajadus();

            Console.WriteLine($"\n{inimene.Nimi} päevane energiavajadus: {vajadus:F0} kcal\n");

            foreach (var toode in tooted)
            {
                double grammid = (vajadus / toode.Kalorid100g) * 100;
                Console.WriteLine($"{toode.Nimi,-10} → {grammid:F0} g");
            }

            Pause();
        }

        // Ülesanne 2: Korrutustabel
        static void Korrutustabel()
        {
            Console.Clear();
            Console.WriteLine("Korrutustabel");

            Console.Write("Sisesta ridade arv: ");
            int read = int.Parse(Console.ReadLine());
            Console.Write("Sisesta veergude arv: ");
            int veerud = int.Parse(Console.ReadLine());

            int[,] tabel = Harjutused.Tabel.GenereeriKorrutustabel(read, veerud);

            Console.Write("\nSisesta kaks arvu (nt 7 8): ");
            string[] sisend = Console.ReadLine().Split(' ');
            int a = int.Parse(sisend[0]);
            int b = int.Parse(sisend[1]);
            Harjutused.Tabel.OtsiTulemus(tabel, a, b);

            Pause();
        }

        // Ülesanne 3: Suurim neljakohaline arv
        static void SuurimNeljaArv()
        {
            Console.Clear();
            Console.WriteLine("Suurim neljakohaline arv");

            Console.WriteLine("Sisesta 4 ühekohalist arvu (nt 3 7 1 9): ");
            string[] osad = Console.ReadLine().Split(' ');
            int[] arvud = Array.ConvertAll(osad, int.Parse);

            int tulemus = Harjutused.SuurimNeliarv(arvud);
            Console.WriteLine($"Suurim arv: {tulemus}");

            Pause();
        }

        // Ülesanne 4: Tekstist arvud
        static void TekstistArvud()
        {
            Console.Clear();
            Console.WriteLine("Tekstist arvud");

            double[] arvud = Harjutused.TekstistArvudKasutajalt();
            var (summa, keskmine, korrutis) = Harjutused.AnaluusiArve(arvud);

            Console.WriteLine($"Summa = {summa}");
            Console.WriteLine($"Keskmine = {keskmine}");
            Console.WriteLine($"Korrutis = {korrutis}");

            Pause();
        }

        // Ülesanne 5: Kuni märksõnani
        static void KuniMarksonani()
        {
            Console.Clear();
            Console.WriteLine("Märksõna arvamine");

            Console.Write("Sisesta märksõna: ");
            string marksona = Console.ReadLine();

            string vastus = Harjutused.KuniMarksonani(marksona);
            Console.WriteLine($"Tubli! Märksõna oli {vastus}");

            Pause();
        }

        // Ülesanne 6: Maakonnad ja pealinnad
        static void MaakonnadJaPealinnad()
        {
            Console.Clear();
            Console.WriteLine("Maakonnad ja pealinnad");

            Dictionary<string, string> maakonnad = new Dictionary<string, string>
            {
                {"Harjumaa", "Tallinn"},
                {"Tartumaa", "Tartu"},
                {"Pärnumaa", "Pärnu"},
                {"Ida-Virumaa", "Jõhvi"},
                {"Lääne-Virumaa", "Rakvere"}
            };

            foreach (var m in maakonnad)
            {
                Console.WriteLine($"{m.Key} → {m.Value}");
            }

            Pause();
        }

        // Ülesanne 7: Õpilased ja hinnete analüüs
        static void ÕpilasedAnalüüs()
        {
            Console.Clear();
            Console.WriteLine("Õpilased ja hinnete analüüs");

            List<Õpilane> õpilased = new List<Õpilane>
            {
                new Õpilane("Mari", new List<int>{5, 4, 5, 3}),
                new Õpilane("Juhan", new List<int>{3, 2, 4, 3}),
                new Õpilane("Kadri", new List<int>{5, 5, 5, 5})
            };

            foreach (var õp in õpilased)
            {
                Console.WriteLine($"{õp.Nimi}: keskmine hinne = {õp.Keskmine():F2}");
            }

            Pause();
        }

        // Ülesanne 8: Filmide kogu
        static void FilmideKogu()
        {
            Console.Clear();
            Console.WriteLine("Filmide kogu");

            List<Film> filmid = new List<Film>
            {
                new Film("Inception", 2010, "Sci-Fi"),
                new Film("Titanic", 1997, "Romance"),
                new Film("Matrix", 1999, "Action")
            };

            foreach (var film in filmid)
            {
                Console.WriteLine($"{film.Pealkiri} ({film.Aasta}) – {film.Zanr}");
            }

            Pause();
        }

        // Ülesanne 9: Arvude massiivi statistika
        static void ArvudeMassiiviStatistika()
        {
            Console.Clear();
            Console.WriteLine("Arvude massiivi statistika");

            int[] arvud = { 3, 7, 1, 9, 4, 6 };

            Console.WriteLine($"Min: {arvud.Min()}");
            Console.WriteLine($"Max: {arvud.Max()}");
            Console.WriteLine($"Keskmine: {arvud.Average()}");

            Pause();
        }

        // Ülesanne 10: Lemmikloomade register
        static void LemmikloomadeRegister()
        {
            Console.Clear();
            Console.WriteLine("Lemmikloomade register");

            List<Lemmikloom> loomad = new List<Lemmikloom>
            {
                new Lemmikloom("Muri", "Koer", 5),
                new Lemmikloom("Miisu", "Kass", 3),
                new Lemmikloom("Pupsik", "Hamster", 1)
            };

            foreach (var loom in loomad)
            {
                Console.WriteLine($"{loom.Nimi}, {loom.Liik}, {loom.Vanus} aastat");
            }

            Pause();
        }

        // Ülesanne 11: Valuutakalkulaator
        static void Valuutakalkulaator()
        {
            Console.Clear();
            Console.WriteLine("Valuutakalkulaator");

            List<Valuuta> valuutad = new List<Valuuta>
            {
                new Valuuta("USD", 1.08),
                new Valuuta("GBP", 0.85),
                new Valuuta("SEK", 11.2)
            };

            Console.Write("Sisesta summa eurodes: ");
            double eur = double.Parse(Console.ReadLine());

            foreach (var v in valuutad)
            {
                Console.WriteLine($"{eur} EUR = {eur * v.KurssEurSuhte:F2} {v.Nimetus}");
            }

            Pause();
        }

        // Abimeetod
        static void Pause()
        {
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
