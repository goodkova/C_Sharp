// Задача 29: Напишите метод(ы), которай задаёт массив
//  из 8 элементов и выводит их на экран. 
// (предполагается генерация случайных числе от 1 до 9)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] getArray(int length) 
{
    Random rnd = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-10, 10);
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

int[] arr = getArray(8);
printArray(arr);
