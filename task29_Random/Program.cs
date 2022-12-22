// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int[] array)
{
    int Length = array.Length;
    int index = 0;

    while (index < Length)
    {
        array[index] = new Random().Next(1, 10);
        if (index >= 0 && index < Length - 1)
        {
            Console.Write(+array[index] + ", ");
        }
        if (index == Length - 1)
        {
            Console.Write(+array[index] + " -> ");
        }
        index++;
    }
    return array;
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

int n = 8;
int[] array = new int[n];
Random rand = new Random();
FillArray(array);
PrintArray(array);



