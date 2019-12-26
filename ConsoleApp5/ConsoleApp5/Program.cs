using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite eiluciu skaiciu: ");
            int eilutes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= eilutes-1; i++)
            {
                for (int x = 0; x < i+1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
