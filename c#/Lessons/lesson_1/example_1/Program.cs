using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//ввод будет происходит в той же строке, а если writeline - то на новой

            Console.WriteLine("Введите ваше имя:");

            // инициализация переменной username с типом данных string, сохранение текста с консоли в переменной

            string username = Console.ReadLine();

            // выводит текст приветик в одну строку вместе с именем

            Console.Write("Приветик, ");
            Console.Write(username);
        }
    }
}
