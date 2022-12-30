// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i >= 0 && i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }

        if (i == arr.Length - 1)
        {
            Console.Write(arr[i] + "");
        }
    }
}

int[] array = GetArray(4, 100, 999);
Console.Write("[");
PrintArray(array);
Console.Write("]");

void SumNumArray(int[] array)
{
    int res = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            res++;
        }
    }
    Console.Write(res);
}
Console.Write(" -> ");
SumNumArray(array);
