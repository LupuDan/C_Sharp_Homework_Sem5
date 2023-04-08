/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double[] arr = new double[10] {3.4, 1.2, 5.6, 2.1, 4.9, 7.8, 0.5, 2.3, 6.7, 1.8};

        System.Console.WriteLine("Массив: ");
        foreach (double x in arr)
        {
            System.Console.Write(x + " ");
        }
        System.Console.WriteLine();

        double min = arr[0];
        double max = arr[0];
        foreach(double x in arr)
        {
            if (x < min)
            {
                min = x;
            }
            if (x > max)
            {
                max = x;
            }
        }

        double diff = max - min;

        System.Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
    }
}