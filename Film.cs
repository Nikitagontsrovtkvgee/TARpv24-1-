namespace TARpv24__1_
{
    public class Film
    {
        public string Pealkiri { get; set; }
        public int Aasta { get; set; }
        public string Zanr { get; set; }

        public Film(string pealkiri, int aasta, string zanr)
        {
            Pealkiri = pealkiri;
            Aasta = aasta;
            Zanr = zanr;
        }
    }
}
