using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar02_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(10, 100);
            Console.WriteLine(num);
            int num_1 = num / 10;
            int num_2 = num % 10;
            if (num_1 > num_2)
            {
                Console.WriteLine(num_1);
            }
            else
            {
                Console.WriteLine(num_2);
            }
        }
    }
}
