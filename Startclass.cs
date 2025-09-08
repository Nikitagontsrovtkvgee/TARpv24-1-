using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            int j = 0;
            while (j<10)
            {
                Console.WriteLine(j+1);
                j++;
            }
            j=0;
            do
            {
                Console.WriteLine(j+1);
                j++;
            }
            while (j<10);

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
