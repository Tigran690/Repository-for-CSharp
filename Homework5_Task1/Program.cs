// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Пример
// 4 3 1 (1,2) => 9
// 2 6 9 

static void FindMaxInRows(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int max = array[i, 0];
        for (int j = 1; j < cols; j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
        }
        Console.WriteLine($"Строка № {i}");
        Console.WriteLine($"Максимальный элемент строки № {i} :{max}");
    }
}
int[,] array =
{
    {3, 2, 8, 5},
    {4, 7, 6, 1},
};
FindMaxInRows(array);
