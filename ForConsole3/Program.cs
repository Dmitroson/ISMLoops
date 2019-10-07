using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 A, N, Result = 1;
            A = Int64.Parse(Console.ReadLine());
            N = Int64.Parse(Console.ReadLine());
            for(Int64 i = 1; i <= N; i++)
            {
                Result *= A;
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
