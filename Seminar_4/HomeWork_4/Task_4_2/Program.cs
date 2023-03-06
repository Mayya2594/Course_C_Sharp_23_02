// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum (int num)
{
    int sum = 0;
    for (int i = 1; num > 0; i++)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите число:");
int A = Math.Abs(int.Parse(Console.ReadLine()!));
int result = SumNum(A);
Console.WriteLine($"{A} -> {result}");