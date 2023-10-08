using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework001_Seminar03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Внутри класса Answer напишите метод IsPalindrome,
            //который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

            //Метод должен проверить является ли число пятизначным,
            //в противном случае - вывести Число не пятизначное и False в следующей строке.
            //Для остальных чисел вернуть True или False.


            Console.WriteLine("enter number");
            
            int number = Convert.ToInt32(Console.ReadLine());
            int num1 = number / 10000;
            int num2 = (number / 1000) % 10;
            int num4 = (number % 100) / 10;
            int num5 = number % 10;
            if (number < 10000 || number > 99999)
            {
                Console.WriteLine("Число не пятизначное");
                Console.WriteLine("False");
            }

            else if (num1 == num5 && num2 == num4)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }



        }
    }
}
