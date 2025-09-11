using System;

namespace TARpv24__1_
{
    // Пример базовой функции
    public static class Osa1_funktsioonid
    {
        public static float Kalkulaator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;
        }

        public static string Kuu_nimetus(int kuuNr)
        {
            string[] kuud = {
                "jaanuar","veebruar","märts","aprill","mai","juuni",
                "juuli","august","september","oktoober","november","detsember"
            };
            if (kuuNr >= 1 && kuuNr <= 12)
                return kuud[kuuNr - 1];
            else
                return "Vale kuu number";
        }
    }

    public class ArvuToo
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
}
