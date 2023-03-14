// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection (double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            if (b1 != b2)
                Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
            else Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({Math.Abs(x)}; {y})");
        }
    else if(k1 == k2 && b1 != b2)
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> прямые параллельны");
    else Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> прямые совпадают");
}

Console.WriteLine("Введите значение b1:");
double B1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1:");
double K1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2:");
double B2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2:");
double K2 = double.Parse(Console.ReadLine()!);
Intersection(B1, K1, B2, K2);