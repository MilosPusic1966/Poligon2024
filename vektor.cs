using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2024
{
    internal class vektor
    {
        public tacka pocetak, kraj;
        public vektor()
        {

        }
        public vektor(tacka pocetak, tacka kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }
        public static tacka vektor_c(vektor A)
        {
            tacka nova = new tacka();
            nova.x = A.kraj.x - A.pocetak.x;
            nova.y = A.kraj.y - A.pocetak.y;
            return nova;
        }
        public static double skalarni(vektor A, vektor B)
        {
            tacka A_c = vektor_c(A);
            tacka B_c = vektor_c(B);
            double skalarni = A_c.x * B_c.x + A_c.y * B_c.y;
            return skalarni;
        }
    }
}
