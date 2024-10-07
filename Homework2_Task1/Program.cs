// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// a = 50 => нет
// a = 7 => нет
// a = 322 => да
Console.WriteLine("Введите число для проверки(кратно ли оно одновременно 7 и 23?):");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0)
{
    if (number % 23 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Нет");
}
