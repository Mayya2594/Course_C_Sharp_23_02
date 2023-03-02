// Задача 3. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

void Square(int num)
{
    int i = 1;
    while (i <= num)
    {

        Console.Write($"{Math.Pow(i, 2)}, ");
        i ++;
    }
}

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
Square(a);
