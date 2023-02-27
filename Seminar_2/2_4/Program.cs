// 3. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

void Div(int num)
{
    if(num % 7 == 0 && num % 23 == 0) // проверка на одновременное выполнение двух условий
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);

Div (a);