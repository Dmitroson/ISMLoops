using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            PiViet(N);
            PiWallis(N);
            PiLeibniz(N);
            Console.ReadKey();

        }
        static void PiViet(int N)
        {
            double result = 1, x = Math.Sqrt(0.5);
            for(int i = 0; i < N; i++)
            {
                x = result * Math.Sqrt(0.5 + 0.5 * x);
            }
            Console.WriteLine($"PiViet: {2 / result}");
        }
        static void PiWallis(int N)
        {
            double PiWallis, result = 1;
            for (int i = 2; i <= N; i = i + 2)
            {
                result = result * ((i - 1) * (i + 1)) / (i * i);
            }
            PiWallis = 2 / result;
            Console.WriteLine($"PiWallis: {PiWallis}");
        }
        static void PiLeibniz(int N)
        {
            int k = -1;
            double PiLeibniz, result = 0;
            for(int i = 1, j = 1; i < N; i = i + 2, j++)
            {
                result = result + (Math.Pow(k, j) * 1 / i);
            }
            PiLeibniz = -result * 4;
            Console.WriteLine($"PiLeibniz: {PiLeibniz}");
        }
    }
}