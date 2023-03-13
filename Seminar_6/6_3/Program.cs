// Задача 3: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// f(n) = f(n-1) + f(n-2)

void Fibonacci (int num)
{
    int num1 = 0;
    int num2 = 1;
    Console.Write($"{num} -> ");
    for(int i = 0; i < num; i++)
    {
        Console.Write(num1 + " ");
        (num1, num2) = (num2, num1 + num2);
    }
}

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);
Fibonacci(n);
