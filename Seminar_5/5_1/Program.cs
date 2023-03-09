// Задача 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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

void MasConverter(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}


Console.WriteLine("Введите количество элементов массива:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальную границу:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальную границу:");
int max = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, min, max);
Print(mass);
MasConverter(mass);
Print(mass);