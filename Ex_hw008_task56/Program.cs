// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int cols, int rows)
{
    int[,] matrix = new int[cols, rows];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[j, i] = rnd.Next(0, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int cols = matrix.GetLength(0);
    int rows = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[j, i]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int FindIndexOfMinRow(int[,] matrix)
{
    int cols = matrix.GetLength(0);
    int rows = matrix.GetLength(1);
    int[] cache = new int[rows];

    for (int i = 0; i < rows; i++)
    {
        cache[i] = 0;

        for (int j = 0; j < cols; j++)
        {
            cache[i] += matrix[j, i];
        }

        Console.Write($"{cache[i]} ");
    }
    Console.WriteLine();

    return FindIndexOfMin(cache);
}

int FindIndexOfMin(int[] array)
{
    int minIndex = 0;
    int minValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            minIndex = i;
        }
    }

    return minIndex;
}

void Main()
{
    int[,] m1 = CreateMatrix(4, 5);
    PrintMatrix(m1);
    int i = FindIndexOfMinRow(m1);
    Console.WriteLine($"minimum row is on {i + 1} position");
}

Main();