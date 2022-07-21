// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] getArray (int amountOfRows, int amountOfColumns)
{
    int [,] array = new int [amountOfRows,amountOfColumns];
    for (int i = 0; i < amountOfRows; i++)
    {
        for (int j = 0; j < amountOfColumns; j++)
        {
            array [i,j] = new Random().Next(-10,10);
        }
    }
    return array;
}

void printArray(int[,] array)
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

void average (int [,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = result + array [j,i];            
        }
        Console.Write(result / array.GetLength(0) + "; ");
    }
}

int rows = 4;
int columns = 4;
int [,] array = getArray(rows, columns);
printArray(array);
average(array);