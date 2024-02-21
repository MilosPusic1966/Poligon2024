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
            poligon prvi = new poligon(4);
            prvi.teme[0] = new tacka(0.5,1.5);
            prvi.teme[1] = new tacka(1.5, 0.5);
            prvi.teme[2] = new tacka(2.5, 1.5);
            prvi.teme[3] = new tacka(1.5, 3.5);
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

        }
    }
}
