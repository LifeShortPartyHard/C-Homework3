// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void orderedArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 1; x < array.GetLength(1); x++)
            {            
                int temp = 0;
                if (array[i,x] > array[i,x - 1])
                {
                    temp = array[i,x];
                    array[i,x] = array[i,x - 1];
                    array[i,x - 1] = temp; 
                }
            }            
        }
    }
}

int rows = 4;
int columns = 4;
int [,] array = getArray(rows, columns);
printArray(array);
Console.WriteLine();
orderedArray(array);
printArray(array);