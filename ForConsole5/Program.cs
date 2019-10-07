using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Result = 0;
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int Number = i;
                int Factorial = 1;
                while (Number >= 1)
                {
                    Factorial *= Number;
                    Number--;
                }
                Result += Factorial;
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
