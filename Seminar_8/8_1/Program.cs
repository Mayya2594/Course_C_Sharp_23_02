// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

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

void ChangeRow (int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for(int j = 0; j < column; j++)
        (arr[0, j], arr[row-1, j]) = (arr[row-1, j], arr[0, j]);
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
ChangeRow(mass);
System.Console.WriteLine();
Print(mass);