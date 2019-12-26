using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int liekana = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%3 == liekana)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        
    }
}
