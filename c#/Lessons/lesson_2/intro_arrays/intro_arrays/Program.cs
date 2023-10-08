using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace intro_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {   // задаем функцию Мах
            int Max(int arg1, int arg2, int arg3)
            {
                int max = arg1;
                if (arg2 > max) max = arg2;
                if (arg3 > max) max = arg3;
                return max;
            }//индекс       0  1   2    3   4     5   6   7   8
            int[] array = { 5, 8, 15, 256, 35, 1236, 51, 25, 56 };
            // используем в аргументах функции Мах снова функции Мах
            int result = Max(
                Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]),
                Max(array[6], array[7], array[8])
                );
            Console.WriteLine(result);
        }
        //Static int Max(int arg1, int arg2, int arg3)
        //{
        //    int result = arg1;
        //    if (arg2 > result) result= arg2;    
        //    if (arg3 > result) result= arg3;
        //    return result;  
        //}
    }
}
