using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вычисления целочисленное
            int a = 10;
            int b = 20;
            int result = b / a;
            Console.WriteLine(result);
            // вычисление дробное
            double c = 10;
            double d = 21;
            double result_2 = d / c;
            Console.WriteLine(result_2);

            //случайное целое число
            Console.WriteLine("Умножение случайных чисел");
            int e = new Random().Next(1, 20);
            int f = new Random().Next(20, 40);
            int result_3 = f * e;
            Console.WriteLine($"Первое случайное число: {e}");
            Console.WriteLine($"Второе случачайное число: {f}");
            Console.WriteLine(result_3);
        }
    }
}
