// Задача 4. Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int Power(int num1, int num2)
{
    if(num2 == 0) return 1;
    return num1 * Power(num1, num2 - 1);
}

Console.Write("Введите число 1: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Power(A, B));