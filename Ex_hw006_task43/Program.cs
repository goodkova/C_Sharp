// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

string ENTER_B1 = "Enter B1: ";
string ENTER_K1 = "Enter K1: ";
string ENTER_B2 = "Enter B2: ";
string ENTER_K2 = "Enter K2: ";

int GetNumberFromKbd(string message)
{
    Console.Write(message);

    bool flag;
    int number;

    do
    {
        string str = Console.ReadLine();
        flag = int.TryParse(str, out number);

        if (!flag)
        {
            Console.Write("Wrong value, enter the number again: ");
        }
    } while (!flag);

    return number;
}

(double, double) GetIntersectionPoint()
{
    int k1 = GetNumberFromKbd(ENTER_K1);
    int b1 = GetNumberFromKbd(ENTER_B1);
    int k2 = GetNumberFromKbd(ENTER_K2);
    int b2 = GetNumberFromKbd(ENTER_B2);

    if (k1 == k2)
    {
        return (Double.PositiveInfinity, Double.PositiveInfinity);
    }

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    return (x, y);
}

void PrintPointCoords((double, double) point)
{
    if (double.IsPositiveInfinity(point.Item1))
    {
        Console.WriteLine("There is no intersection point — lines are parallel");
    }
    else
    {
        Console.WriteLine(point.ToString());
    }
}

void Main()
{
    (double, double) point = GetIntersectionPoint();
    PrintPointCoords(point);
}

Main();