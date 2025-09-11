using System;
//harjutus 1
class ArvuTöötlus
{
    public int[] GenereeriRuudud(int min, int max)
    {
        Random rnd = new Random();
        int N = rnd.Next(min, max + 1);
        int M = rnd.Next(min, max + 1);

        Console.WriteLine("Genereeritud arvud: " + N + " ja " + M);

        int start = Math.Min(N, M);
        int end = Math.Max(N, M);

        int[] ruudud = new int[end - start + 1];

        for (int i = 0; i < ruudud.Length; i++)
        {
            int arv = start + i;
            ruudud[i] = arv * arv;
            Console.WriteLine(arv + " -> " + ruudud[i]);
        }

        return ruudud;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArvuTöötlus at = new ArvuTöötlus();
        at.GenereeriRuudud(-100, 100);
    }
}

//harjutus 2
public static double[] Tekstist_arvud()
{
    Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult: ");
    string sisend = Console.ReadLine();
    char[] eraldajad = new char[] {' '};//

    string[] osad = sisend.Split(eraldajad, String)
}
public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
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

//harjutus 3
class Inimene
{
    public string Nimi { get; set; }
    public int Vanus { get; set; }

    public Inimene(string nimi, int vanus)
    {
        Nimi = nimi;
        Vanus = vanus;
    }

    public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
    {
        int summa = 0;
        foreach (var inimene in inimesed)
        {
            summa += inimene.Vanus;
        }

        double keskmine = (double)summa / inimesed.Count;

        // Leia vanim ja noorim
        Inimene vanim = inimesed[0];
        Inimene noorim = inimesed[0];

        foreach (var inimene in inimesed)
        {
            if (inimene.Vanus > vanim.Vanus)
                vanim = inimene;
            if (inimene.Vanus < noorim.Vanus)
                noorim = inimene;
        }

        return Tuple.Create(summa, keskmine, vanim, noorim);
    }
}

//harjutus 4
public class string KuniMarksonani(string marksõna)
{
    string fraas = "";
    do
    {
        Console.WriteLine("Arvate ära");
        fraas = Console.ReadLine();
        while (fraas.ToLower() != marksõna.ToLower()) ;
        return fraas;
    }
}

//harjutus 5
