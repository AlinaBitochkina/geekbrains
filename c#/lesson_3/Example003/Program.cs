using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 3,6,14,46,1,235,67,45,1,3,65,245,123,12,8};

            void PrintArray(int[] array)
            {
                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                              
            }   
            void SelectionSort(int[] array)            
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int maxPosition = i;
                    for (int j = i+1; j < array.Length; j++)
                    {
                        if (array[j] > array[maxPosition]) maxPosition = j;
                    }

                    int temporary = array[i];
                    array[i] = array[maxPosition];
                    array[maxPosition] = temporary;
                }

            }
            PrintArray(arr);
            Console.WriteLine();
            SelectionSort(arr);
            PrintArray(arr);






        }
    }
}
