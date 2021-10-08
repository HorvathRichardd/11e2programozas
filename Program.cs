using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elágazások
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat16();
            Console.ReadLine();
        }
        static void feladat16()
        {
            Console.WriteLine("Válasszon egy érdemjegyet");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            int jegy = int.Parse(Console.ReadLine());

            switch (jegy)
            {
                case 1:
                    
                    Console.WriteLine("Elégtelen");

                    break;

                case 2:

                    Console.WriteLine("Elégséges");

                    break;

                case 3:

                    Console.WriteLine("közepes");

                    break;

                case 4:

                    Console.WriteLine("jó");

                    break;

                case 5:

                    Console.WriteLine("jeles");

                    break;

                default:
                    Console.WriteLine("Nem létező osztályzat");
                    break;
            }

        }
    }
}
