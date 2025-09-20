namespace TARpv24__1_
{
    public class Valuuta
    {
        public string Nimetus { get; set; }
        public double KurssEurSuhte { get; set; } // 1 EUR = x valuutat

        public Valuuta(string nimetus, double kurssEurSuhte)
        {
            Nimetus = nimetus;
            KurssEurSuhte = kurssEurSuhte;
        }
    }
}
