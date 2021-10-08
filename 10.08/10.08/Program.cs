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
            //mintafeladat();
            //feladat12();
            //feladat13();
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
        static void feladat12()
        {
            Console.WriteLine("Válasszon hónapot 1-12");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            Console.WriteLine("11");
            Console.WriteLine("12");
            int honap = int.Parse(Console.ReadLine());
            switch (honap)
            {

                case 1:
                    Console.WriteLine("január"); 
                    break;

                case 2:
                    Console.WriteLine("február");
                    break;

                case 3:
                    Console.WriteLine("március");
                    break;

                case 4:
                    Console.WriteLine("április");
                    break;

                case 5:
                    Console.WriteLine("május");
                    break;

                case 6:
                    Console.WriteLine("június");
                    break;

                case 7:
                    Console.WriteLine("július");
                    break;

                case 8:
                    Console.WriteLine("augusztus");
                    break;

                case 9:
                    Console.WriteLine("szeptember");
                    break;

                case 10:
                    Console.WriteLine("október");
                    break;

                case 11:
                    Console.WriteLine("november");
                    break;

                case 12:
                    Console.WriteLine("december");
                    break;


                default:
                    Console.WriteLine("Nincs ilyen lehetőség");
                    break;
            }


        }
        static void feladat13()
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            Console.WriteLine("11");
            Console.WriteLine("12");
            int honap = int.Parse(Console.ReadLine());

            switch (honap)
            {
                case 4 :
                case 5 :
                case 3 :  

                    Console.WriteLine("Tavaszi hónap");
                    break;

                case 6 :
                case 7 :
                case 8 :
                    Console.WriteLine("nyári hónap");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("őszi hónap");
                    break;

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Téli hónap");
                    break;

              

                default:
                    Console.WriteLine("Nem létező lehetőség!");
                    break;
            }

        }
       
    }

}
