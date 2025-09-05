using System;
using System.Text;

namespace TARpv24__1_
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int Kuu_number = rnd.Next(1, 13);
            string nimetus = Osa_funktsioon.Kuu_nimetus(Kuu_number);
            Console.WriteLine($"Nr: {Kuu_number} - {nimetus}");

            Console.WriteLine("Kas tahad dekoreerida arv->nimetusse?");
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
                    Kuu_number = int.Parse(Console.ReadLine());
                    Console.WriteLine(Osa_funktsioon.Hooaeg(Kuu_number));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Tere tulemast: Mis on sinu nimi?");
            string tekst = Console.ReadLine();
            Console.WriteLine($"{tekst}, Rõõm näha");

            int a = 1000;
            Console.WriteLine($"Esimene arv on {a}, Sisesta b=...");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Summa on {a + b}");

            Console.Write("Sisesta double arv: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(d);

            Console.Write("Sisesta float arv: ");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(f);

            a = rnd.Next(-100, 200);
            Console.WriteLine($"Juhuslik arv: {a}");
            float tulemus = Osa_funktsioon.Kalkulaator(f, a);
            Console.WriteLine($"Kalkulaatori tulemus: {tulemus}");
        }
    }
}
