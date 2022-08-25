// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void PrintInterval(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
    for (int i = start; i <= end; i++)
    {
        Console.Write($"{i} ");
    }
}


void Main()
{
    Random rnd = new Random();
    int m = rnd.Next(0, 100);
    int n = rnd.Next(0, 100);

    Console.WriteLine($"n = {n}, m = {m}");
    PrintInterval(m, n);
}

Main();




