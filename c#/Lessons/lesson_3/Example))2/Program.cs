using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=====Работа с текстом
            // Дан текст. В тексте нужно все пробелы заменить чёрточками,
            // маленькие буквы “к” заменить большими “К”,
            // а большие “С” маленькими “с”.
            // Ясна ли задача?
            string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
                            + "ежели бы вас послали вместо нашего милого Винценгероде,"
                            + "вы бы взяли приступом согласие прусского короля."
                            + "Вы так красноречивы.Вы дадите мне чаю?";

            // string s = “qwerty”
            // 012345
            //s[3] = r 
            string Replace (string txt, char OldValue, char NewValue) 
            {
                string result = string.Empty;
                int length = txt.Length;
                for (int i = 0; i < length; i++) 
                {
                    if (text[i] == OldValue) result = result + $"{NewValue}";
                    else result = result + $"{text[i]}";
                }
                return result;
            }
            string newText = Replace(text, ' ', '_');
            Console.WriteLine(newText);
            Console.WriteLine();
            newText = Replace(newText, 'к', 'К');
            Console.WriteLine(newText);
            Console.WriteLine();
            newText = Replace(newText, 'В', 'в');
            Console.WriteLine(newText);
        }
    }
}
