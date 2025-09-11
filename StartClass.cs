using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TARpv24Ckeel
{
    internal class StartClass
    {
        //I.Osa. Andmetüübid, Alamfunktsioon

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            // 3. Osa mssiivid, List, Kordused
            List<string> nimed = new List<string>();

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"{i + 1}. Nimi: ");
                nimed.Add(Console.ReadLine());
            }
            foreach (string nimi in nimed)
            {
                Console.WriteLine($"Nimi:{nimi}");
            }
            int[] arvud = new int[10];


            int j = 0;
            while (j<10) 
            {
                Console.WriteLine(j + 1);
                arvud[j] = rnd.Next(1, 101);
                j++;
            }
            foreach (var arv in arvud)
            {
                Console.WriteLine(arv);
            }

            List<Isiki> isikud = new List<Isiki>();

            j = 0;
            do
            {
                Console.WriteLine(j+1);
                Isiki isik = new Isiki();
                Console.Write("Eesnimi: ");
                isik.eesnimi = Console.ReadLine();
                isikud.Add(isik);
                j++;
            } while (j < 10); // classical writing of do / while

            isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            Console.WriteLine($"Kooku on {isikud.Count()} isikud");
            foreach (Isiki isik in isikud)
            {
                isik.Prindi_andmed();
            }
            Console.WriteLine($"Kolmandal kohal on {isikud[2].eesnimi} isik");


            //2. Osa Valikud
            //int kuu_number = rnd.Next(1, 12);
            //string nimetus = Osa1_funktisoonid.Kuu_nimetus(kuu_number);
            //Console.WriteLine($"Nr: {kuu_number}-{nimetus}");

            //Console.WriteLine("Kas tahad dekooreerida arv-->nimitusse");
            //string vastus = Console.ReadLine();
            //if (vastus.ToLower() != "jah")
            //{
            //    Console.WriteLine("Ei taha, siis ei taha");
            //}
            //else
            //{
            //    try
            //    {
            //        Console.Write("Nr: ");
            //        kuu_number = int.Parse(Console.ReadLine());
            //        Console.WriteLine(Osa1_funktisoonid.Hooaeg(kuu_number));
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }

            //}

            // harjutus 1
            Console.WriteLine("Mul on amnesia aga ma arvan, et sa oled Juku. Kas ma olen õige?");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "jah" && answer.ToLower() != "ja")
            {
                Console.WriteLine("awh, 3:");
            }
            else
            {
                try
                {
                    Console.WriteLine("Kui vana sa oled? (bro think he is in disco elysium)");
                    int answer2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktisoonid.KinoPilet(answer2));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            // harjutus 2
            Console.WriteLine("Mul on amnesia aga ma arvan (again), et nad on pinginaabrid? Miliseid neda nimid on?");
            string tablets0 = Console.ReadLine();
            Console.WriteLine("ja...");
            string tablets1 = Console.ReadLine();
            if (tablets0 != "Maksim" || tablets1 != "Nikita")
            {
                Console.WriteLine("Brotha, do you have amnesia as well?");
            }
            else
            {
                try
                {
                    Console.WriteLine("Oh... Tanan!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            // harjutus 3

          
           
            Osa1_funktisoonid.CalculateRenovation();
            

            // Harjutus 4

            Console.Write("Sisesta soodushind (€): ");
            double soodusHind = double.Parse(Console.ReadLine());

            double algHind = soodusHind / 0.7;

            Console.WriteLine($"Alghind enne 30% soodustust oli {algHind:F2} €.");

            // Harjutus 5
            Console.Write("Sisesta toa temperatuur (°C): ");
            double temperatuur = double.Parse(Console.ReadLine());

            if (temperatuur > 18)
            {
                Console.WriteLine("Temperatuur on üle 18 °C – toasoojus on sobiv.");
            }
            else
            {
                Console.WriteLine("Temperatuur on 18 °C või madalam – võiks olla soojem (soovitav talvel vähemalt 19 °C).");
            }

            // Harjutus 6
            Console.Write("Sisesta oma pikkus sentimeetrites: ");
            int pikkus = int.Parse(Console.ReadLine());

            if (pikkus < 160)
            {
                Console.WriteLine("Oled lühike.");
            }
            else if (pikkus <= 180)
            {
                Console.WriteLine("Oled keskmise pikkusega.");
            }
            else
            {
                Console.WriteLine("Oled pikk.");
            }

            Console.Write("Sisesta oma pikkus sentimeetrites: ");
            int pikkus2 = int.Parse(Console.ReadLine());

            Console.Write("Sisesta oma sugu (mees/naine): ");
            string sugu = Console.ReadLine().ToLower();

            if (sugu == "mees")
            {
                if (pikkus < 165)
                {
                    Console.WriteLine("Oled lühike mees.");
                }
                else if (pikkus <= 185)
                {
                    Console.WriteLine("Oled keskmise pikkusega mees.");
                }
                else
                {
                    Console.WriteLine("Oled pikk mees.");
                }
            }
            else if (sugu == "naine")
            {
                if (pikkus < 155)
                {
                    Console.WriteLine("Oled lühike naine.");
                }
                else if (pikkus <= 175)
                {
                    Console.WriteLine("Oled keskmise pikkusega naine.");
                }
                else
                {
                    Console.WriteLine("Oled pikk naine.");
                }
            }
            else
            {
                Console.WriteLine("Tundmatu sugu – ei saa võrrelda pikkust.");
            }

            // Harjutus 7
            Console.Write("Sisesta oma pikkus sentimeetrites: ");
            int pikkus3 = int.Parse(Console.ReadLine());

            Console.Write("Sisesta oma sugu (mees/naine): ");
            string sugu2 = Console.ReadLine().ToLower();

            // Call function
            string tulemus = Osa1_funktisoonid.LeiaPikkuse(pikkus, sugu);

            Console.WriteLine(tulemus);

            // Harjutus 8

            double total = Osa1_funktisoonid.CalculateShopping();
            Console.WriteLine($"Ostetud kraam maksab kokku {total:F2} €.");

            // tasks from 3rd theme

            // Harjutus 1

            //Random number squares
            //Task:
            //Create a class NumberProcessing with a method GenerateSquares(int min, int max) that:

            //Generates 2 random integers in the range[-100, 100] → N and M,

            //finds all integers between them(from smallest to largest), // returns the masssive

            //returns an array where each value is the square of the corresponding number.

            //In the main method, print all results together with the initial value (for example, "4 → 16").

            //Translated with DeepL.com(free version)

            int[] massive=Osa3_funktsioonid.ArvuTöötlus(-10, 10);
            foreach (int m in massive) 
            {
                Console.WriteLine(m);
            }

            // Ülesanded 2
            double[] arvud2 = Osa3_funktsioonid.Tekstisy_arvud();
            var tulemus2 = Osa3_funktsioonid.AnalüsiArve(arvud2);
            Console.WriteLine($"Summa: {tulemus2.Item1:F2}, Keskmine: {tulemus2.Item2:F2}, Viimane: {tulemus2.Item3:F2}");







            //Console.WriteLine("Yo, kas te tahate suurem ruum?");
            //float priceforpetemeeter = 20;
            //string BOBTHEBUILDER = Console.ReadLine();
            //if (BOBTHEBUILDER != "jah")
            //{
            //    Console.WriteLine("Ma olen väga kurb... 3_;");
            //}
            //else
            //{
            //    try
            //    {
            //        Console.WriteLine("Kui Palju?");
            //        float a = float.Parse(Console.ReadLine());
            //        float b = float.Parse(Console.ReadLine());
            //        float formula = a*b;
            //        Console.WriteLine(Osa1_funktisoonid.HindTrio(a, b));
            //        Console.WriteLine($"Te peate makstaa {formula*priceforpetemeeter}");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e); 
            //    }
            //}

            //Console.Write("Kas soovid teha põranda remonti? (jah/ei): ");
            //string soov = Console.ReadLine().ToLower();

            //if (soov == "jah")
            //{
            //    // Küsi toa mõõdud
            //    Console.Write("Sisesta toa pikkus meetrites: ");
            //    double pikkus = double.Parse(Console.ReadLine());

            //    Console.Write("Sisesta toa laius meetrites: ");
            //    double laius = double.Parse(Console.ReadLine());

            //    // Arvuta pindala
            //    double pindala = pikkus * laius;
            //    Console.WriteLine($"Toa põranda pindala on {pindala} m².");

            //    // Küsi remondi hind
            //    Console.Write("Sisesta põranda vahetuse hind ühe ruutmeetri kohta (€): ");
            //    double hindRuutmeetriKohta = double.Parse(Console.ReadLine());

            //    double koguHind = pindala * hindRuutmeetriKohta;
            //    Console.WriteLine($"Põranda vahetamise kogumaksumus on {koguHind} €.");
            //}
            //else
            //{
            //    Console.WriteLine("Remonti ei tehta.");
            //}



            //I.Osa. Andmetüübid, Alamfunktsioon
            //    Console.OutputEncoding = Encoding.UTF8;

            //    Console.BackgroundColor = ConsoleColor.Green;
            //    Console.ForegroundColor = ConsoleColor.DarkRed;

            //    Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
            //    string tekst=Console.ReadLine();
            //    Console.WriteLine($"{tekst}, Rööm näha"); // $ is like f in python
            //    int a = 1000;
            //    char taht = 'A'; // char is for single characters
            //    Console.Write($"Esimene arv on {a}, Siesta b =...");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Esimene arv on {0}, Siesta {1} summa on {2}", a,b,a+b);
            //    Console.WriteLine("Ujukomaarv");
            //    double d=double.Parse(Console.ReadLine());
            //    Console.WriteLine(d);
            //    float f=float.Parse(Console.ReadLine());
            //    Console.WriteLine(f);
            //    bool t = true;

            //    Console.Clear();
            //    Console.WriteLine("welcome to the calculator :3");

            //    Random rnd = new Random();
            //    a = rnd.Next(-100, 200);
            //    Console.WriteLine(a);
            //    float vastus=Osa1_funktisoonid.Kalkulator(f,a);
            //    Console.WriteLine($"Kalkulaatori tulemus : {vastus}");
        }
    }
}
