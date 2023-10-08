using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_001_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Задача 5.Напишите программу, которая на вход принимает одно число (N)
             * , а на выходе показывает все целые числа в промежутке от -N до N.
             * 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
             */


            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());

            int negNum = -1 * num;

            while (negNum <= num)
            {
                Console.WriteLine(negNum);
                negNum +=1;
            }


    }
    }
}
