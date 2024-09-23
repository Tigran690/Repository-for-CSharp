Console.WriteLine("Введите два числа для сравнения: ");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else if (num1 == num2)
{
    Console.WriteLine("Числа равны!");
}
else 
{
    Console.WriteLine(num2);
}
