// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumFromTo (int from, int to)
{
    if(from > to) return 0;
    return from + SumFromTo(from + 1, to);
}

Console.Write("Введите число 1: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumFromTo(A, B));