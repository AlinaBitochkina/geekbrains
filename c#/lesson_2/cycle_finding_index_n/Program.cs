using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle_finding_index_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 14, 21, 334, 44, 513, 6, 21, 75, 86 }; 
            int n = array.Length;
            int find = 21;
            int index = 0;

            while (index < n)
            {
                if (array[index] == find)
                {
                    Console.WriteLine(index);
                    break;
                    /*если в массиве несколько одинаковых элементов, 
                     * можно принудительно остановить поиск словом
                     * break
                     */
                }
                //index += 1;
                index++;

            }
        }
    }
}
