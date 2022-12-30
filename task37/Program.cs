// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] NumMus(int[] col)
{
    int[] arrays = new int[col.Length / 2 + col.Length % 2];

    for (int j = 0; j < arrays.Length; j++)
    {
        if (j == col.Length - 1 - j)
        {
            arrays[j] = col[j];
        }
        else
        {
            arrays[j] = col[j] * col[col.Length - 1 - j];

        }
    }
    return arrays;
}

int[] array = GetArray(5, 1, 10);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");

PrintArray(NumMus(array));
