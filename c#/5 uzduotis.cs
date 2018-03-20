using System;

namespace _11._03._18_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirkiniu sarasas \nGalimi pasirinkimai");
            Console.WriteLine(" 1 Pienas\n 2 Duona\n 3 Sviestas\n 4 Alus\n 5 Sultys\n 6 Obuoliai\n 7 Saldainiai\n 8 Bulves ");
            double Pienas = 1.5;
            double Duona = 1;
            double Sviestas = 2;
            double Alus = 1.2;
            double Sultys = 2;
            double Obuoliai = 3;
            double Saldainiai = 5;
            double Bulves = 0.8;
            double suma = 0;



            Console.WriteLine("Kiek norite prekiu?");
            int n = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("\nParasykit norimos prekes skaiciu");
               int pasirinkimas = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine("\nParasykite prekes kieki");
                int kiekis = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                switch (pasirinkimas)
                {
                    case 1:
                        Console.WriteLine("\n Pasirinkote piena x {0}", kiekis);
                        suma += (Pienas * kiekis);
                        break;
                    case 2:
                        Console.WriteLine("\n Pasirinkote duona x {0}", kiekis);
                        suma += (Duona * kiekis);
                        break;
                    case 3:
                        Console.WriteLine("\n Pasirinkote sviestas x {0}", kiekis);
                        suma += (Sviestas * kiekis);
                        break;
                    case 4:
                        Console.WriteLine("\n Pasirinkote alus x {0}", kiekis);
                        suma += (Alus * kiekis);
                        break;
                    case 5:
                        Console.WriteLine("\n Pasirinkote sultys x {0}", kiekis);
                        suma += (Sultys * kiekis);
                        break;
                    case 6:
                        Console.WriteLine("\n Pasirinkote obuoliai x {0}", kiekis);
                        suma += (Obuoliai * kiekis);
                        break;
                    case 7:
                        Console.WriteLine("\n Pasirinkote saldainiai x {0}", kiekis);
                        suma += (Saldainiai * kiekis);
                        break;
                    case 8:
                        Console.WriteLine("\n Pasirinkote bulves x {0}", kiekis);
                        suma += (Bulves * kiekis);
                        break;
                }
            }
            Console.WriteLine("Visa pirkiniu suma - {0}", suma);
        }
    }
}
