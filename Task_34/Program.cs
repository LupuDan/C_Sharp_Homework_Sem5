/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
            arr[i] = rnd.Next(100, 1000);
        }

        System.Console.WriteLine("Массив: ");
        foreach (int x in arr)
        {
            System.Console.Write(x + " ");
        }
        System.Console.WriteLine();

        int count = 0;
        foreach (int x in arr)
        {
            if(x % 2 == 0)
            {
                count++;
            }
        }
        System.Console.WriteLine("Количество четных чисел: " + count);
    }
}