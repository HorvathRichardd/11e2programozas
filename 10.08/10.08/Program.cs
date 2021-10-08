using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._08
{
    class Program
    {
        static void Main(string[] args)
        {
            mintafeladat();
            Console.ReadLine();
        }
        static void mintafeladat()
        {
            Console.WriteLine("kávéautomata");
            Console.WriteLine("A: espresso");
            Console.WriteLine("B: latte macchiato");
            Console.WriteLine("C: espresso macchiato ");
            Console.WriteLine("D: cappucino");
            Console.WriteLine("E: bécsi kávé");
            Console.WriteLine("F: ristretto");
            Console.WriteLine("G: forrócsokoládé");
            Console.Write("Válasszon terméket A-G ");
            char valasztas = char.Parse(Console.ReadLine());
            switch (valasztas)
            {
                case 'A':
                case 'a':       
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("Az ital ára 150-FT");
                    break;

                case 'C':
                case 'c':
                    Console.WriteLine("Az ital ára 140-FT");
                    break;

                case 'D':
                case 'd':
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                case 'E':
                case 'e':
                    Console.WriteLine("Az ital ára 140-FT");
                    break;

                case 'F':
                case 'f':
                    Console.WriteLine("Az ital ára 150-FT");
                    break;

                case 'G':
                case 'g':
                    Console.WriteLine("Az ital ára 180-FT");
                    break;

                default:
                    Console.WriteLine("Nem létező lehetőség!");
                    break;
            }
            switch (valasztas.ToString().ToLower())
            {
                
                case "a":
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                case "b":
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                case "c":
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                case "d":
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                case "e":
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                case "f":
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                case "g":
                    Console.WriteLine("Az ital ára 130-FT");
                    break;

                default:
                    break;
            }
        }
       
    }
}
