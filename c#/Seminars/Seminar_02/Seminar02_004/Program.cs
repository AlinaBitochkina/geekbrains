﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar02_004
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
            // 7 и 23.

            // 14 -> нет
            // 46 -> нет
            // 161 -> да

            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());

            if ((num % 7 == 0) && (num % 23 == 0)) // && - И || - Или
            {
                Console.WriteLine("Да");
            }

            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}
