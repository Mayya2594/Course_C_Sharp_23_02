// Задача 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void DayOfTheWeek(int num)
{
    if(num == 6 || num == 7) Console.WriteLine("Yes");
    else if(num > 0 && num < 6) Console.WriteLine("No");
    else Console.WriteLine("Not a day of the week");
}

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
DayOfTheWeek(a);