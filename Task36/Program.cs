// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int [] array = new int [10];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-999, 1000);
    }
Console.WriteLine(string.Join(", ", array));

int sum (int [] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            result = result + arr[i];
        }
    }
    return result;
}
Console.WriteLine(sum(array));