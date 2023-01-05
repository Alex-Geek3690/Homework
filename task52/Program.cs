// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");
    }
    return matrix;
}
void SumLine(int[,] array)
{
    Console.Write("\n Среднее фарифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double average = Math.Round(sum / array.GetLength(0), 1);
        Console.Write($"{average} ");
    }
}
SumLine(CreateArray(3, 4));

