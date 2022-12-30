// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = 100 * Math.Round(new Random().NextDouble(), 4);
    }
    return res;
}
void PrintArray(double[] arr)
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
void DiffArray(double[] muss)
{
    int max = 0;
    int min = 0;
    double res = 0;
    for (int j = 1; j < muss.Length; j++)
    {
        if (muss[j] > muss[max]) max = j;
        if (muss[j] < muss[min]) min = j;
        res = Math.Round(muss[max] - muss[min], 2);
    }
    Console.Write(res);
}

double[] array = GetArray(5);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
DiffArray(array);
