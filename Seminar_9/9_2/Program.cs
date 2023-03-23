// Задача 2. Задайте значения M и N. Напишите программу, которая 
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void NumsFromTo(int from, int to)
{
    if(to < from) return;
    NumsFromTo(from, to - 1);
    Console.Write($"{to}, ");
}

Console.Write("Введите минимальную границу: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальную границу: ");
int max = int.Parse(Console.ReadLine()!);
Console.Write($"{min} to {max} ->  ");
NumsFromTo(min, max);