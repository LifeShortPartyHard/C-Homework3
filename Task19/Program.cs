// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число:");

int number = Convert.ToInt32(Console.ReadLine());
var digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

string getResult(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array[i] == array[array.Length - 1 - i])
            {
               result = "Данное число является палиндромом";
            }
        else
        {
            result = "Данное число не является палиндромом";
            break;
        }
    }
    return result;
}

Console.WriteLine(getResult(digitArray));