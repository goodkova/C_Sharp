// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// // 10 6 24 49

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

int[,] MatrixMultiplication(int[,] m1, int[,] m2)
{
    int cols = m1.GetLength(0);
    int rows = m1.GetLength(1);
    int[,] result = new int[cols, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[j, i] = m1[j, i] * m2[j, i];
        }
    }

    return result;
}

void Main()
{
    int COLS = 4;
    int ROWS = 5;

    int[,] m1 = CreateMatrix(COLS, ROWS);
    PrintMatrix(m1);
    int[,] m2 = CreateMatrix(COLS, ROWS);
    PrintMatrix(m2);
    int[,] m3 = MatrixMultiplication(m1, m2);
    PrintMatrix(m3);
}

Main();