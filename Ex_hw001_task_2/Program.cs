
// Напишите прогрмму, которая на вход принимает два числа
// и выдает какое число больше, а какое меньше.
//
// Уточнения:
//1. Откуда приходят числа -  рандомно сгенерированы в диапазоне от 1 до 100
// 2. тип числа - целое число
// 3. Куда выводить результат -  числом в терминал

// Начало
// 1.Ввести переменные N1 = random (1-101], N2 = random (1-101],
// 2.Показать в терминале значение полученных переменных N1, N2,  
// 3.Если N1 > N2 => Вывести "N1  - this number is greater" и "N2- this number is less"
//   Если N1 < N2 => Вывести "N1  - this number is less" и "N2- this number is greater"
// конец

int N1 = new Random().Next(1, 101);
int N2 = new Random().Next(1, 101);

Console.WriteLine($"{N1} {N2}");

if (N1 > N2)
{
    Console.WriteLine($"{N1} - this number is greater, {N2} - this number is less");
}
if (N1 < N2)
{
    Console.WriteLine($"{N1} - this number is less, {N2} - this number is greater ");
}
