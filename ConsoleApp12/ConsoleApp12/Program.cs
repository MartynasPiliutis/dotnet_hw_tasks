using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = rnd.Next(1,100);
            }
            foreach (var item in masyvas)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.ReadLine();

            Array.Sort(masyvas);

            foreach (var item in masyvas)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
