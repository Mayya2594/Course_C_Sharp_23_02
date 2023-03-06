// Задача 1: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree (int num1, int num2)
{
    int res = 1;
    for (int i = 1; i <= num2; i++)
        res = res * num1;
    return res;
}

Console.WriteLine("Введите число А:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine()!);
int result = Degree(A, B);
Console.WriteLine($"{A}, {B} -> {result}");
