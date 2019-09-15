using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppНьютон
{
    class Program
    {
        static double sq(double x)
        {
            return x * x;
        }

        static double f2(double x)
        {
            return (x - Math.Pow(10, 1 / sq(x)));
        }
        static double df2(double x)
        {
            return (1 + 2 * Math.Pow(x, -3) * Math.Log(10) * Math.Pow(10, 1 / sq(x)));
        }
        const double m = 1.4;

        static double phi1(double x)
        {
            return x - f2(x) / df2(x);
        }
        const double eps = 1e-4;

        static void Main(string[] args)
        {
            double x0 = 4, // Начальное приближение
                   x1;
            int n = 0;
            while (true)
            {
                ++n;

                x1 = phi1(x0);
                Console.WriteLine(x1);

                if (Math.Abs(x1 - x0) < eps) break;
                x0 = x1;
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
