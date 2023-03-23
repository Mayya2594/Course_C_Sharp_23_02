// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void EvenNumsFromTo(int from, int to)
{
    if(to < from) return;
    if (from % 2 != 0) from ++;
    if (to % 2 !=0) --to;
    EvenNumsFromTo(from, to - 2);
    Console.Write($"{to}, ");
}

Console.Write("Введите минимальную границу: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальную границу: ");
int max = int.Parse(Console.ReadLine()!);
Console.Write($"{min} to {max} ->  ");
EvenNumsFromTo(min, max);