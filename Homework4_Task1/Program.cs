﻿//  Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP] 

while (true)
{
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine("STOP. Программа завершена");
        break;
    }
    int number;
    if (int.TryParse(input, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine("STOP");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для выхода.");
    }
}

