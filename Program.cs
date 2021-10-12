using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozosora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            feladat1();
        }
        static void feladat1()
        {
            for (int i = 0; i < 21; i++)
            {

                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            for (int i = 0; i < 21; i++)
            {

                Console.WriteLine("{0} ", i);
            }
        }
    }

}
