using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[5];
            int a = 0;
            foreach (int element in masyvas)
            {
                Console.Write("Iveskite skaiciu: ");
                masyvas[a] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                a++;
            }


            Console.WriteLine("Jusu suvestas masyvas yra:");

            foreach (int i in masyvas)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            int suma = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                suma = suma + masyvas[i];
            }

            Console.Write($"Masyvo suma yra: {suma}");
            Console.ReadLine();
        }
    }
}
