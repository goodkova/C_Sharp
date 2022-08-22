// Задача с поворотом матрицы

int[,] CreateMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            matrix[j, i] = count++;
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

int[,] RotateMatrixCols(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] result = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            result[i, j] = matrix[size - i - 1, j];
        }
    }

    return result;
}

int[,] RotateMatrixRows(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] result = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            result[i, j] = matrix[i, size - j - 1];
        }
    }

    return result;
}

int[,] RotateMatrixQuarterTurn(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] result = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            result[i, j] = matrix[size - j - 1, i];
        }
    }

    return result;
}

int[,] RotateMatrixHalfTurn(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] result = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            result[j, i] = matrix[size - j - 1, size - i - 1];
        }
    }

    return result;
}

void Main()
{
    int[,] m1 = CreateMatrix(4);
    PrintMatrix(m1);
    int[,] m2 = RotateMatrixCols(m1);
    PrintMatrix(m2);
    int[,] m3 = RotateMatrixRows(m1);
    PrintMatrix(m3);
    int[,] m4 = RotateMatrixQuarterTurn(m1);
    PrintMatrix(m4);
    int[,] m5 = RotateMatrixHalfTurn(m1);
    PrintMatrix(m5);
}

Main();
