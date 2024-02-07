using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tacka A= new tacka(0,4);
            tacka B= new tacka(1,3);
            tacka C= new tacka(3,2);
            tacka D= new tacka(5,4);

            vektor prvi = new vektor(A, B);
            vektor drugi = new vektor(C, D);
            Console.WriteLine("AB * CD = {0}", vektor.skalarni(prvi, drugi));
        }
    }
}
