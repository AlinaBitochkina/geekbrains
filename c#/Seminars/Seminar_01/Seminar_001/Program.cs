using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");           
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            if (firstNumber>secondNumber) 
            {
                Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
                
            }
            else if (firstNumber == secondNumber) 
            {
                Console.WriteLine($"Введенные числа равны `{firstNumber}`");
            }                         
            else
            {
                Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
            }
        }
    }
}
