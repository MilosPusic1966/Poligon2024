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
            /*
            tacka A= new tacka(0,4);
            tacka B= new tacka(1,3);
            tacka C= new tacka(3,2);
            tacka D= new tacka(5,4);

            vektor prvi = new vektor(A, B);
            vektor drugi = new vektor(C, D);
            Console.WriteLine("AB * CD = {0}", vektor.skalarni(prvi, drugi));
            */
            /*
            Console.WriteLine("Pritisni:");
            Console.WriteLine("1: Unos");
            Console.WriteLine("2: SAVE");
            Console.WriteLine("3: LOAD");
            Console.WriteLine("0: EXIT");
            int izbor = Convert.ToInt32(Console.ReadLine());
            if (izbor == 1)
            {
                Console.WriteLine("koliko temena?");
                int br_temena = Convert.ToInt32(Console.ReadLine());
                poligon prvi = new poligon(br_temena);
                for (int i = 0; i < br_temena; i++)
                {
                       // Unesite x za teme A(i)
                       // Unesite y za teme A(i)
                    
                }
            }
            
            tacka A = new tacka(0, -1);
            tacka B = new tacka(5.866, 6.5);
            tacka C = new tacka(2, 0);
            tacka D = new tacka(5, 6);

            vektor prvi = new vektor(C, A);
            vektor drugi = new vektor(D, B);
            double stampa = vektor.ugao(prvi, drugi);
            Console.WriteLine("ugao = "+stampa.ToString());
            */
            poligon novi = new poligon(6);
            tacka A = new tacka(-1,2);
            tacka B = new tacka(-2,0);
            tacka C = new tacka(-1,-2);
            tacka D = new tacka(1,-2);
            tacka E = new tacka(2, 0);
            tacka F = new tacka(1, 2);
            tacka[] niz = new tacka[6];
            novi.teme[0] = A;
            novi.teme[1] =  B;
            novi.teme[2] =  C;
            novi.teme[3] =  D;
            novi.teme[4] =  E;
            novi.teme[5] =  F;
            Console.WriteLine(novi.konveksan());

        }
    }
}
