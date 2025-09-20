using System.Collections.Generic;
using System.Linq;

namespace TARpv24__1_
{
    public class Õpilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        public Õpilane(string nimi, List<int> hinded)
        {
            Nimi = nimi;
            Hinded = hinded;
        }

        public double Keskmine()
        {
            return Hinded.Average();
        }
    }
}
