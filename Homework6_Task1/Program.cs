﻿// Задайте двумерный массив символов (тип char[,]).
// Создать строку из символов этого массива. 
// Пример
// a b c => “abcdef”
// d e f 
class Task1
{
    static void Main(string[] args)
    {
        char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' }, {'e', 'f'} };
        string result = CreateStringFrom2DArray(charArray);
        Console.WriteLine(result);
    }
    static string CreateStringFrom2DArray(char[,] array)
    {
        string result = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += array[i, j];
            }
        }
        return result;
    }
}