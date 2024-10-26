// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
using System;

class Task3
{
    static void Main()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        
        Console.WriteLine("Переворачиваем:");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void PrintArrayReverse(int[] array, int i)
    {
        if (i < 0) return;
        Console.Write(array[i] + " ");
        PrintArrayReverse(array, i - 1);
    }
}