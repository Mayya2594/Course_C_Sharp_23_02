// Задача 6. Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
int b = a % 2;

if(b == 0)
{
    Console.WriteLine("Число четное");
}
else Console.WriteLine("Число нечетное");