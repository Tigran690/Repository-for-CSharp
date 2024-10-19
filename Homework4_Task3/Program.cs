// Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

int[] array = {5, 7, 9, 3, 2, 1};
int temp;

Console.Write("Исходный массив: ");
foreach (int number in array)
{
    Console.Write(number + " ");
}
for (int i = 0; i < array.Length / 2; i++)
{
    temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
Console.Write("\n Перевёрнутый массив: ");
foreach (int number in array)
{
    Console.Write(number + " ");
}