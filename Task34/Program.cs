// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int [] array = new int [10];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
Console.WriteLine(string.Join(", ", array));

int EvenNumbers (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count = count + 1;
        }    
    }
    return count;
}
Console.WriteLine(EvenNumbers(array));