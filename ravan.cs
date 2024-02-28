using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2024
{
    internal class ravan
    {
        static public int SIS(vektor AB, tacka C, tacka D)
        {
            vektor AC = new vektor(AB.pocetak, C);
            vektor AD = new vektor(AB.pocetak, D);
            double k1 = vektor.VP(AB, AC);
            double k2 = vektor.VP(AB, AD);
            if (k1 * k2 > 0) return 0;
            else if (k1 * k2 == 0) return 1;
            else return 2;
        }
        static public Boolean presek(vektor AB, vektor CD)
        {
            if (SIS(AB, CD.pocetak, CD.kraj) * SIS(CD, AB.pocetak, AB.kraj) > 0) return true;
            else return false;
        }
    }
}
