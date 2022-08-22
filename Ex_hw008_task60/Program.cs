// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int[,,] CreateMatrix(int size)
{
    int[,,] matrix = new int[size, size, size];
    int count = 10;

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrix[i, j, k] = count++;
            }
        }
    }

    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    int size = matrix.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}{j}{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void Main()
{
    int[,,] m = CreateMatrix(3);
    PrintMatrix(m);
}

Main();