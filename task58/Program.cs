// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MatrixMulti(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(0) != matrixB.GetLength(1))
    {
        Console.WriteLine("Умножение невозможно");
    }
    else
    {
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        // Console.WriteLine("Введите произведение двух матриц: ");
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {

                for (int k = 0; k < matrixB.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
                Console.Write($"{matrixC[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество строк 1 массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 1 массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);

Console.Write("Введите количество строк 2 массива: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 массива: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] MatrixArray = GetArray(rows2, columns2);
PrintArray(MatrixArray);
Console.WriteLine();
MatrixMulti(array, MatrixArray);