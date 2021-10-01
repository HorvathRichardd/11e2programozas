using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202110._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat6();
            //feladat9();
            Console.WriteLine("nyomj meg egy billentyűt ");
            Console.ReadKey();

        }
        static void feladat1()
        {
            Console.WriteLine("hello world");
           
        }
        static void feladat2()
        {
            Console.Write("Kérjük adja meg a nevét ");
            string nev = Console.ReadLine();
            Console.WriteLine("Üdvözöljük {0}" , nev);
        }
        static void feladat6()
        {
            Console.Write("Kérem adja meg az oldalak a méretét a=");
            double a = double.Parse(Console.ReadLine());
            double k = 4 * a;
            Console.WriteLine("a négyzet kerülete {0}" , k);
            double t = a * a;
            Console.WriteLine("a négyzet kerülete {0}" , t);
        }
        static void feladat9()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());

            int legkisebb = Math.Min(a, Math.Min(b, c));
            Console.WriteLine("a legkisebb {0}" , legkisebb);
        }

    }
}
