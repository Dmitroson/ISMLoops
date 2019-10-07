using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Result=1;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            for(int i = A; i <= B; i++)
            {
                Result *= i;
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}