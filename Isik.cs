using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24__1_
{
    internal class Isik
    {
        public string eesnimi;
        public string perenimi="Tundmatu";
        public int synniaasta=2000;
        public Isik() { }

        public Isik(string eesnimi, string perenimi)
        {
            this.eesnimi = eesnimi;
            this.perenimi = perenimi;
        }
        public void Prindi_andmed()
        {
            Console.WriteLine($"Isiku andmed: {eesnimi} {perenimi}, Sündinud: {synniaasta}");
        }







    }
}
