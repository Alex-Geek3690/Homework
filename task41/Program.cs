// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void GetArray(string[] col)
{
  int count = 0;
  foreach (string el in col)
  {
    if(int.Parse(el) > 0) count++;
    Console.Write($"{el} ");
  }
  Console.Write($"-> {count}");
}

Console.Write("Введите число: ");
string[] number = (Console.ReadLine()!).Split(',');
GetArray(number);
