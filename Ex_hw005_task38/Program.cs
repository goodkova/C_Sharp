// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

float[] getArray(int length)
{
    Random rnd = new Random();
    float[] arr = new float[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.NextSingle() * 100;
    }
    return arr;
}

void printArray(float[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

float getMinMaxDifference(float[] arr)
{
    float max = arr[0];
    float min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    return max - min;
}

float[] arr = getArray(5);
printArray(arr);
float diff = getMinMaxDifference(arr);
Console.WriteLine($"\nDifference = {diff}");
