// Задача 1. Напишите программу, которая принимакет на вход пятизначное число и проверяет,
// явлется ли число палиндромом.
// 14232 -> нет
// 23432 -> нет
// 12821 -> да

void Palindrom (int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10;
    int num5 = num % 10;
    if (num < 10000 || num > 99999)
        Console.WriteLine("Введено не пятизначное число, повторите ввод");
    else if(num1 == num5 && num2 == num4)
        Console.WriteLine($"{num} -> Yes");
    else Console.WriteLine($"{num} -> No");
}

Console.WriteLine("Введите пятизначное число:");
int a = int.Parse(Console.ReadLine()!);
Palindrom(a);