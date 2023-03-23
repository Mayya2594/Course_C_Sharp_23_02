// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.

int FindSum(int num)
{
    if(num == 0) return 0;
    return num % 10 + FindSum(num / 10);
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(FindSum(N));