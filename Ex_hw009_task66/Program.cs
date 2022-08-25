// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CalculateSumm(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
    return (end + start) * (end - start + 1) / 2; // по формуле суммы членов арифметической прогрессии
}

void Main()
{

    Random rnd = new Random();
    int m = rnd.Next(0, 100);
    int n = rnd.Next(0, 100);
    Console.WriteLine($"n = {n}, m = {m}");
    Console.WriteLine(CalculateSumm(n, m));
}

Main();
