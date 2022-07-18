// Урок 3. Массивы и функции в программировании
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// Уточнения
// 1. Метод получения данных - генерируются рандомно в интервале от -10 до 10 включая 0
// 2. 3D пространство - для решения используем координаты декартовой системы.
// 3. Метод вывода - печать в терминал

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Random rnd = new Random();
int lowerLimit = -10;
int upperLimit = 10;
int x1 = rnd.Next(lowerLimit,upperLimit);
int y1 = rnd.Next(lowerLimit,upperLimit);
int z1 = rnd.Next(lowerLimit,upperLimit);
int x2 = rnd.Next(lowerLimit,upperLimit);
int y2 = rnd.Next(lowerLimit,upperLimit);
int z2 = rnd.Next(lowerLimit,upperLimit);

Console.Clear();
Console.WriteLine($"first point {x1}, {y1}, {z1}");
Console.WriteLine($"second point {x2}, {y2}, {z2}"); 

double x = Math.Pow(x1 - x2, 2);
double y = Math.Pow(y1 - y2, 2);
double z = Math.Pow(z1 - z2, 2);

double d = Math.Sqrt(x + y + z);

double distance = Math.Round(d, 4);

Console.WriteLine($"distance = {distance}");
