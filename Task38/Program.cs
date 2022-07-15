// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double [] getArray (double [] arr)
{
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
    }
return arr;
}

void printArray (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  ");
    }
}

double difference (double [] arr)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] <= min)
        {
            min = arr[i];
        }
    }
    return max - min; 
}

double [] array = new double [10];
getArray(array);
printArray(array);
Console.WriteLine();
Console.WriteLine(difference(array));