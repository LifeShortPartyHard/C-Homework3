// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumOfNaturalNumbers( int M, int N){
    if (M <= 0) M = 1;
    if (M == N) return N;
    int sum = M;
    return sum += SumOfNaturalNumbers(M += 1, N);
}

Console.WriteLine(SumOfNaturalNumbers(-5, 20));