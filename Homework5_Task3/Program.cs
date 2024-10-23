// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// Пример
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            {4, 8, 1},
            {2, 6, 3},
            {4, 2, 2}
        };

        int minSumIndex = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < array.GetLength(1); i++)
        {
            int CurrentSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                CurrentSum += array[i, j]; 
            }
            if (CurrentSum < minSum)
            {
                minSum = CurrentSum;
                minSumIndex = i;
            }
        }
        Console.WriteLine($"Строка с индексом {minSumIndex}");        
    } 
}