using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = double.Parse(Console.ReadLine());
            double S = 10;
            int K = 1;
            while(S <= 200)
            {
                S += S * P / 100;
                K++;
            }
            Console.WriteLine(K);
            Console.ReadKey();
        }
    }
} 