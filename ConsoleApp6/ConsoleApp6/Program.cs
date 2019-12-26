using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    Console.Write("{0} x {1} = {2}, ", i, x, i * x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
