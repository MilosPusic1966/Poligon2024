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
            //poligon prvi = new poligon(4);
            //prvi.teme[0] = new tacka(0.5,1.5);
            // prvi.teme[1] = new tacka(1.5, 0.5);
            //prvi.teme[1] = new tacka(1.5, 2);
            //prvi.teme[2] = new tacka(2.5, 1.5);
            //prvi.teme[3] = new tacka(1.5, 3.5);

            /* Obim novog
            for (int i = 0; i < prvi.teme.Length; i++)
            {
                Console.WriteLine("x={0}, y={1}", prvi.teme[i].x, prvi.teme[i].y);
            }
            poligon drugi = new poligon(prvi.teme.Length);
            for (int i = 0; i < drugi.teme.Length; i++)
            {
                double x_novo = (prvi.teme[i].x + prvi.teme[(i+1)% drugi.broj_temena].x)/2;
                double y_novo = (prvi.teme[i].y + prvi.teme[(i + 1) % drugi.broj_temena].y)/2;
                drugi.teme[i] = new tacka(x_novo, y_novo);
            }
            for (int i = 0; i < prvi.teme.Length; i++)
            {
                Console.WriteLine("xn={0}, yn={1}", drugi.teme[i].x, drugi.teme[i].y);
            }
            Console.WriteLine("obim={0}", drugi.obim());
            

            // B i D sa iste strane dijagonale AC
            vektor AC = new vektor(prvi.teme[0], prvi.teme[2]);
            vektor AD = new vektor(prvi.teme[0], prvi.teme[3]);
            double k1 = vektor.VP(AC, AD);
            vektor AB = new vektor(prvi.teme[0], prvi.teme[1]);
            double k2 = vektor.VP(AC, AB);
            if (k1 * k2 > 0)
            {
                Console.WriteLine("Sa iste strane");
            }
            else
            {
                Console.WriteLine("Sa raznih strana");
            }
            
            poligon prvi = new poligon(4);
            prvi.teme[0] = new tacka(1, 1);
            prvi.teme[1] = new tacka(3, 1);
            prvi.teme[2] = new tacka(2, 1);
            prvi.teme[3] = new tacka(2, 2);
            vektor AB = new vektor(prvi.teme[0], prvi.teme[1]);
            vektor CD = new vektor(prvi.teme[2], prvi.teme[3]);
            Console.WriteLine(ravan.presek(AB, CD));
            
            // Da li je dati cetvorougao pravougli trapez
            poligon prvi = new poligon(4);
            prvi.teme[0] = new tacka(3, 2);
            prvi.teme[1] = new tacka(12, 2);
            prvi.teme[2] = new tacka(9, 5);
            prvi.teme[3] = new tacka(3, 5);
            double[] ugao = new double[4];
            vektor[] vektori= new vektor[4];
            for (int i = 0; i < 4; i++)
            {
                vektori[i] = new vektor(prvi.teme[i], prvi.teme[(i + 1) % 4]);
            }
            for (int i = 0; i < 4; i++)
            {
                ugao[i] = vektor.skalarni(vektori[i], vektori[(i + 1) % 4]);
            }
            int pravi = 0;
            int susedni = 0;    
            for (int i = 0; i < 4; i++)
            {
                if (ugao[i] == 0) pravi++;
                if ((ugao[i] == 0) && ugao[(i + 1) % 4] == 0) susedni++;
            }
            if ((pravi == 2) && (susedni == 1)) Console.WriteLine("Jeste");
            else Console.WriteLine("Nije");
            */
            poligon prvi = new poligon(4);
            prvi.teme[0] = new tacka(6, 8);
            prvi.teme[1] = new tacka(5, 6);
            prvi.teme[2] = new tacka(8, 2);
            vektor AB = new vektor(prvi.teme[0], prvi.teme[1]);
            vektor BA = new vektor(prvi.teme[1], prvi.teme[0]);
            vektor BC = new vektor(prvi.teme[1], prvi.teme[2]);
            vektor AC = new vektor(prvi.teme[0], prvi.teme[2]);
            vektor CA = new vektor(prvi.teme[2], prvi.teme[0]);
            vektor CB = new vektor(prvi.teme[2], prvi.teme[1]);
            double A = vektor.ugao(AB, AC);
            double B = vektor.ugao(BC, BA);
            double C = vektor.ugao(CA, CB);
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
