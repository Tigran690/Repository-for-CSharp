﻿// Задайте двумерный массив символов (тип char[,]).
// Создать строку из символов этого массива. 
// Пример
// a b c => “abcdef”
// d e f 

string CharArrayToString(char[] arr)
{
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }
    return res;
}

char[] array = {'a', 'b', 'c', 'd', 'e', 'f'};
string result = CharArrayToString(array);
Console.WriteLine(result);