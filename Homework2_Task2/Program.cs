// Напишите программу, которая принимает на вход координаты точки(X и Y), причём
// X не 0, Y не 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4
Console.WriteLine("Введите координаты точки(X, Y), чтобы узнать в какой координатной четверти плоскости расположено оно:");

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
Console.WriteLine("4");
}
else
{
Console.WriteLine("Некорректные координаты!");
}