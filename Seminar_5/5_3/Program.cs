// Задача 3. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


void Print (int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums (int size, int from, int to)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void Count(int[] arr)
{
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
        if (arr[i] >= 10 && arr[i] <= 99) res += 1;
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {res}");
}

Console.WriteLine("Введите количество элементов массива:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальную границу:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальную границу:");
int max = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(num, min, max);
Print(mass);
Count(mass);