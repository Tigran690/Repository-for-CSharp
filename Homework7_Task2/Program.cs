// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// Пример
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите числа m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

static int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    } 
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

Console.Write($"Функция Аккермана равна: {Ackerman(m, n)}");