using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            string vardas;
            Console.Write("Iveskite savo varda: ");
            vardas = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vardas);
            }
            Console.ReadLine();
        }
    }
}
