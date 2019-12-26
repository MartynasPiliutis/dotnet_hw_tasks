using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 10; i <= 20; i++)
            {
                suma = suma + i;
                Console.WriteLine(suma);
            }
            Console.ReadLine();
        }
    }
}
