using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace array_library
{
    internal class Program
    {
        static void Main(string[] args)

            /*создаём функцию, которая будет заполнять массив
             * случайными значениями из заданного диапазона
             */

         
        {
            void FillArray(int[] collection)
            {
                int length = collection.Length;
                int index = 0;
                Random rnd = new Random();  //вместо 28 строки
                while (index < length) 
                {
                    collection[index] = rnd.Next(1, 10);
                    //collection[index] = new Random().Next(1, 20); //не срабатывает
                    index++;
                    
                }
            }
            //функция 
            void PrintArray(int[] col)
            {
                int count = col.Length;
                int position = 0;   
                while (position < count) 
                {
                    Console.WriteLine(col[position]);   
                    position++; 
                }
            }
            // функция на поиск заданного числа
            int IndexOf(int[] collection, int find)
            {
                int count = collection.Length;
                int index = 0;
                int position = -1; //на случай если искомое число не будет в массиве элементов, если бы стоял 0, казалось бы, что индекс искомого 0
                while (index < count)
                {
                    if (collection[index] == find)
                    {
                        position = index;
                        break;
                    }
                    index++;
                }

                return position;
            }
                //это был первый шаг, определили массив из 10 элементов    

            int[] array = new int[10];

            //вызвали метод FillArray который заполнил массив
            // и метод PrintArray который вывел массив
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();

                int pos = IndexOf(array, 4);
                Console.WriteLine(pos);

            }
    }
}
