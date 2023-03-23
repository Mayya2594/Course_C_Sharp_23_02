// Задача 1: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void SeriesNums(int num)
{
    if(num == 0) return;
    SeriesNums(num - 1);
    Console.Write($"{num}, ");
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"{N} -> ");
SeriesNums(N);