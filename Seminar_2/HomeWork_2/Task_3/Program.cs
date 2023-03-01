// Задача 3: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void TakeThirdNum (int num)
{
    while (num <= -1000 || num >= 1000)
        num = num / 10;
    if(num >= 100 && num <= 999)
        Console.WriteLine(num % 10);
    else if (num >= -999 && num <= -100)
        Console.WriteLine(num % 10 * -1);
    else if (num > -100 && num < 100)
        Console.WriteLine("Третьей цифры нет");
}

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
TakeThirdNum(a);