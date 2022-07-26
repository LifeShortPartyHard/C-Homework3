//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string NaturalNumbers( int M, int N){
    if (M <= 0) M = 1;
    return M == N ? N.ToString(): M.ToString() + " " + NaturalNumbers(M += 1, N);
}

Console.WriteLine(NaturalNumbers(5, 20));