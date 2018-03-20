using System;
using System.Linq;

namespace beatrice_sapnas
{
    class Program
    {
        int SkaidauSkaicius(int skaicius, int[] sarasas, int unikalus, ref int nulis) 
        {
            while (skaicius > 0)
            {
                int pavienis = skaicius % 10;

                if (!sarasas.Contains(pavienis))
                {
                    sarasas[unikalus] = pavienis;
                    unikalus += 1;
                }

                if (nulis == 0 && pavienis == 0)
                {
                    sarasas[unikalus] = pavienis;
                    nulis += 1;
                    unikalus += 1;
                }
                skaicius = skaicius / 10;
            }
            return unikalus;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Beatrices skaicius");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] sarasas = new int[10];
            int unikalus = 0;
            int nulis = 0;
            int maxInt = int.MaxValue;
            Program Metodas = new Program();

            for (int i = 1; N * i < maxInt; i++)
            {
                
                unikalus = Metodas.SkaidauSkaicius(N * i, sarasas, unikalus, ref nulis);
                if (unikalus == 10)
                {
                    Console.WriteLine("Beatrice uzmiega pasakiusi skaiciu {0}, kuri gavo po {1} daugybu", N * i, i);
                    return;
                }

                if (N * i == 0)
                {
                   Console.WriteLine("INSOMNIA");
                   return;
                }

                if (N * i == maxInt)
                {
                    Console.WriteLine("INSOMNIA");
                    return;
                }
            }
            return;
        }
    }
}

