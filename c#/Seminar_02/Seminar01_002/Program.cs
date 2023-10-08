using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar01_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(100,1000);
            Console.WriteLine(number);
            int num1 = number / 100;
            int num3= number % 10;
            int number2 = num1 * 10 + num3;
            Console.WriteLine(number2);
          
        }
    }
}
