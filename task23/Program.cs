// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);

int num = 1;
Console.Write($"{N} -> ");

while (num <= N)
{
    double result = Math.Pow(num, 3);

    if (num < N)
    {
        Console.Write(+result + ",");
    }
    else
    {
        Console.Write(result);
    }
    num++;
}
