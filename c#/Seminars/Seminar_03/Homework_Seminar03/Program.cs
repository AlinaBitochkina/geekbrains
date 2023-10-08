using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Seminar03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое пятизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

                if (IsPalindrome(number))
                {
                    Console.WriteLine("Число является палиндромом");
                }
                else
                {
                    Console.WriteLine("Число не является палиндромом");
                }  
        }
        static bool IsPalindrome(int number)
        {
            if (number < 10000 || number > 99999)
            {
                Console.WriteLine("Число не пятизначное");
                return false;
            }

            int originalNumber = number;
            int reverseNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reverseNumber = reverseNumber * 10 + digit;
                number = number / 10;
            }

            if (originalNumber == reverseNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }   
}
