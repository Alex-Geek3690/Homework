// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int[] array = GetArray(6, 1, 10);
Console.Write("[");
PrintArray(array);
Console.Write("]");

void SumNumArray(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (j % 2 == 1)
        {
            sum += array[j];
        }
    }
    Console.Write(sum);
}
Console.Write(" -> ");
SumNumArray(array);