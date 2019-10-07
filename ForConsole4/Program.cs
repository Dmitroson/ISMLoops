using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 A, B, Result = 0;
            A = Int64.Parse(Console.ReadLine());
            B = Int64.Parse(Console.ReadLine());
            for(Int64 i = A; i <= B; i++)
            {
                Result += i * i;
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
