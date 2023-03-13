// Задача 1: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

void Triangle( int a, int b, int c)
{
    if((a+b) > c && (b+c) > a && (a+c) > b)
        Console.WriteLine("Yes");
    else Console.WriteLine("No");
}

Console.WriteLine("Введите сторону 1:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону 2:");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону 3:");
int num3 = int.Parse(Console.ReadLine()!);
Triangle(num1, num2, num3);