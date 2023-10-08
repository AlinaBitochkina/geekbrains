using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar03_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0) Console.WriteLine("1");
            else if (x < 0 && y > 0) Console.WriteLine("2");
            else if (x < 0 && y < 0) Console.WriteLine("3");
            else Console.WriteLine("4");



        }
        
    }

}
