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
