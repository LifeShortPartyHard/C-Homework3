// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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


void smallestSumOfElements (int [,] array)
{
    Console.Write("Индекс строки с наименьшей суммой элементов: ");
    int sumFirstRow = 0;
    int rowNumber = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumFirstRow += array[0,j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array [i,j];            
        }
            if (sumFirstRow > result)
            {
                sumFirstRow = result;
                rowNumber = i;
            }
    }
    Console.WriteLine(rowNumber);
}

int rows = 4;
int columns = 4;
int [,] array = getArray(rows, columns);
printArray(array);
Console.WriteLine();
smallestSumOfElements(array);