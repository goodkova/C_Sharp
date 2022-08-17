// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] getArray(int length)
{
    Random rnd = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int getEvens(int[] arr)
{
    int evens = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evens++;
        }
    }
    return evens;
}

int[] arr = getArray(4);
printArray(arr);
int evens = getEvens(arr);
Console.WriteLine($"\n{evens}");