﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int D = int.Parse(Console.ReadLine()!);
int Sat = 6;
int Sun = 7;

if (D == Sat)
{
    Console.Write($"{D} -> Да");
}
else
{
    if (D == Sun)
    {
        Console.Write($"{D} -> Да");
    }
    else
    {
        Console.Write($"{D} -> Нет");
    }
}