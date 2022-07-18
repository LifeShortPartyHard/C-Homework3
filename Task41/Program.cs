// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int [] array  = new int [M];

int amountOfPositiveNumbers (int [] arr)
{    
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] > 0)
        {
            result++;
        }
    }    
    return result; 
}

Console.WriteLine("Количество положительных чисел: " + amountOfPositiveNumbers(array));

