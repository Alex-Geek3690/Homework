// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int m, int n)
{
    if (n > m) return n > m ? n + SumRec(m, n - 1) : n;
    else return m > n ? m + SumRec(m - 1, n) : m;
}

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write($"M = {a}; N = {b} -> {SumRec(a, b)}");
