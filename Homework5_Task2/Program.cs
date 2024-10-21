// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// Пример
// 4 3 1      4 6 2
// 2 6 9  =>  2 6 9
// 4 6 2      4 3 1

using System;

class Program
{
    static void Main()
    {

        int[,] array = {
            { 4, 8, 3 },
            { 2, 7, 1 },
            { 3, 2, 5 }
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int rows = array.GetLength(0);
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int temp = array[0, i];
            array[0, i] = array[rows - 1, i];
            array[rows - 1, i] = temp;
        }

        Console.WriteLine("\n Массив после замены:");
        PrintArray(array);
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}