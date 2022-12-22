// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



void FillArray(int[] array)
{
    int n = array.Length;
    int index = 0;

    while (index <= n)
    {
        if (index >= 0 && index < n - 1)
        {
            Console.Write(+array[index] + ", ");
        }
        if (index == n - 1)
        {
            Console.Write(+array[index] + " -> ");
        }
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (position == 0)
        {
            Console.Write("[" + col[position] + ", ");
        }
        if (position > 0 && position < count - 1)
        {
            Console.Write(col[position] + ", ");
        }
        if (position == count - 1)
        {
            Console.Write(col[position] + "]");
        }
        position++;
    }
}


int[] array = new int[8] { 13, 2, 34, 4, 5, 66, 7, 83 };

FillArray(array);
PrintArray(array);



