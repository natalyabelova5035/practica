using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

           
            double N = Convert.ToDouble(Console.ReadLine());
            string[] x = Console.ReadLine().Split(' ');
            string[] y = Console.ReadLine().Split(' ');
            double S1x = 0, S2y = 0, S3pairs = 0, S4squares = 0;
            for (int i = 0; i < N; ++i)
            {
                S1x += Convert.ToDouble(x[i]);
                S2y += Convert.ToDouble(y[i]);
                S3pairs += Convert.ToDouble(x[i]) * Convert.ToDouble(y[i]);
                S4squares += Convert.ToDouble(x[i]) * Convert.ToDouble(x[i]);
            }
            double a = (N * S3pairs - S1x * S2y) / (N * S4squares - S1x * S1x);
            double b = (S2y - a * S1x) / N;
            Console.WriteLine("F=" + a + "*x+" + b);
            Console.ReadKey();
        }
    }
}
