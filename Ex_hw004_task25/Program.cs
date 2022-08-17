// Задача 25: Напишите метод, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)   2, 4 -> 16

double exponentiation(int a, int b)
{
    return Math.Pow(a, b);
}

Random rnd = new Random();
int a = rnd.Next(2, 5);
int b = rnd.Next(2, 5);
double exp = exponentiation(a, b);
Console.WriteLine($"a = {a}, b = {b}");
Console.WriteLine($"a pow b = {exp}");
