// Задача 1. Задайте массив, заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray (int size, int from, int to)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to);
    return array;
}

void PrintArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();    
}

void EvenNumbers (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) sum +=1;
    }
    Console.WriteLine($"Количество четных элементов массива = {sum}");
}


Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение:");
int min = int.Parse(Console.ReadLine()!);
if(min < 100 || min > 999) Console.WriteLine("Введено неверное значение, повторите ввод");
else 
{
    Console.WriteLine("Введите максимальное значение:");
    int max = int.Parse(Console.ReadLine()!);
    if(max < 100 || max > 1000) Console.WriteLine("Введено неверное значение, повторите ввод");
    else
    {
        int[] massive = FillArray(length, min, max);
        PrintArray(massive);
        EvenNumbers(massive);
    }
}    