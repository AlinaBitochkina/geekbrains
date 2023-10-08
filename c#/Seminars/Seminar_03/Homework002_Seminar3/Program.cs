using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework002_Seminar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Внутри класса Answer напишите метод DistanceBetweenPoints,
            //который принимает на вход координаты двух точек pointA и pointB
            //в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

                // Пример использования метода DistanceBetweenPoints
                int[] pointA = { 1, 2, 3 };
                int[] pointB = { 4, 5, 6 };

                double distance = DistanceBetweenPoints(pointA, pointB);
                Console.WriteLine($"Расстояние между точками: {distance}");
            

            
        }
        public static double DistanceBetweenPoints(int[] pointA, int[] pointB)
        {
            if (pointA.Length != 3 || pointB.Length != 3)
            {
                throw new ArgumentException("Координаты точек должны состоять из трех чисел");
            }

            int deltaX = pointB[0] - pointA[0];
            int deltaY = pointB[1] - pointA[1];
            int deltaZ = pointB[2] - pointA[2];

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }
    
}
