using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[3];
            int[] mas2 = new int[3];
            int[] mas3 = new int[6];

            int mas3Item = 0;

            Random rnd = new Random();


            for (int m1 = 0; m1 < mas1.Length; m1++)
            {
                mas1[m1] = rnd.Next(1, 100);
                mas3[mas3Item] = mas1[m1];
                mas3Item++;
            }

            Console.WriteLine("Masyvas nr1");
            foreach (var item in mas1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            for (int m2 = 0; m2 < mas2.Length; m2++)
            {
                mas2[m2] = rnd.Next(1, 100);
                mas3[mas3Item] = mas2[m2];
                mas3Item++;
            }

            Console.WriteLine("Masyvas nr2");
            foreach (var item in mas2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Masyvas nr3");
            foreach (var item in mas3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
