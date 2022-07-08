// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки по оси x:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси y:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси z:");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси x:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси y:");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси z:");
double z2 = Convert.ToInt32(Console.ReadLine());
double distance = 0; 

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");