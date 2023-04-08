/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 101);
        }

        System.Console.WriteLine("Массив: ");
        foreach (int x in arr)
        {
            System.Console.Write(x + " ");
        }
        System.Console.WriteLine();

        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }

        System.Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }
}