using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string username = Console.ReadLine();
            if (username.ToLower() == "алина")
            {
                Console.WriteLine("Ураа, хозяйка вернулась!");
            }
            else
            {
                Console.WriteLine($"Привет, {username}");
            }
        }
    }
}
