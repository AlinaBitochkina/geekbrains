using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Seminar04_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];

            FillArray();
            void FillArray()
            {
                Random rnd = new Random(); // иначе не работает
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(0, 10);
                    Console.WriteLine(array[i]);
                }
            }
        }
       
    }
}
