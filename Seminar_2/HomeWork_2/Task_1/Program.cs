// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int TakeSecondNum(int num)
{
    Console.WriteLine(num);
    return num % 100 / 10;
}

int result = TakeSecondNum(new Random().Next(100, 1000));
Console.WriteLine(result);