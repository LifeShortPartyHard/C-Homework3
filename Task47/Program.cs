// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] randomArray(double [,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100,100)/10.0);
        }
    }
    return array;
}

void printArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = 5;
int n = 4;
double [,] array = new double [m,n];
printArray(randomArray(array));