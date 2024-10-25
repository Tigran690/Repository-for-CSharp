Console.WriteLine("Введите 3 числа для сравнения. При завершении будет выведена самая большая цифра:");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    Console.WriteLine(a);
    else if (c > a)
    Console.WriteLine(c);
}
else if (a < b)
{
    if (b > c)
    Console.WriteLine(b);
    else if (b < c)
    Console.WriteLine (c);
}
