// Задача 2. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

// A (3, 6); B (2, 1) -> 5,09

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Console.WriteLine(Distance(3, 6, 2, 1));