using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[5];

            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write("Iveskite skaiciu: ");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            

            Console.WriteLine("Jusu suvestas masyvas yra:");
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine(masyvas[i]);
            }
            Console.ReadLine();
        }

        

    }
}
