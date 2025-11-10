using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projektfeladat1
{
    internal class Program
    {

        public static void menu()
        {
            Random rand1 = new Random();
            Console.WriteLine("Játékok:\n (1.)Kő, Papír, Olló\n (2.)Verseny\n (3.)Akasztófa \n (4.)Kilépés");
            int jatek;
            jatek = Convert.ToInt32(Console.ReadLine());

            switch (jatek)
            {
                case 1:

                    break;
                case 2:
                    verseny(rand1);
                    break;
                case 3:

                    break;
                case 4:
                    Environment.Exit(0);
                    break;

            }
        }

        public static void KoPapirOllo(Random rand1)
        {

            Console.WriteLine("Ön a kő, papír, olló játékot választotta!");

            string[] elemek = { "Kő", "Papír", "Olló" };

            Random rand = new Random();

            int i = rand.Next(0, elemek.Length);

            string valasztottgep = elemek[i];


            Console.WriteLine("Válasszon(Kő(1), Papír(2), Olló(3))");
            int valasztottember = Convert.ToInt32(Console.ReadLine());

            while (valasztottember > 3)
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
            Console.WriteLine("(0.) Menü \n\n Játékok: \n (1.)Kő, Papír, Ollló \n (2.)Újra játszás \n (3.) Akasztófa \n (4.)Kilépés");

            int jatek;
            jatek = Convert.ToInt32(Console.ReadLine());

            switch (jatek)
            {
                case 0:
                    menu();
                    break;
                case 1:
                    KoPapirOllo(rand1);
                    break;
                case 2:
                    verseny(rand1);
                    break;
                case 3:

                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
            
        public static void verseny(Random rand1)
        {


            string[] palya = new string[110];
            string[] palya2 = new string[110];
            int bicikli1poz = 0;
            int bicikli1vel = 0;
            int bicikli2poz = 0;
            int bicikli2vel = 0;
            bool nyertes = false;

            for (int i = 0; i < palya.Length; i++)
            {
                palya[i] = "-";
            }
            palya[palya.Length - 13] = "C";
            palya[palya.Length - 12] = "É";
            palya[palya.Length - 11] = "L";
            for (int i = 0; i < palya2.Length; i++)
            {
                palya2[i] = "-";
            }
            palya2[palya2.Length - 13] = "C";
            palya2[palya2.Length - 12] = "É";
            palya2[palya2.Length - 11] = "L";

            Console.WriteLine("Bicikli 1:");
            for (int i = 0; i < palya.Length; i++)
            {
                Console.Write(palya[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Bicikli 2:");
            for (int i = 0; i < palya.Length; i++)
            {
                Console.Write(palya2[i]);
            }
            do
            {
                Console.Clear();
                bicikli1vel = rand1.Next(1, 11);
                bicikli2vel = rand1.Next(1, 11);




                palya[bicikli1poz] = "-";
                palya2[bicikli2poz] = "-";



                bicikli1poz = bicikli1vel + bicikli1poz;
                bicikli2poz = bicikli2vel + bicikli2poz;



                palya[bicikli1poz] = "O";
                palya2[bicikli2poz] = "O";


                Console.WriteLine("Bickli 1 sebessége: " + bicikli1vel);
                for (int i = 0; i < palya.Length; i++)
                {
                    Console.Write(palya[i]);

                }
                Console.WriteLine();
                Console.WriteLine("Bickli 2 sebesség: " + bicikli2vel);
                for (int i = 0; i < palya.Length; i++)
                {
                    Console.Write(palya2[i]);
                }
                Console.WriteLine();
                Thread.Sleep(1000);
                if (bicikli1poz >= palya.Length - 13 && bicikli2poz <= palya2.Length - 13)
                {
                    Console.WriteLine("Bicikli 1 nyert");
                    nyertes = true;
                }
                else if (bicikli1poz <= palya.Length - 13 && bicikli2poz >= palya2.Length - 13)
                {
                    Console.WriteLine("Bicikli 2 nyert");
                    nyertes = true;
                }
                else if (bicikli1poz >= palya.Length - 13 && bicikli2poz >= palya2.Length - 13 && bicikli1poz > bicikli2poz)
                {
                    Console.WriteLine("Bicikli 1 nyert");
                    nyertes = true;
                }
                else if (bicikli1poz >= palya.Length - 13 && bicikli2poz >= palya2.Length - 13 && bicikli1poz < bicikli2poz)
                {
                    Console.WriteLine("Bicikli 2 nyert");
                    nyertes = true;
                }
            }
            while (bicikli1poz < 97 && bicikli2poz < 97);

            Console.WriteLine("(0.) Menü \n\n Játékok: \n (1.)Kő, Papír, Ollló \n (2.)Újra játszás \n (3.) Akasztófa \n (4.)Kilépés");

            int jatek;
            jatek = Convert.ToInt32(Console.ReadLine());

            switch (jatek)
            {
                case 0:
                    menu();
                    break;
                case 1:
                    KoPapirOllo(rand1);
                    break;
                case 2:
                    verseny(rand1);
                    break;
                case 3:

                    break;
                case 4:
                    Environment.Exit(0);
                    break;

            }

        }

        public static void Akasztofa()
        {
            string[] szavak = {"technológia","dolog","megértés","globalizáció","erő","nap","fenntarthatóság","integritás","vágyakozás","identitás","kultúra","szenvedély","transzformáció","egyenlőség","öröm","inspiráció"};
        }

        static void Main(string[] args)
        {

            menu();

        }
    }
}
