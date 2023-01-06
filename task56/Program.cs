// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");
    }
    return matrix;
}
void SumRows(int[,] array)
{
    int MinNumRow = 0;
    int Sumrow = int.MaxValue; // константа, наибольшее возможное число.
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < Sumrow)
        {
            Sumrow = sum;
            MinNumRow = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinNumRow}");
}
SumRows(CreateArray(5, 3));
