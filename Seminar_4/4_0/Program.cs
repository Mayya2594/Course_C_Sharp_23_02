// Задача 1. Напишите программу, котора принимает на вход число (А)
// и на выходе выдает сумму чисел от 1 до А.

int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
        all_sum += i;
    return all_sum;
}

Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);