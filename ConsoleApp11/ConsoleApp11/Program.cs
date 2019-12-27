using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tekstas = new char[8];
            for (int i = 0; i < tekstas.Length; i++)
            {
                Console.Write("Iveskite raide: ");
                tekstas[i] = Console.ReadKey().KeyChar;
                Console.Clear();
            }

            for (int i = 0; i < tekstas.Length; i++)
            {
                Console.Write(tekstas[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int x = tekstas.Length - 1; x >= 0; x--)
            {
                Console.Write(tekstas[x]);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
