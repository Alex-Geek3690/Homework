// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число А: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{num}, {num1} -> {GetPowNums(num, num1)}");

double GetPowNums(int number, int number1)
{
    double pow = 0;
    int i = 0;
    while (i <= number1)
    {
        pow = Math.Pow(number, i);
        i++;
    }
    return pow;
}