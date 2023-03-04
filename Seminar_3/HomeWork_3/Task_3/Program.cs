// Задача 3. Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube (int num)
{
    int i = 1;
    Console.Write($"{num} -> ");
    while (i < Math.Abs(num))
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
        i++;
    }
    if (i == Math.Abs(num)) Console.Write(Math.Pow(i, 3));
}

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine()!);
Cube(N);