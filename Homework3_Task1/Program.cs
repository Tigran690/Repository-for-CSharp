﻿// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите кол-во элементов массива, значения которых лежат в отрезке [10, 90]
// массив [10, 21, 14, 93, 23] => 4

int[] numbers = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int count = 0;
foreach (int number in numbers)
{
    if (number >= 10 && number <= 90)
    {
        count++;
    }
}         
Console.WriteLine (count);