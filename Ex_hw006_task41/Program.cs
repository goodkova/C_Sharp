// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string ENTER_NUMBER = "Enter the number";
string ENTER_LENGTH = "Enter the length of array (greater than 0): ";

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

int[] GetDataFromKbd()
{
    int length;

    do
    {
        length = GetNumberFromKbd(ENTER_LENGTH);
    } while (length <= 0);

    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = GetNumberFromKbd(ENTER_NUMBER + $" {i + 1}: ");
    }

    return array;
}

int GetNumberOfPositiveValues(int[] array)
{
    int numberOfPositive = 0;

    foreach (int item in array)
    {
        if (item > 0)
        {
            numberOfPositive++;
        }
    }

    return numberOfPositive;
}

void Main()
{
    int[] array = GetDataFromKbd();
    int result = GetNumberOfPositiveValues(array);
    
    Console.WriteLine($"Number of positive values = {result}");
}

Main();