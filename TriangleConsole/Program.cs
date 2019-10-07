using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, x1, x2, x3, y, y1, y2, y3, a, b, c, d1, d2, d3, s1, s2, s3, s;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            d1 = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));
            d2 = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
            d3 = Math.Sqrt(Math.Pow(x - x3, 2) + Math.Pow(y - y3, 2));
            s1 = Math.Sqrt(((a + d2 + d1) / 2) * ((a + d2 + d1) / 2 - a) * ((a + d2 + d1) / 2 - d1) * ((a + d2 + d1) / 2 - d2));
            s2 = Math.Sqrt(((b + d2 + d3) / 2) * ((b + d2 + d3) / 2 - b) * ((b + d2 + d3) / 2 - d2) * ((b + d2 + d3) / 2 - d3));
            s3 = Math.Sqrt(((c + d1 + d3) / 2) * ((c + d1 + d3) / 2 - c) * ((c + d1 + d3) / 2 - d3) * ((c + d1 + d3) / 2 - d1));
            s = Math.Sqrt(((b + a + c) / 2) * ((b + a + c) / 2 - b) * ((b + a + c) / 2 - a) * ((b + a + c) / 2 - c));
            K = Math.Abs(s1 + s2 + s3 + s);
            if (k < 0.0000000001)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
