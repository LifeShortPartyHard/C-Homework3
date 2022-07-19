// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] getArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
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

void itemOfArray (int [,] array, int indexOfRow, int indexOfColumn)
{
    if (indexOfRow < array.GetLength(0) && indexOfColumn < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента массива: {array[indexOfRow,indexOfColumn]}"); 
    }
    else
    {
        Console.WriteLine("В данном массиве не существует элемента с заданными значениями индексов!");
    }
}

int rows = 3;
int columns = 4;
int [,] array1 = getArray(rows, columns);
printArray(array1);
Console.WriteLine("Введите значение индекса строки:");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение индекса cтолбца:");
int index2 = Convert.ToInt32(Console.ReadLine());
itemOfArray(array1, index1, index2);