// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// \заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void GetNum(double B1, double K1, double B2, double K2)
{
    double x = (B2 - B1) / (K1 - K2);
    double y = K1 * x + B1;
    if(K1 == K2 && B1 != B2) Console.WriteLine($"({x}; {y}) -> Прямые не пересекаются, они параллельны");
    else if (K1 == K2 && B1 == B2) Console.WriteLine($"({x}; {y}) -> Прямые совпадают");
    else Console.WriteLine($"Прямые пересекаются в точке -> ({x}; {y})");
}
Console.WriteLine("Введите значения: ");
double b1 = double.Parse(Console.ReadLine()!);
double k1 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);
double k2 = double.Parse(Console.ReadLine()!);
GetNum(b1, k1, b2, k2);