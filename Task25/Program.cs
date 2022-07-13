// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число:");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} ^ {B} = {Math.Pow(A, B)}");