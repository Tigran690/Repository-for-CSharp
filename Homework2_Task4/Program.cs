// Напишите программу, которая принимает на вход натуральное число N,
// а на выходе показывает его цифры через запятую.
// 568 => 5, 6, 8
// 8 => 8
// 9542 => 9, 5, 4, 2
Console.WriteLine("Введите число, чьи цифры будут выведены через запятую: ");

int N = Convert.ToInt32(Console.ReadLine());

if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }

    }
}
