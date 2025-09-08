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
