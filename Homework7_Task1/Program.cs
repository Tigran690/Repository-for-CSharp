// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// M = 8; N = 4 -> "8, 7, 6, 5, 4"

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите числа M и N: ");

        int M = Convert.ToInt32(Console.ReadLine());
        int N = Convert.ToInt32(Console.ReadLine());

        FromFirstToSecondNumbers(M, N);
    }

    static void FromFirstToSecondNumbers(int M, int N)
    {
        Console.Write(M + " ");
        if (M < N)
        {
            FromFirstToSecondNumbers(M + 1, N);
        }
        else if (M > N)
        {
            FromFirstToSecondNumbers(M - 1, N);
        }
    }
}
