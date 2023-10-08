using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework003_Seminar03
{
    internal class Program
    {
        static void Main(string[] args)
        {// Внутри класса Answer напишите метод ShowCube, который принимает на вход число(N)
         // и выводит таблицу кубов чисел от 1 до N(включительно) каждое на новой строке.
            int N = int.Parse(Console.ReadLine());
            ShowCube(N);
        }
            

        static void ShowCube(int N)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(i * i * i);
                }
            }
        }
    }
    

