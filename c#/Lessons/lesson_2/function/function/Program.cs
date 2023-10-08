using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Max (int arg1, int arg2, int arg3)
                {
                int result = arg1;
                if (arg2 > result) result = arg2;
                if (arg3 > result) result = arg3;
                return result;
                } 
            int a1 = 3;
            int b1 = 4;
            int c1 = 5;
            int a2 = 8;
            int b2 = 900;
            int c2 = 10;
            int a3 = 1500;
            int b3 = 16;
            int c3 = 17;


            //int max1 = Max(a1, b1, c1);
            //int max2 = Max(a2, b2, c2);
            //int max3 = Max(a3, b3, c3);
            //int max = Max(max1,max2, max3);
            //Console.WriteLine(max); 

            /*Но можно сделать функцию в функции
             * Это называется функциональное программирование
             * Мы можем внутри аргумента передать функцию
             */
            int max = Max(
                Max(a1, b1, c1),
                Max(a2, b2, c2),
                Max(a3, b3, c3));
            Console.WriteLine(max);





        }
    }
}
