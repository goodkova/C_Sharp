// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая, упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8
// Из задания не совсем понятно что нужно сделать. 
// Сортировка по убыванию или, как в примере, по возрастаеию.
// Для решения задачи я взяла за основу пример - сортировка по возрастанию.

int[,] CreateMatrix(int size)
{
    int[,] matrix = new int[size, size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            matrix[j, i] = rnd.Next(0, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int size = matrix.GetLength(0);

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write($"{matrix[j, i]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] SortInRows(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] result = new int[size, size];
    int[] cache = new int[size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            cache[j] = matrix[j, i];
        }

        Array.Sort(cache);

        for (int j = 0; j < size; j++)
        {
            result[j, i] = cache[j];
        }
    }

    return result;
}

void Main()
{
    int[,] m1 = CreateMatrix(4);
    PrintMatrix(m1);
    int[,] m2 = SortInRows(m1);
    PrintMatrix(m2);
}

Main();
