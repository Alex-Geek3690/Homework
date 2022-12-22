// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
//  сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{N} -> {GetSumNums(N)}");

int GetSumNums(int num)
{
    int sum = 0;
    int result = 0;
    while (num > 0)
    {
        result = num % 10;
        sum = sum + result;
        num /= 10;
    }
    return sum;
}