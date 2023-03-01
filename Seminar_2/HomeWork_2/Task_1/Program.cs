// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void TakeSecondNum(int num)
{
    if(num >= 100 && num <= 999)
        Console.WriteLine(num % 100 / 10);
    else if (num >= -999 && num <= -100)
        Console.WriteLine(num % 100 / 10 * -1);
    else
        Console.WriteLine("Введено не трехзначное число");
}

Console.WriteLine("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine()!);

TakeSecondNum(a);