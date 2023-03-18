// Задача 2. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void FindNum (int[,] arr)
{
    Console.Write("Введите позицию х: ");
    int x = int.Parse(Console.ReadLine()!);
    Console.Write("Введите позицию y: ");
    int y = int.Parse(Console.ReadLine()!);
    if (x > arr.GetLength(0) || y > arr.GetLength(1))
        Console.WriteLine($"{x}, {y} - такого значения в массиве нет");
    else Console.WriteLine($"{x}, {y} -> {arr[x-1, y-1]}");
}

Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальную границу:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальную границу:");
int max = int.Parse(Console.ReadLine()!);


int[,] mass = MassNums(rows, columns, min, max);
Print(mass);
FindNum(mass);