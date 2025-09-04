using System;
using System.Text;

namespace TARpv24__1_
{
	internal class Startclass
	{
		public static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Blue;
			
			
			Console.WriteLine("Tere tulemast: Mis on sinu nimi?");
			string tekst=Console.ReadLine();
			Console.WriteLine($"{tekst}, Rõõm näha");
			int a = 1000;
			char taht = 'A';
			Console.WriteLine($"Esimene arv on {a}, Sisesta b=...");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine($"Esimene arv on {a}, Sisesta (1). Summa on (2)", a,b,a+b);
			Console.WriteLine("F");
			double d = double.Parse(Console.ReadLine());
			Console.WriteLine(d);
			float f = float.Parse(Console.ReadLine());
			Console.WriteLine(f);
			bool t = true;

			Random rnd = new Random();
			a = rnd.Next(-100, 200);
			Console.WriteLine(a);
			float vastus=1Osa_funktsioon.Kalkulaator(f,a);
			Console.WriteLine($"Kalkulaatori tulemus: {vastus}");
		}
	}
}
