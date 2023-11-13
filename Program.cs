using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruglov_Mikheev_Recursiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Factorial(int n)
            {
                if (n == 1) return 1;
                else return n * Factorial(n - 1);
            }
           // Console.Write("Введите число= ");
           // int num = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; a < 30; a++)
            {
                Console.WriteLine($"Факториал числа {a} равен {Factorial(a)}");
              
            }
            Console.ReadKey();
        }
    }
}
