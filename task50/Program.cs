// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
    return result;
}
void PrintArray(int[,] inArray, int pos_1, int pos_2)
{
    if (pos_1 > inArray.GetLength(0) || pos_2 > inArray.GetLength(1))
        Console.WriteLine($"[{pos_1}, {pos_2}] -> такого числа в массиве нет");
    else Console.WriteLine($"[{pos_1}, {pos_2}] -> {inArray[pos_1, pos_2]}");
}
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер строки в массиве: ");
int numrows = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца в массиве: ");
int numcolumns = int.Parse(Console.ReadLine()!);

Console.WriteLine();
PrintArray(GetArray(size / 10, size % 10), numrows, numcolumns);
Console.WriteLine();
