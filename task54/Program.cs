// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void NewArray(int[,] SortArray)
{
    for (int i = 0; i < SortArray.GetLength(0); i++)
    {
        for (int j = 0; j < SortArray.GetLength(1); j++)
        {
            int maxpos = j;
            for (int k = j + 1; k < SortArray.GetLength(1); k++)
            {
                if (SortArray[i, k] > SortArray[i, maxpos]) maxpos = k;
            }
            int temp = SortArray[i, j];
            SortArray[i, j] = SortArray[i, maxpos];
            SortArray[i, maxpos] = temp;
        }
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
NewArray(array);
PrintArray(array);