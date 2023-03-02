// Задача 0. Напишите программу, которая принимает на вход координаты точки (x, y),
// причем x <> 0 или y <> 0 и выдает номер четверти плоскости,
// в которой находится эта точка

void Quarters (int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0, y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

Console.WriteLine("Введите число 1:");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2:");
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);