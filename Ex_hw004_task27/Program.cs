//Задача 27: Напишите метод, которая
// принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11   82 -> 10   9012 -> 12

Console.Clear();
Console.WriteLine("Enter the number: ");

string str = Console.ReadLine();
bool flag = true;
int i = 0;
int summ = 0;

while (i < str.Length && flag)
{
    if (str[i] >= '0' && str[i] <= '9')
    {
        summ += str[i] - '0';
        i++;
    }
    else
    {
        flag = false;
        break;
    }
}
if (flag)
{
    Console.WriteLine($"summ = {summ}");
}
else
{
    Console.WriteLine("Error: Incorrect input");
}
