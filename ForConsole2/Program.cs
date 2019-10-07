using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double Result;
            Result = 0;
            N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                Result += (1.0 / i);
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
