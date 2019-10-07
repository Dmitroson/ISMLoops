using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 N, K;
            double Result = 0;
            N = Int64.Parse(Console.ReadLine());
            K = Int64.Parse(Console.ReadLine());
            for(Int64 i = 1; i <= N; i++)
            {
                Result += Math.Pow(i, K);
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
