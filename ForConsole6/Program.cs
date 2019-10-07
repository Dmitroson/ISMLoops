using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 N;
            double Result = 0;
            N = Int64.Parse(Console.ReadLine());
            for(Int64 i = 1, j = N; j >= 1; i++, j--)
            {
                Result += Math.Pow(i, j);
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
