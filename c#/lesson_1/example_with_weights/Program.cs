using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace example_with_weights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 20;
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            Console.Write("max = ");
            Console.WriteLine(max);


        }
    }
}
