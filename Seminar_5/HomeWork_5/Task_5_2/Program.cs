// Задача 2. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray (int size, int from, int to)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to);
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1) Console.Write($"{array[i]}]");
    Console.WriteLine();    
}

void OddSum (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
        sum += array[i];
    Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение:");
int max = int.Parse(Console.ReadLine()!);
int[] massive = FillArray(length, min, max);
PrintArray(massive);
OddSum(massive);