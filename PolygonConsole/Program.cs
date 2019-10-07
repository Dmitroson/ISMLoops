using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double Result, s = 0;
            N = int.Parse(Console.ReadLine());
            double[,] Coordinates = new double[N, 2];
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Coordinates[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 1; i < N; i++)
            {
                s += ((Coordinates[i - 1, 0] - Coordinates[i, 0]) * (Coordinates[i - 1, 1] + Coordinates[i, 1])); // Vector Multiplication
            }
            s += ((Coordinates[N - 1, 0] - Coordinates[0, 0]) * (Coordinates[N - 1, 1] + Coordinates[0, 1]));
            Result = Math.Abs(s) / 2;
            Console.WriteLine($"Площадь {N}-угольника равна {Result}");
            Console.ReadKey();
        }
    }
}
