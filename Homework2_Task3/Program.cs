// Напишите программу, которая принимает на вход целое число из
// отрезк [10, 99] и показывает наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7
Console.WriteLine("Введите целое число из отрезка [10, 99], программа покажет наибольшую цифру числа: ");

int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10;
int secondDigit = number % 10;

if (number >= 10 && number <= 99)
{
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
else
{
    Console.WriteLine("Неккоректный ввод!");
}