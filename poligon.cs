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
        tacka[] teme;
        public poligon() 
        { 
            teme = new tacka[broj_temena];
        }
        public poligon(int n)
        {
            broj_temena= n;
            teme = new tacka[broj_temena];
        }

    }
}
