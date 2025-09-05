using System;

namespace TARpv24__1_
{
    internal class Osa_funktsioon
    {
        public static float Kalkulaator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;
        }

        public static string Kuu_nimetus(int Kuu_nr)
        {
            string kuu = "";
            switch (Kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "Detsember"; break;
                default: kuu = "???"; break;
            }
            return kuu;
        }

        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 12 || kuu_nr == 1 || kuu_nr == 2)
                hoo = "Talv";
            else if (kuu_nr >= 3 && kuu_nr <= 5)
                hoo = "Kevad";
            else if (kuu_nr >= 6 && kuu_nr <= 8)
                hoo = "Suvi";
            else if (kuu_nr >= 9 && kuu_nr <= 11)
                hoo = "Sügis";
            else
                hoo = "???";
            return hoo;
        }

        Console.WriteLine()
    }
}
