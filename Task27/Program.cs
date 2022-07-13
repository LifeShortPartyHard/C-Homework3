// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
var digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
int result (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i ++)
        {
            sum = sum + array[i];
        }
    return sum;
}
Console.WriteLine($"Сумма цифр числа = {result(digitArray)}");