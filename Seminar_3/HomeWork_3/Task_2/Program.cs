// Задача 2. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A(3, 6, 8); B(2, 1, -7) -> 15,84
// A(7, -5, 0); B(1, -1, 9) -> 11,53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

void Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double num = Math.Round(Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2)), 2);
    Console.WriteLine($"A({xA}, {yA}, {zA}); B({xB}, {yB}, {zB}) -> {num}");
}

Distance(7, -5, 0, 1, -1, 9);