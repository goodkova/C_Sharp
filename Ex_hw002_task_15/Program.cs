// Урок 2. Массивы и функции в программировании
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Уточнения
// 1. Метод получения данных - ввод через терминал пользователем
// 2. С какого дня начинается отсчет недели 1- Понедельник, 7- воскресенье
// 3. метод вывода - печать в терминал

int day = 0;
bool flag = false;
string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

while (!flag)
{
    Console.WriteLine("Enter day from 1 to 7: ");
    string str = Console.ReadLine();
    flag = str.Length == 1 && str[0] >= '1' && str[0] <= '7';
    if (flag)
    {
        day = Convert.ToInt32(str);
    }
}
string dayOfWeek = daysOfWeek[day - 1];
if (day < 6)
{
    Console.WriteLine($"you entered day {dayOfWeek}, it's workday");
}
else
{
    Console.WriteLine($"you entered day {dayOfWeek}, it's weekend");
}