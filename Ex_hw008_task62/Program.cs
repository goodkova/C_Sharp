// // Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7
// Нашла в интернете решение данной задачи. Закручивалась против часовой стрелки. 
// Развернула по часовой - как в условии.

int[,] SpiralFilling(int cols, int rows)
{
    int[,] matrix = new int[cols, rows];

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = cols;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[col, row] = i + 1;
        if (--visits == 0)
        {
            visits = cols * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
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

void Main()
{
    int[,] m = SpiralFilling(9, 5);
    PrintMatrix(m);
}

Main();