using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("введите n");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("введите x");
                double x = double.Parse(Console.ReadLine());
                double S = 0;
                for (double i = 1; i <= n; i++)
                {
                    long F = 1;
                    for (int j = 1; j < 2 * i - 1 ; j++) F *= j;
                    S += Math.Pow(x, i) / (i / F);
                }
                Console.WriteLine("S={0:F2}", S);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

          
            Console.ReadKey();
        }
    }
}
