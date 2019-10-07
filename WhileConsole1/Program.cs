using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, K=0;
            N = int.Parse(Console.ReadLine());
            while(Math.Pow(3, K) < N)
            {
                K++;
            }
            Console.WriteLine(K);
            Console.ReadKey();
        }
    }
}
