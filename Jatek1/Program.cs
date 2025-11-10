using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ön a kő, papír, olló játékot választotta!");

            string[] elemek = { "Kő", "Papír", "Olló" };

            Random rand = new Random();

            int i = rand.Next(0, elemek.Length);

            string valasztottgep = elemek[i];


            Console.WriteLine("Válasszon(Kő(1), Papír(2), Olló(3))");
            int valasztottember = Convert.ToInt32(Console.ReadLine());

            while(valasztottember > 3)
            {
                Console.WriteLine("Válasszon(Kő(1), Papír(2), Olló(3))");
                valasztottember = Convert.ToInt32(Console.ReadLine());
            }

            if (valasztottgep == elemek[0] && valasztottember == 2)
            {
                Console.WriteLine("Nyertél!");
            }
            if (valasztottgep == elemek[0] && valasztottember == 1)
            {
                Console.WriteLine("Döntetlen!");
            }
            if (valasztottgep == elemek[0] && valasztottember == 3)
            {
                Console.WriteLine("Vesztettél!");
            }

            if (valasztottgep == elemek[1] && valasztottember == 2)
            {
                Console.WriteLine("Döntetlen!");
            }
            if (valasztottgep == elemek[1] && valasztottember == 1)
            {
                Console.WriteLine("Vesztettél!");
            }
            if (valasztottgep == elemek[1] && valasztottember == 3)
            {
                Console.WriteLine("Nyertél!");
            }

            if (valasztottgep == elemek[2] && valasztottember == 2)
            {
                Console.WriteLine("Vesztettél!");
            }
            if (valasztottgep == elemek[2] && valasztottember == 1)
            {
                Console.WriteLine("Nyertél!");
            }
            if (valasztottgep == elemek[2] && valasztottember == 3)
            {
                Console.WriteLine("Döntetlen!");
            }
            Console.WriteLine("A gép választása: " + valasztottgep);



        }
    }
}

