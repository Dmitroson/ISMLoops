using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int CurrentNumber;
            int Sum = 0;
            do
            {
                CurrentNumber = int.Parse(Console.ReadLine());
                Sum += CurrentNumber;
            }
            while (CurrentNumber != 0);
            Console.WriteLine(Sum);
            Console.ReadKey();
        }
    }
}