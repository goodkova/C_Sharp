// Задача 19 
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// Уточнения
// 1. Метод получения данных - генерируются рандомнов интервале от 10000 до 99999
// 2. Числа-палиндромы — числа, которые читаются одинаково
//  как справа налево, так и слева направо.
// 3. Метод вывода - печать в терминал

// int N = new Random().Next(10000, 100000);
// int N1 = (N / 10000);
// int N2 = (N / 1000 % 10);
// int N4 = (N / 10 % 10);
// int N5 = (N % 10);

// if (N1 == N5 && N2 == N4)
// {
//     Console.WriteLine($"{N} is a palindrome");
// }
// else
// {
//     Console.WriteLine($"{N} is NOT a palindrome");
// }

bool flag = false;
while (!flag)
{
    int N = new Random().Next(10000, 100000);
    int N1 = (N / 10000);
    int N2 = (N / 1000 % 10);
    int N4 = (N / 10 % 10);
    int N5 = (N % 10);

    if (N1 == N5 && N2 == N4)
    {
        Console.WriteLine($"{N} is a palindrome");
        flag = true;
    }
    else
    {
        Console.WriteLine($"{N} is NOT a palindrome");
    }
}