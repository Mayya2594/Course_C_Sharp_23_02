// Задача 1. Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int LengthNum(int num)
{
    int a = 0;
    for (int i = 1; num > 0; i++)
    {
        num /= 10;
        a ++;
    }
    return a;
}

Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine()!);
int result = LengthNum(A);
Console.WriteLine(result);