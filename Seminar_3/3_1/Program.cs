// Задача 1. Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).

void Quarters(int num)
{
    if (num == 1)
        Console.WriteLine($"{num} -> x > 0, y > 0");
    else if (num == 2)
        Console.WriteLine($"{num} -> x < 0, y > 0");
    else if (num == 3)
        Console.WriteLine($"{num} -> x < 0, y < 0");
    else if (num == 4)
        Console.WriteLine($"{num} -> x > 0, y < 0");
    else
        Console.WriteLine($"{num} -> not a quarter");
}

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
Quarters(a);