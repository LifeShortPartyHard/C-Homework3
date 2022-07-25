// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] GetArray (int amountOfRows, int amountOfColumns)
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

void PrintArray(int[,] array)
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

int [,] ProductOfMatrix (int [,] array1, int [,] array2)
{
    int [,] result = new int [array1.GetLength(0),array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)    
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int x = 0; x < array2.GetLength(0); x++)
            {
                result[i,j] += array1[i,x] * array2[x,j];
            }            
        }
    }
    return result;
}

int rows = 3;
int columns = 3;
int [,] matrix1 = GetArray(rows, columns);
int [,] matrix2 = GetArray(rows, columns);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(ProductOfMatrix(matrix1,matrix2));