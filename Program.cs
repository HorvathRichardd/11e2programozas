using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {

            //feladat1();
            //feladat3();
            feladat2();
            //feladat5();

            Console.ReadLine();
        }
        static void feladat1()
        {
            Console.WriteLine("Kérem az A oldalt :");
            string a = Console.ReadLine();
            Console.WriteLine("Kérem a B oldalt :");
            string b = Console.ReadLine();

            Console.WriteLine("a téglalap kerülete : {0}" , (Convert.ToInt32(a) + Convert.ToInt32(b)) * 2 );
            Console.WriteLine("a téglalap területe : {0}" , Convert.ToInt32(a) * Convert.ToInt32(b));
        }
        static void feladat3()
        {
            Console.WriteLine("Adja meg a számot");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            string het = Console.ReadLine();

            switch (Convert.ToInt32(het))
            {
                case 1:
                    Console.WriteLine("hétfő");

                    break;


                case 2:
                    Console.WriteLine("kedd");

                    break;

                case 3:
                    Console.WriteLine("szerda");

                    break;

                case 4:
                    Console.WriteLine("csütörtök");

                    break;

                case 5:
                    Console.WriteLine("péntek");

                    break;

                case 6:
                    Console.WriteLine("szombat");

                    break;

                case 7:
                    Console.WriteLine("vasárnap");

                    break;
                default:
                    Console.WriteLine("Nincs ilyen lehetőség");
                    break;
            }

        }
        static void feladat2()
        {
            Console.WriteLine("Kérek egy évszámot");
            string i = Console.ReadLine();

            if (Convert.ToInt32(i) % 4 == 0 )
            {
                Console.WriteLine("Szökőév!");
            }
            else
            {
                Console.WriteLine("Nem szökőév!");
            }
        }
        static void feladat5()
        {
            Console.WriteLine("Kérek egy számot!");
        }
    }
}
