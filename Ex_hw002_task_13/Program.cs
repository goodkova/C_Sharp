﻿// Урок 2. Массивы и функции в программировании
// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Уточнения:
// 1. Откуда приходят числа -  генерируются рандомно в диапазоне 10 до 200
// 2. тип числа - целое число
// 3. Куда выводить результат -  строка в терминал

// Начало
// 1 Выести переменную N, esult,
// 2.Рандомно присвоить N значение в диапазоне от (10 - 200]
// 3.Показать значение N в терминале
// 4. Если N > 99  вычислить остаток от деления на 10 и показать результат в терминале,
// 5. Иначе, показать в терминале сообщение "no third digit"
//
int N = new Random().Next(10, 200);
Console.WriteLine($"N = {N}");
int result;

if (N > 99)
{
    result = N % 10;
    Console.WriteLine($"result = {result}");
}
else
{
    Console.WriteLine("no third digit");
}

