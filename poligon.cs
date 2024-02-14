using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2024
{
    internal class poligon
    {
        int broj_temena;
        public tacka[] teme;
        public poligon()
        {
            teme = new tacka[broj_temena];
        }
        public poligon(int n)
        {
            broj_temena = n;
            teme = new tacka[broj_temena];
        }
        public Boolean konveksan()
        {
            int plusevi = 0;
            for (int i = 0; i < teme.Length - 1; i++)
            {
                vektor prvi = new vektor(teme[i], teme[(i + 1) % broj_temena]);
                vektor drugi = new vektor(teme[(i + 1) % broj_temena], teme[(i + 2) % broj_temena]);
                if (vektor.VP(prvi, drugi) > 0) plusevi++;
            }
            if ((plusevi == 0) || plusevi == broj_temena) return true;
            else return false;
        }
    }
}
