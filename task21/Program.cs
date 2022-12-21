// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координаты точки А: Ax= ");
int Ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату: Ay= ");
int Ay = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату: Az= ");
int Az = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки B: Bx= ");
int Bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату: By= ");
int By = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату: Bz= ");
int Bz = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) + (Az - Bz) * (Az - Bz));
Console.WriteLine($"A({Ax},{Ay},{Az}); B({Bx},{By},{Bz}) -> {result}");
