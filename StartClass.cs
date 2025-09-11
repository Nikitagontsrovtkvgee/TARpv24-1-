using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpv24__1_;

namespace TARpv24Ckeel
{
    internal class StartClass
    {
        //I.Osa. Andmetüübid, Alamfunktsioon

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.OutputEncoding = Encoding.UTF8;
            //2. Osa Valikud
            List<string> nimed = new List<string>();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i+ 1}. Nimi: ");
                nimed.Add(Console.ReadLine());
            }
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            int[] arvud = new int[10];
            int j = 0;
            while (j<10)
            {
                Console.WriteLine(j + 1);
                arvud[j] = rnd.Next(1, 101);
                j++;

            }
            foreach(int arv in arvud)
            {
                Console.WriteLine(arv); 
            }

            List<Isik> isikud = new List<Isik>();
            j=0;
            do
            {
                Console.WriteLine(j + 1);
                Isik isik = new Isik();
                Console.Write("Eesnimi: ");
                isik.eesnimi = Console.ReadLine();
                isikud.Add(isik);
                j++;
            }
            while (j < 10);
            isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            Console.WriteLine($"Kokku on {isikud.Count()} isikud");
            foreach (Isik isik in isikud)
            {
                isik.Prindi_andmed();
            }    
            Console.WriteLine($"Kolmandal kohal on {isikud[2].eesnimi} isik");
            


            int kuu_number = rnd.Next(1, 12);
            string nimetus = Osa1_funktisoonid.Kuu_nimetus(kuu_number);
            Console.WriteLine($"Nr: {kuu_number}-{nimetus}");

            Console.WriteLine("Kas tahad dekooreerida arv-->nimitusse");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() != "jah")
            {
                Console.WriteLine("Ei taha, siis ei taha");
            }
            else
            {
                try
                {
                    Console.Write("Nr: ");
                    kuu_number = int.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktisoonid.Hooaeg(kuu_number));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            // 3. Nimed ja vanused
            List<Inimene> inimesed = new List<Inimene>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Sisesta {i + 1}. nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                inimesed.Add(new Inimene(nimi, vanus));
            }

            var statistika = Inimene.Statistika(inimesed);
            Console.WriteLine($"Vanuste summa: {statistika.Item1}");
            Console.WriteLine($"Keskmine vanus: {statistika.Item2:F2}");
            Console.WriteLine($"Vanim: {statistika.Item3.Nimi}, {statistika.Item3.Vanus} a.");
            Console.WriteLine($"Noorim: {statistika.Item4.Nimi}, {statistika.Item4.Vanus} a.");
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
        }
    }
}

