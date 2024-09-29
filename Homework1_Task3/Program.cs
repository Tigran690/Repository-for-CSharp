Console.WriteLine("Введите число, которое будет проверено: чётное или нет?");

int a = Convert.ToInt32(Console.ReadLine());
int b = 2;

int d = a%b;

if (d == 1)
{
    Console.WriteLine("Число нечётное");
}
else
{
    Console.WriteLine("Число чётное");
}